using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.Model;
using NPOI.HSSF.UserModel;
using NPOI.SS.Formula;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using WarmtePompGeluid.Excel;

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
                await ExtractFormulas(sheet, s, workbook);
            }
        }

        private string GetCell(string sheetName) => sheetName switch
        {
            "Gg_1" => "B89",
            "Gg_2" => "B89",
            "Gg_2a" => "B89",
            "Gg_3" => "B86",
            "AP" => "B70",
            _ => null
        };

        private async Task ExtractFormulas(ISheet sheet, int s, IWorkbook workbook)
        {
            Console.WriteLine($"------ Sheet {sheet.SheetName} -------------------------");
            var name = GetCell(sheet.SheetName);
            if (string.IsNullOrEmpty(name))
            {
                return;
            }
            var cellReference = new CellReference(name);
            foreach (var node in new ExcelExpressionTreeBuilder(workbook).Calculate(cellReference, sheet).Reverse())
            {
                Console.WriteLine(node);
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



        private const string BasePath = @"C:\Projects\WarmtePompGeluid\main\data";

        private readonly string _path = Path.Combine(BasePath, @"WPAC-geluid_V2020_0.xlsx");

    }
}
