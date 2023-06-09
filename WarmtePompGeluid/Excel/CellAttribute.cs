using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.Formula.Functions;
using NPOI.SS.Util;

namespace WarmtePompGeluid.Excel
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CellAttribute : Attribute
    {

        /// <summary>
        /// Name of the cell, this property is linked to, or the first cell of a row of the column in case this is an array.
        /// </summary>
        public string Name { get; set; } = "";

        public string RowName => string.Join("", Name.Where(c => char.IsDigit(c)));

        public string ColumnName => string.Join("", Name.Where(c => !char.IsDigit(c)));


        public int RowIndex => int.Parse(RowName) - 1;


        public int ColumnIndex => CellReference.ConvertColStringToIndex(ColumnName);


    }
}
