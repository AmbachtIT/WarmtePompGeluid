using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ambacht.Common.Excel;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid.Excel
{
    public static class CellMapper
    {

        public static void WriteToSheet(this ISheetAdapter sheet, Input input)
        {
            var situatie = Situatie.ByName(input.Situatie);
            sheet.WriteToSheet(input.PlanGegevens);
            sheet.WriteToSheet(input.BronPositie);
            sheet.SetValue("B16", input.Marge);
            sheet.WriteToSheet(input.DagProductie, situatie, 2);
            sheet.WriteToSheet(input.NachtProductie, situatie, 5);
            sheet.WriteToSheet(input.OntvangstPosities, situatie);
        }


        public static void WriteToSheet(this ISheetAdapter sheet, PlanGegevens gegevens)
        {
            var reference = new CellRef("B1");
            sheet.SetValue(reference = reference.Below(), gegevens.Omschrijving);
            sheet.SetValue(reference = reference.Below(), gegevens.Organisatie);
            sheet.SetValue(reference = reference.Below(), gegevens.Uitvoerder);
        }

        public static void WriteToSheet(this ISheetAdapter sheet, Vector3 pos)
        {
            var reference = new CellRef("B10");
            sheet.SetValue(reference = reference.Below(), pos.X);
            sheet.SetValue(reference = reference.Below(), pos.Y);
            sheet.SetValue(reference = reference.Below(), pos.Z);
        }


        private static void WriteToSheet(this ISheetAdapter sheet, List<OntvangstPositie> posities, Situatie situatie)
        {
            var row = situatie.OntvangstPositieInputRow - 1;
            var count = situatie.OntvangstPositieCount;
            for (var i = 0; i < count; i++)
            {
                var col = 2 + i;
                var positie = i < posities.Count ? posities[i] : null;
                if (positie == null)
                {
                    sheet.SetValue(new CellRef(row, col), "nvt");
                    for (var r = 1; r <= 7; r++)
                    {
                        sheet.SetValue(new(row + r, col), null);
                    }
                }
                else
                {
                    sheet.SetValue(new CellRef(row, col), positie.Positie.X);
                    sheet.SetValue(new CellRef(row + 1, col), positie.Positie.Y);
                    sheet.SetValue(new CellRef(row + 2, col), positie.Positie.Z);

                    sheet.WriteBool(new CellRef(row + 3, col), positie.IsBuitenUnitAfgeschermd);
                    sheet.WriteBool(new CellRef(row + 4, col), positie.IsRaamDeurMetBalkon);

                    sheet.SetValue(new CellRef(row + 5, col), positie.QGeluidsBron);
                    sheet.SetValue(new CellRef(row + 6, col), positie.QOntvanger);
                }
            }
        }


        private static void WriteBool(this ISheetAdapter sheet, CellRef addr, bool value)
        {
            sheet.SetValue(addr, value ? "j" : "n");
        }


        private static void WriteToSheet(this ISheetAdapter sheet, GeluidsProductie productie, Situatie situatie, int column)
        {
            var reference = new CellRef(situatie.ResultRow - 5, column);
            sheet.SetValue(reference, productie.LwAMax);
            sheet.SetValue(reference = reference.Below(), productie.K1);
            sheet.SetValue(reference = reference.Below(), productie.DOmkasting);
        }



        public static Output ReadOutput(this ISheetAdapter sheet, string situatieName)
        {
            var situatie = Situatie.ByName(situatieName);
            return new Output()
            {
                Dag = sheet.ReadDagdeel(situatie, 1),
                Nacht = sheet.ReadDagdeel(situatie, 4),
                OntvangstPosities = sheet.ReadPosities(situatie).ToList()
            };
        }

        public static IEnumerable<OntvangstPositieOutput> ReadPosities(this ISheetAdapter sheet, Situatie situatie)
        {
            var inputRow = situatie.OntvangstPositieInputRow - 1;
            var count = situatie.OntvangstPositieCount;
            var rowToelaatbaar = situatie.OntvangstPositieToelaatbaarRow - 1;
            for (var i = 0; i < count; i++)
            {
                var col = 2 + i;
                var val = sheet.GetStringValue(new(inputRow, col));
                if (val != "nvt")
                {
                    yield return new OntvangstPositieOutput()
                    {
                        ToelaatbaarDag = sheet.GetDoubleValue(new(rowToelaatbaar, col)),
                        ToelaatbaarNacht = sheet.GetDoubleValue(new(rowToelaatbaar + 1, col)),
                    };
                }
            }
        }

        public static DagDeelOutput ReadDagdeel(this ISheetAdapter sheet, Situatie situatie, int col)
        {
            var row = situatie.ResultRow - 1;
            return new DagDeelOutput()
            {
                LwAMaxBerekend = sheet.GetDoubleValue(new CellRef(row - 15, col + 1)),
                LwATotaal = sheet.GetDoubleValue(new CellRef(row - 1, col + 1)),
                Voldoet = sheet.GetStringValue(new CellRef(row, col))?.ToLower() == "voldoet"
            };
        }






    }
}
