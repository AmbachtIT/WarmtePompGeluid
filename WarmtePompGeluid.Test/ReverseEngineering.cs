﻿using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambacht.Common.Excel;
using NPOI.HSSF.Model;
using NPOI.HSSF.UserModel;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using WarmtePompGeluid.Excel;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid.Test
{
    public class ReverseEngineering
    {



        [Test(), Explicit()]
        public async Task ExtractFormulas()
        {
            var workbook = await NPOIUtil.Read(_path);
            for (var s = 1; s < workbook.NumberOfSheets; s++)
            {
                var sheet = workbook.GetSheetAt(s);
                await GenerateCode(sheet, s, workbook);
                await ExtractFormulas(sheet, s, workbook);
            }
        }


        private async Task GenerateCode(ISheet sheet, int s, IWorkbook workbook)
        {
            var situatie = Situatie.ByName(sheet.SheetName);
            if (situatie == null)
            {
                return;
            }
            using (var writer = new StringWriter())
            {
                await new ExcelToCSharpConverter(workbook)
                {
                    ClassName = $"Calculator_{sheet.SheetName}",
                    Namespace = "WarmtePompGeluid.Model.Generated",
                }.Convert(writer, situatie.AllResultCells(), sheet);

                await writer.FlushAsync();

                await File.WriteAllTextAsync(
                    Path.Combine(BasePath,
                        $"WarmtePompGeluid\\Model\\Generated\\Calculator_{sheet.SheetName}.generated.cs"), writer.ToString());
            }
        }

        private async Task ExtractFormulas(ISheet sheet, int s, IWorkbook workbook)
        {
            Console.WriteLine($"------ Sheet {sheet.SheetName} -------------------------");
            var situatie = Situatie.ByName(sheet.SheetName);
            if (situatie == null)
            {
                return;
            }

            foreach (var node in new ExcelExpressionTreeBuilder(workbook).Calculate(situatie.AllResultCells(), sheet))
            {
                Console.WriteLine(node);
                var builder = new StringBuilder();
                node.Expression?.Write(builder, 0);
                Console.WriteLine(builder);

            }
            using (var writer = new StreamWriter(Path.Combine(BasePath, $"formulas-{sheet.SheetName}.txt")))
            {
                for (var r = sheet.FirstRowNum; r <= sheet.LastRowNum; r++)
                {
                    var row = sheet.GetRow(r);
                    for (var c = 0; c < row.Cells.Count; c++)
                    {
                        var cell = row.Cells[c];
                        if (cell.CellType == CellType.Formula)
                        {
                            await writer.WriteAsync($"{cell.Address.FormatAsString()} = {Parse(cell.CellFormula, workbook, s,  r)}");
                        }
                        await writer.WriteAsync("\t");
                    }

                    await writer.WriteLineAsync();
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private string Parse(string formula, IWorkbook workbook, int s, int r)
        {
            try
            {
                if (string.IsNullOrEmpty(formula))
                {
                    return formula;
                }

                var builder = new StringBuilder();
                foreach (var token in ExcelLexer.Tokenize(formula))
                {
                    builder.Append(token);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not parse: {formula}");
            }
            return formula;
        }



        private const string BasePath = @"C:\Projects\WarmtePompGeluid\main";

        private readonly string _path = Path.Combine(BasePath, @"data\WPAC-geluid_V2020_0.xlsx");

    }
}
