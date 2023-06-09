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
            var input = new Input()
            {
                Model = model,
                PlanGegevens = new PlanGegevens()
                {
                    Organisatie = "WarmtePompGeluid",
                    Uitvoerder = "Unit Test",
                    Omschrijving = "Testing passing model " + model
                }
            };

            var workbook = await NPOIUtil.Read(_path);
            workbook.WriteToWorkbook(input);

            var path2 = _path.Replace(".xlsx", $"-{model}-pass.xlsx");
            await workbook.Write(path2);

            var output = workbook.ReadOutput(input);
            Assert.That(output.VoldoetDag, Is.True);
            Assert.That(output.VoldoetNacht, Is.True);
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