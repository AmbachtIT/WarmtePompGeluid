using System.Drawing.Text;
using Ambacht.Common.Excel;
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
                NachtProductie = productie,
                PlanGegevens = new PlanGegevens()
                {
                    Organisatie = "WarmtePompGeluid",
                    Uitvoerder = "Unit Test",
                    Omschrijving = "Testing passing model " + model
                }
            };

            var workbook = await NPOIUtil.Read(_path);
            var calculator = Calculator.CreateExcel(workbook);

            var output = await calculator.Run(input);


            var suffix = pass ? "pass" : "fail";
            var path2 = _path.Replace(".xlsx", $"-{model}-{suffix}.xlsx");
            await workbook.Write(path2);

            Assert.That(output.Dag.Voldoet, Is.EqualTo(pass));
            Assert.That(output.Nacht.Voldoet, Is.EqualTo(pass));
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