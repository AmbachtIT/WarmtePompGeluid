using NPOI.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambacht.Common.Excel
{
    public abstract class ExcelAstNode
    {

        public abstract void Write(StringBuilder builder, int indent);


    }

    public class ExcelVariableNode : ExcelAstNode
    {
        public string Name { get; }

        public ExcelVariableNode(string name)
        {
            Name = name;
        }

        public override void Write(StringBuilder builder, int indent)
        {
            builder.Append("".PadRight(indent));
            builder.AppendLine($"Variable: {Name}");
        }
    }

    public class ExcelFunctionNode : ExcelAstNode
    {
        public string Name { get; }
        public List<ExcelAstNode> Arguments { get; }

        public ExcelFunctionNode(string name, List<ExcelAstNode> arguments)
        {
            Name = name;
            Arguments = arguments;
        }


        public override void Write(StringBuilder builder, int indent)
        {
            builder.Append("".PadRight(indent));
            builder.AppendLine($"Function: {Name}");
            foreach (var arg in Arguments)
            {
                arg.Write(builder, indent + 2);
            }
        }

    }

    public class ExcelOperatorNode : ExcelAstNode
    {
        public string Operator { get; }
        public ExcelAstNode Left { get; }
        public ExcelAstNode Right { get; }

        public ExcelOperatorNode(string op, ExcelAstNode left, ExcelAstNode right)
        {
            Operator = op;
            Left = left;
            Right = right;
        }

        public override void Write(StringBuilder builder, int indent)
        {
            builder.Append("".PadRight(indent));
            builder.AppendLine($"Binary Operator: {Operator}");
            Left.Write(builder, indent + 2);
            Right.Write(builder, indent + 2);
        }
    }

    public class ExcelConstantNode<T> : ExcelAstNode
    {
        public T Value { get; }

        public ExcelConstantNode(T value)
        {
            Value = value;
        }

        public override void Write(StringBuilder builder, int indent)
        {
            builder.Append("".PadRight(indent));
            builder.AppendLine($"Constant: {Value}");
        }
    }

    public class ExcelUnaryOperatorNode : ExcelAstNode
    {
        public string Operator { get; }
        public ExcelAstNode Operand { get; }

        public ExcelUnaryOperatorNode(string op, ExcelAstNode operand)
        {
            Operator = op;
            Operand = operand;
        }

        public override void Write(StringBuilder builder, int indent)
        {
            builder.Append("".PadRight(indent));
            builder.AppendLine($"Unary Operator: {Operator}");
            Operand.Write(builder, indent + 2);
        }
    }


    public class ExcelParenthesesNode : ExcelAstNode
    {
        public ExcelAstNode Expression { get; }

        public ExcelParenthesesNode(ExcelAstNode expression)
        {
            Expression = expression;
        }

        public override void Write(StringBuilder builder, int indent)
        {
            builder.Append("".PadRight(indent));
            builder.AppendLine($"Parentheses:");
            Expression.Write(builder, indent + 2);
        }
    }
}
