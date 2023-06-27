using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using File = System.IO.File;

namespace Ambacht.Common.Excel
{
    public static class NPOIUtil
    {

        public static IWorkbook Read(Stream stream, string path)
        {
            var info = new FileInfo(path);
            return info.Extension.ToLower() switch
            {
                ".xlsx" => new XSSFWorkbook(stream),
                ".xls" => new HSSFWorkbook(stream),
                _ => throw new InvalidOperationException()
            };
        }

        public static async Task<IWorkbook> Read(string path)
        {
            await using var stream = File.OpenRead(path);
            return Read(stream, path);
        }


        public static async Task Write(this IWorkbook workbook, string path)
        {
            await using var stream = File.Create(path);
            workbook.Write(stream, false);
        }


        public static void SetValue(this ISheet sheet, CellRef reference, object value) =>
            sheet
                .GetOrCreateCell(reference)
                .SetValue(value);

        public static void SetValue(this ICell cell, object value)
        {
            if (value == null)
            {
                cell.SetBlank();
            }
            else if (value is string str)
            {
                cell.SetCellValue(str);
            }
            else if (value is double dbl)
            {
                cell.SetCellValue(dbl);
            }
            else if (value is float flt)
            {
                cell.SetCellValue(flt);
            }
            else if (value is int i)
            {
                cell.SetCellValue(i);
            }
            else
            {
                throw new NotImplementedException();
            }
        }



        public static ICell GetOrCreateCell(this ISheet sheet, CellRef reference) =>
            sheet.GetOrCreateRow(reference.Row)
                .GetOrCreateCell(reference.Col);

        public static IRow GetOrCreateRow(this ISheet sheet, int rowNr) =>
            sheet.GetRow(rowNr) ?? sheet.CreateRow(rowNr);

        public static ICell GetOrCreateCell(this IRow row, int colNr) =>
            row.GetCell(colNr) ?? row.CreateCell(colNr);


        public static ICell GetCell(this ISheet sheet, string reference) => sheet.GetCell(new CellRef(reference));

        public static ICell GetCell(this ISheet sheet, CellRef reference) =>
            sheet.GetRow(reference.Row)
                ?.GetCell(reference.Col);

    }
}
