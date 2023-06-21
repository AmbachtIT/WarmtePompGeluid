﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using WarmtePompGeluid.Excel;

namespace Ambacht.Common.Excel;

public class ExcelToCSharpConverter
{


    public ExcelToCSharpConverter(IWorkbook workbook)
    {
        _builder = new ExcelExpressionTreeBuilder(workbook);
    }


    private readonly ExcelExpressionTreeBuilder _builder;
    private readonly HashSet<string> _addresses = new HashSet<string>();


    public string Namespace { get; set; }

    public string ClassName { get; set; } = "Workbook";




    public async Task Convert(TextWriter writer, IEnumerable<CellReference> references, ISheet sheet)
    {
        _addresses.Clear();

        await writer.WriteLineAsync("using System;");
        await writer.WriteLineAsync("using System.Collections.Generic;");
        await writer.WriteLineAsync("using System.Text;");
        await writer.WriteLineAsync("using System.Linq;");
        await writer.WriteLineAsync("using Ambacht.Common.Excel;");
        if (!string.IsNullOrEmpty(Namespace))
        {
            await writer.WriteLineAsync();
            await writer.WriteLineAsync($"namespace {Namespace};");
        }
        await writer.WriteLineAsync();
        await writer.WriteLineAsync("public class " + ClassName + " : ExcelCalculatorBase {");

        foreach (var item in _builder.Calculate(references, sheet))
        {
            if (item.IsInput)
            {
                await WriteInput(writer, item);
            }
            else
            {
                await WriteFormula(writer, item);
            }
        }

        await WriteAddresses(writer);

        await writer.WriteLineAsync("}");

    }

    private async Task WriteInput(TextWriter writer, ExcelExpressionTreeBuilder.Node item)
    {
        var type = GetVariableType(item);
        await writer.WriteLineAsync();
        await writer.WriteLineAsync("\t/// <summary>");
        await writer.WriteLineAsync($"\t/// {item.Description}");
        await writer.WriteLineAsync("\t/// </summary>");
        await writer.WriteLineAsync($"\tpublic {type} {item.CellName} {{");
        await writer.WriteLineAsync($"\t\tget => this[Addresses.{item.CellName}];");
        await writer.WriteLineAsync($"\t\tset => this[Addresses.{item.CellName}] = value;");
        await writer.WriteLineAsync($"\t}}");
        await writer.WriteLineAsync();
    }

    private string GetVariableType(ExcelExpressionTreeBuilder.Node item) => item.CellType switch
    {
        CellType.Numeric => "double?",
        CellType.String => "string",
        _ => "object"
    };

    private async Task WriteFormula(TextWriter writer, ExcelExpressionTreeBuilder.Node item)
    {
        var expression = GetExpression(item.Expression);
        await writer.WriteLineAsync();
        await writer.WriteLineAsync("\t/// <summary>");
        await writer.WriteLineAsync($"\t/// {item.Description}");
        await writer.WriteLineAsync("\t/// </summary>");
        await writer.WriteLineAsync($"\tpublic object {item.CellName} => {expression};");
        await writer.WriteLineAsync();
    }

    private string GetExpression(ExcelAstNode expression)
    {
        var builder = new StringBuilder();
        WriteExpression(builder, expression);
        return builder.ToString();
    }


    private void WriteExpression(StringBuilder builder, ExcelAstNode expression)
    {
        if (expression is ExcelFunctionNode function)
        {
            builder.Append(function.Name);
            for (var i = 0; i < function.Arguments.Count; i++)
            {
                if (i == 0)
                {
                    builder.Append("(");
                }
                else
                {
                    builder.Append(", ");
                }
                WriteExpression(builder, function.Arguments[i]);
            }

            builder.Append(")");
        }

        if (expression is ExcelConstantNode<double> dbl)
        {
            builder.Append(dbl.Value.ToString(CultureInfo.InvariantCulture));
        }
        if (expression is ExcelConstantNode<string> str)
        {
            builder.Append($"\"{str.Value}\"");
        }
        if (expression is ExcelUnaryOperatorNode unary)
        {
            builder.Append(unary.Operator);
            WriteExpression(builder, unary.Operand);
        }

        if (expression is ExcelOperatorNode op)
        {
            WriteExpression(builder, op.Left);
            builder.Append($" {op.Operator} ");
            WriteExpression(builder, op.Right);
        }

        if (expression is ExcelVariableNode variable)
        {
            var formatted = variable.Name.Replace("$", "");
            _addresses.Add(formatted);
            builder.Append(formatted);
        }

        if (expression is ExcelParenthesesNode parentheses)
        {
            builder.Append("(");
            WriteExpression(builder, parentheses.Expression);
            builder.Append(")");
        }
    }

    private async Task WriteAddresses(TextWriter writer)
    {
        await writer.WriteLineAsync($"\tpublic static class Addresses");
        await writer.WriteLineAsync($"\t{{");
        foreach (var address in _addresses.Order())
        {
            var addr = new CellAddress(address);
            await writer.WriteLineAsync($"\t\tpublic static readonly (int, int) {address} = new({addr.Row}, {addr.Column});");
        }
        await writer.WriteLineAsync($"\t}}");

    }

}