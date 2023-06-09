using System.Diagnostics;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid
{
    public class Calculator
    {



        public async Task Run(IWorkbook workbook, Input input)
        {
            await Task.CompletedTask;
        }

        private void Process(IWorkbook workbook, Input input)
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