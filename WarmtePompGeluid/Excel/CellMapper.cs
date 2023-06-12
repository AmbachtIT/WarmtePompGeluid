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
            var sheet = workbook.GetSheet(input.Situatie);
            if (sheet == null)
            {
                throw new InvalidOperationException();
            }
            sheet.WriteToSheet(input);
            var evaluator = new CellEvaluator(workbook);
            evaluator.EvaluateAll();
        }


        private static void WriteToSheet(this ISheet sheet, Input input)
        {
            sheet.WriteToSheet(input.PlanGegevens);
            sheet.WriteToSheet(input.DagProductie, input.Situatie, 2);
            sheet.WriteToSheet(input.AvondNachtProductie, input.Situatie, 5);
        }


        private static void WriteToSheet(this ISheet sheet, GeluidsProductie productie, string model, int column)
        {
            var reference = new CellReference(GetResultRow(model) - 4, column);
            sheet.SetValue(reference, productie.LwAMax);
            sheet.SetValue(reference = reference.Below(), productie.K1);
            sheet.SetValue(reference = reference.Below(), productie.DOmkasting);
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
            var sheet = workbook.GetSheet(input.Situatie);
            if (sheet == null)
            {
                throw new InvalidOperationException();
            }

            var evaluator = new CellEvaluator(workbook);

            return ReadOutput(sheet, evaluator, input.Situatie);
        }

        public static Output ReadOutput(this ISheet sheet, CellEvaluator evaluator, string model)
        {
            var row = GetResultRow(model);
            return new Output()
            {
                VoldoetDag = evaluator.GetStringValue(sheet, new CellReference(row, 1))?.ToLower() == "voldoet",
                VoldoetNacht = evaluator.GetStringValue(sheet, new CellReference(row, 4))?.ToLower() == "voldoet",
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
