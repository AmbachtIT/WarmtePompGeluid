﻿using System;
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
            sheet.WriteToSheet(input.PlanGegevens);
            sheet.WriteToSheet(input.BronPositie);
            sheet.WriteToSheet(input.DagProductie, input.Situatie, 2);
            sheet.WriteToSheet(input.NachtProductie, input.Situatie, 5);
            sheet.WriteToSheet(input.OntvangstPosities, input.Situatie);
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


        private static void WriteToSheet(this ISheetAdapter sheet, List<OntvangstPositie> posities, string model)
        {
            var row = GetOntvangstPositieInputRow(model);
            var count = GetExtraPositieCount(model);
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


        private static void WriteToSheet(this ISheetAdapter sheet, GeluidsProductie productie, string model, int column)
        {
            var reference = new CellRef(GetResultRow(model) - 4, column);
            sheet.SetValue(reference, productie.LwAMax);
            sheet.SetValue(reference = reference.Below(), productie.K1);
            sheet.SetValue(reference = reference.Below(), productie.DOmkasting);
        }



        public static Output ReadOutput(this ISheetAdapter sheet, string model)
        {
            return new Output()
            {
                Dag = sheet.ReadDagdeel(model, 1),
                Nacht = sheet.ReadDagdeel(model, 4),
                OntvangstPosities = sheet.ReadPosities(model).ToList()
            };
        }

        public static IEnumerable<OntvangstPositieOutput> ReadPosities(this ISheetAdapter sheet, string model)
        {
            var inputRow = GetOntvangstPositieInputRow(model);
            var count = GetExtraPositieCount(model);
            var rowToelaatbaar = GetOntvangstPositieToelaatbaarRow(model);
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

        public static DagDeelOutput ReadDagdeel(this ISheetAdapter sheet, string model, int col)
        {
            var row = GetResultRow(model);
            return new DagDeelOutput()
            {
                LwAMaxBerekend = sheet.GetDoubleValue(new CellRef(row - 15, col + 1)),
                LwATotaal = sheet.GetDoubleValue(new CellRef(row - 1, col + 1)),
                Voldoet = sheet.GetStringValue(new CellRef(row, col))?.ToLower() == "voldoet"
            };
        }

        private static int GetResultRow(string model) => model switch
        {
            "AP" => 69,
            "Gg_3" => 85,
            _ => 88
        };

        private static int GetOntvangstPositieInputRow(string model) => model switch
        {
            "AP" => 19,
            _ => -1
        };

        private static int GetOntvangstPositieToelaatbaarRow(string model) => model switch
        {
            "AP" => 43,
            _ => -1
        };


        private static int GetExtraPositieCount(string model) => model switch
        {
            "AP" => 8,
            _ => 0
        };


    }
}
