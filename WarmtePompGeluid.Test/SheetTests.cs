using System.Drawing.Text;
using NPOI.HPSF;
using NPOI.OpenXmlFormats.Shared;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NUnit.Framework.Constraints;
using WarmtePompGeluid.Excel;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid.Test
{
    [TestFixture()]
    public class TestCalculator
    {


        [Test(), Explicit(), TestCaseSource(nameof(AllModels))]
        public async Task TestModelPass(string model)
        {
            await TestModel(model, 10, true);
        }


        [Test(), Explicit(), TestCaseSource(nameof(AllModels))]
        public async Task TestModelFail(string model)
        {
            await TestModel(model, 100, false);
        }


        private async Task TestModel(string model, double LwAMax, bool pass)
        {
            var productie = new GeluidsProductie()
            {
                LwAMax = LwAMax
            };
            var input = new Input()
            {
                Situatie = model,
                DagProductie = productie,
                AvondNachtProductie = productie,
                PlanGegevens = new PlanGegevens()
                {
                    Organisatie = "WarmtePompGeluid",
                    Uitvoerder = "Unit Test",
                    Omschrijving = "Testing passing model " + model
                }
            };

            var workbook = await NPOIUtil.Read(_path);
            var calculator = new Calculator();

            var output = await calculator.Run(workbook, input);


            var suffix = pass ? "pass" : "fail";
            var path2 = _path.Replace(".xlsx", $"-{model}-{suffix}.xlsx");
            await workbook.Write(path2);

            Assert.That(output.VoldoetDag, Is.EqualTo(pass));
            Assert.That(output.VoldoetNacht, Is.EqualTo(pass));
        }


        [Test(), Explicit()]
        public async Task ExtractFormulas()
        {
            var workbook = await NPOIUtil.Read(_path);
            for (var s = 1; s < workbook.NumberOfSheets; s++)
            {
                var sheet = workbook.GetSheetAt(s);
                await ExtractFormulas(sheet);
            }
        }

        private async Task ExtractFormulas(ISheet sheet)
        {
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
                            await writer.WriteAsync($"{cell.Address.FormatAsString()} = {cell.CellFormula}");
                        }
                        await writer.WriteAsync("\t");
                    }

                    await writer.WriteLineAsync();
                }
            }
        }

        private const string BasePath = @"C:\Projects\WarmtePompGeluid\main\data";


        private readonly string _path = Path.Combine(BasePath, @"WPAC-geluid_V2020_0.xlsx");


        private static IEnumerable<string> AllModels()
        {
            yield return "Gg_1";
            yield return "Gg_2";
            yield return "Gg_2A";
            yield return "Gg_3";
            yield return "AP";
        }

    }
}