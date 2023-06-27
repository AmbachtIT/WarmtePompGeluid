using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambacht.Common.Excel;
using WarmtePompGeluid.Excel;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid
{
    public class ExcelCalculator : Calculator
    {

        public ExcelCalculator(IWorkbook workbook)
        {
            _workbook = workbook;
        }

        private readonly IWorkbook _workbook;

        public override async Task<Output> Run(Input input, CancellationToken token)
        {
            var workbook = _workbook ?? await LoadWorkbook();
            return await Run(workbook, input);
        }

        private async Task<IWorkbook> LoadWorkbook()
        {
            await using var stream = 
                GetType()
                    .Assembly
                    .GetManifestResourceStream($"WarmtePompGeluid.Data." + Filename);
            return NPOIUtil.Read(stream, Filename);
        }

        private async Task<Output> Run(IWorkbook workbook, Input input)
        {
            var sheet = workbook.GetSheet(input.Situatie);
            if (sheet == null)
            {
                throw new InvalidOperationException();
            }

            this.SheetAdapter = new ExcelSheetAdapter(workbook, sheet);
            SheetAdapter.WriteToSheet(input);
            var evaluator = new CellEvaluator(workbook);
            evaluator.EvaluateAll();
            RemoveOtherSheets(workbook, input);
            var output = SheetAdapter.ReadOutput(input.Situatie);
            await Task.CompletedTask;
            return output;
        }

        private static void RemoveOtherSheets(IWorkbook workbook, Input input)
        {
            var s = 0;
            while (s < workbook.NumberOfSheets)
            {
                var name = workbook.GetSheetName(s);
                if (name == "Aanstuurblad" || name == input.Situatie)
                {
                    s++;
                }
                else
                {
                    workbook.RemoveSheetAt(s);
                }
            }
        }

        public const string Filename = "WPAC-geluid_V2020_0.xlsx";
    }
}
