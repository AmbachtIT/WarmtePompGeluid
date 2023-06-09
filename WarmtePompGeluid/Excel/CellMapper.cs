using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.UserModel;

namespace WarmtePompGeluid.Excel
{
    public static class CellMapper
    {

        public static T MapSheetToObject<T>(this ISheet sheet) => (T)sheet.MapSheetToObject(typeof(T));

        public static object MapSheetToObject(this ISheet sheet, Type type)
        {
            var result = type.GetConstructor(Type.EmptyTypes).Invoke(null);
            foreach (var prop in type.GetProperties())
            {
                var value =
                    prop.PropertyType.IsClass && prop.PropertyType != typeof(string)
                        ? GetClassValue(sheet, prop)
                        : GetStructValue(sheet, prop);
                if (value != null)
                {
                    prop.SetValue(result, value);
                }

            }

            return result;
        }


        public static void MapObjectToSheet<T>(this ISheet sheet, T obj) => sheet.MapObjectToSheet(typeof(T), obj);

        public static void MapObjectToSheet(this ISheet sheet, Type type, object obj)
        {
            foreach (var prop in type.GetProperties())
            {
                if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
                {
                    SetClassValue(sheet, prop, obj);
                }
                else
                {
                    SetStructValue(sheet, prop, obj);
                }
            }
        }


        private static void SetStructValue(ISheet sheet, PropertyInfo prop, object obj)
        {
            var attr = prop.GetCustomAttributes<CellAttribute>().SingleOrDefault();
            var cell = GetCell(sheet, attr);
            if (cell == null)
            {
                return;
            }

            var value = prop.GetValue(obj, null);
            if (value == null)
            {
                cell.SetBlank();
            }
            else
            {
                if (prop.PropertyType == typeof(string))
                {
                    cell.SetCellValue(value?.ToString());
                }
                else if (prop.PropertyType == typeof(double))
                {
                    cell.SetCellValue((double)value);
                }
                else throw new InvalidOperationException("Unexpected property value: " + prop.PropertyType);
            }

        }

        private static object GetStructValue(ISheet sheet, PropertyInfo prop)
        {
            var attr = prop.GetCustomAttributes<CellAttribute>().SingleOrDefault();
            var cell = GetCell(sheet, attr);
            if (cell == null)
            {
                return null;
            }

            if (prop.PropertyType == typeof(string))
            {
                return cell.StringCellValue;
            }
            if (prop.PropertyType == typeof(double))
            {
                return cell.NumericCellValue;
            }

            throw new InvalidOperationException("Unexpected property value: " + prop.PropertyType);
        }

        private static void SetClassValue(ISheet sheet, PropertyInfo prop, object obj)
        {
            var value = prop.GetValue(obj, null);
            if (value == null)
            {
                return;
            }
            MapObjectToSheet(sheet, prop.PropertyType, value);
        }


        private static object GetClassValue(ISheet sheet, PropertyInfo prop)
        {
            return MapSheetToObject(sheet, prop.PropertyType);
        }

        private static ICell GetCell(ISheet sheet, CellAttribute attr)
        {
            if (attr == null)
            {
                return null;
            }
            var row = sheet.GetRow(attr.RowIndex);
            return row?.GetCell(attr.ColumnIndex);
        }

    }
}
