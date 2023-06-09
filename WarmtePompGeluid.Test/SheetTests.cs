using System.Drawing.Text;
using NPOI.XSSF.UserModel;
using WarmtePompGeluid.Excel;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid.Test
{
    [TestFixture()]
    public class TestCalculator
    {

        [Test()]
        public async Task ReadSheet()
        {
            var output = await ReadSheet(_path);
            Assert.NotNull(output);
            Assert.That(output.PlanGegevens.Omschrijving, Is.EqualTo("Warmtepomp aan Transitielaan 7 te Ecodorp"));
            Assert.That(output.PlanGegevens.Organisatie, Is.EqualTo("Installatiebedrijf X"));
            Assert.That(output.PlanGegevens.Uitvoerder, Is.EqualTo("De berekenaar"));
        }

        private async Task<Output> ReadSheet(string path)
        {
            await using var stream = File.OpenRead(path);
            using var workbook = new XSSFWorkbook(stream);
            var sheet = workbook.GetSheet("AP");
            var output = sheet.MapSheetToObject<Output>();
            return output;
        }

        [Test()]
        public async Task TestWriteSheet()
        {
            var output1 = await ReadSheet(_path);
            await using var stream = File.OpenRead(_path);
            using var workbook = new XSSFWorkbook(stream);
            var sheet = workbook.GetSheet("AP");
            var input = new Input()
            {
                PlanGegevens = new PlanGegevens()
                {
                    Omschrijving = "Modified: " + output1.PlanGegevens.Omschrijving,
                    Organisatie = "Modified: " + output1.PlanGegevens.Organisatie,
                    Uitvoerder = "Modified: " + output1.PlanGegevens.Uitvoerder,
                }
            };

            sheet.MapObjectToSheet(input);

            var path2 = _path.Replace(".xlsx", "-modified.xlsx");
            await workbook.Write(path2);

            var output2 = await ReadSheet(path2);
            Assert.That(output2.PlanGegevens, Is.EqualTo(input.PlanGegevens));
        }


        private const string _path = @"C:\Projects\WarmtePompGeluid\main\data\WPAC-geluid_V2020_0.xlsx";

    }
}