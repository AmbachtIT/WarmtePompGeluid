using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Ambacht.Common.Excel
{
    public record struct CellRef(int Row, int Col)
    {
        public CellRef(string address) : this(0, 0)
        {
            (Row, Col) = ParseAddress(address);
        }

        public string Sheet { get; init; }


        public static CellRef Parse(string address) => new CellRef(address);

        public static (int, int) ParseAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Excel address cannot be null or empty", nameof(address));
            }

            int i = 0;
            while (i < address.Length && char.IsLetter(address[i])) i++;

            string columnString = address.Substring(0, i);
            string rowString = address.Substring(i);

            int column = ConvertColumnNameToNumber(columnString);
            int row = int.Parse(rowString);

            return (row - 1, column - 1);
        }

        private static int ConvertColumnNameToNumber(string columnName)
        {
            int number = 0;
            int pow = 1;
            for (int i = columnName.Length - 1; i >= 0; i--)
            {
                number += (columnName[i] - 'A' + 1) * pow;
                pow *= 26;
            }

            return number;
        }



        public static string ConvertToAddress(int row, int col)
        {
            if (row < 1)
            {
                throw new ArgumentException("Row number must be positive", nameof(row));
            }

            if (col < 1)
            {
                throw new ArgumentException("Column number must be positive", nameof(col));
            }

            string columnString = ConvertColumnNumberToName(col);

            return columnString + row.ToString();
        }

        private static string ConvertColumnNumberToName(int columnNumber)
        {
            string columnName = string.Empty;
            while (columnNumber > 0)
            {
                int remainder = (columnNumber - 1) % 26;
                columnName = (char)(65 + remainder) + columnName;
                columnNumber = (columnNumber - remainder) / 26;
            }

            return columnName;
        }

        public override string ToString() => ConvertToAddress(Row + 1, Col + 1);
    }


    public static class CellRefExtensions
    {

        public static CellRef Below(this CellRef cellRef) => cellRef.Translate(1, 0);

        public static CellRef Translate(this CellRef addr, int deltaRows, int deltaColumns) => new CellRef(addr.Row + deltaRows, addr.Col + deltaColumns);
    }

}
