using System.Drawing.Text;
using NPOI.XSSF.UserModel;
using NUnit.Framework.Constraints;
using WarmtePompGeluid.Excel;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid.Test
{
    [TestFixture()]
    public class TestCalculator
    {

        [Test(), TestCaseSource(nameof(AllModels))]
        public async Task TestModelPass(string model)
        {
            await TestModel(model, 10, true);
        }


        [Test(), TestCaseSource(nameof(AllModels))]
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


        private const string _path = @"C:\Projects\WarmtePompGeluid\main\data\WPAC-geluid_V2020_0.xlsx";


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