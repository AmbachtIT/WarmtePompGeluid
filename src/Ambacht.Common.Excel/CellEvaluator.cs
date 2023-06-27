using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambacht.Common.Excel;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;

namespace WarmtePompGeluid.Excel
{
    public class CellEvaluator
    {

        public CellEvaluator(IWorkbook workbook)
        {
            _evaluator = workbook.GetCreationHelper().CreateFormulaEvaluator();
        }

        private readonly IFormulaEvaluator _evaluator;


        public string GetStringValue(ISheet sheet, CellRef reference) =>
            GetStringValue(sheet.GetCell(reference));

        public string GetStringValue(ICell cell) => GetValue(cell)?.ToString();


        public double? GetDoubleValue(ISheet sheet, CellRef reference) => GetDoubleValue(sheet.GetCell(reference));


        public double? GetDoubleValue(ICell cell) => (double?)GetValue(cell);


        public object GetValue(ICell cell)
        {
            if (cell == null)
            {
                return null;
            }

            var value = _evaluator.Evaluate(cell);
            return value?.CellType switch
            {
                null => null,
                CellType.Blank => null,
                CellType.String => value.StringValue,
                CellType.Boolean => value.BooleanValue,
                CellType.Numeric => value.NumberValue,
                CellType.Error => null,
                CellType.Formula => throw new NotImplementedException(),
                CellType.Unknown => "UNKNOWN",
                _ => throw new InvalidOperationException()
            };
        }

        public void EvaluateAll()
        {
            _evaluator.EvaluateAll();
        }

    }
}
