using System.Diagnostics;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid
{
    public class Calculator
    {



        public async Task Run(string path, Output input)
        {
            
            using (var stream = File.OpenRead(path))
            {
                var workbook = new XSSFWorkbook(stream);
                Process(workbook, input);
                await Save(path, workbook);

            }
        }

        private void Process(IWorkbook workbook, Output input)
        {
            var sheet = workbook.GetSheet(input.Model);
            if (sheet == null)
            {
                throw new InvalidOperationException("Sheet not found: " + input.Model);
            }

        }

        private async Task Save(string path, IWorkbook workbook)
        {
            await using var stream = File.Create(path.Replace(".xlsx", "-out.xlsx"));
            workbook.Write(stream, false);
        }


    }
}