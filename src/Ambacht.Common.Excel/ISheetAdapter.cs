using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambacht.Common.Excel
{
    public interface ISheetAdapter
    {
        void SetValue(CellRef addr, object value);
        object GetValue(CellRef cellRef);
    }


    public static class SheetAdapterExtensions
    {
        public static double? GetDoubleValue(this ISheetAdapter adapter, CellRef cellRef)
        {
            var value = adapter.GetValue(cellRef);
            if (value is double dbl)
            {
                return dbl;
            }

            if (value is int i)
            {
                return i;
            }

            if (value is float f)
            {
                return f;
            }

            return null;
        }

        public static string GetStringValue(this ISheetAdapter adapter, CellRef cellRef)
        {
            var value = adapter.GetValue(cellRef);
            if (value is IFormattable f)
            {
                return f.ToString("", CultureInfo.InvariantCulture);
            }

            return value?.ToString();
        }
    }

}
