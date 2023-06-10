using System.Diagnostics;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using WarmtePompGeluid.Excel;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid
{
    public class Calculator
    {



        public async Task<Output> Run(IWorkbook workbook, Input input)
        {
            workbook.WriteToWorkbook(input);
            RemoveOtherSheets(workbook, input);
            var output = workbook.ReadOutput(input);
            await Task.CompletedTask;
            return output;
        }

        private static void RemoveOtherSheets(IWorkbook workbook, Input input)
        {
            var s = 0;
            while (s < workbook.NumberOfSheets)
            {
                var name = workbook.GetSheetName(s);
                if (name == "Aanstuurblad" || name == input.Model)
                {
                    s++;
                }
                else
                {
                    workbook.RemoveSheetAt(s);
                }
            }
        }
    }
}