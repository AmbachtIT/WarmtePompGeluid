using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid.Excel
{
    public static class CellMapper
    {

        public static void WriteToWorkbook(this IWorkbook workbook, Input input)
        {
            var sheet = workbook.GetSheet(input.Model);
            if (sheet == null)
            {
                throw new InvalidOperationException();
            }
            sheet.WriteToSheet(input);
        }


        public static void WriteToSheet(this ISheet sheet, Input input)
        {
            sheet.WriteToSheet(input.PlanGegevens);
        }

        public static void WriteToSheet(this ISheet sheet, PlanGegevens gegevens)
        {
            var reference = new CellReference("B1");
            sheet.SetValue(reference = reference.Below(), gegevens.Omschrijving);
            sheet.SetValue(reference = reference.Below(), gegevens.Organisatie);
            sheet.SetValue(reference = reference.Below(), gegevens.Uitvoerder);
        }


        public static Output ReadOutput(this IWorkbook workbook, Input input)
        {
            var sheet = workbook.GetSheet(input.Model);
            if (sheet == null)
            {
                throw new InvalidOperationException();
            }

            return ReadOutput(sheet, input.Model);
        }

        public static Output ReadOutput(this ISheet sheet, string model)
        {
            var row = GetResultRow(model);
            return new Output()
            {
                VoldoetDag = sheet.GetStringValue(new CellReference(row, 1))?.ToLower() == "voldoet",
                VoldoetNacht = sheet.GetStringValue(new CellReference(row, 4))?.ToLower() == "voldoet",
            };
        }

        private static int GetResultRow(string model) => model switch
        {
            "AP" => 69,
            "Gg_3" => 85,
            _ => 88
        };


    }
}
