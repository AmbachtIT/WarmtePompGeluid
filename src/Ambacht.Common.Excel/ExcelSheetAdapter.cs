using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace Ambacht.Common.Excel
{
    public class ExcelSheetAdapter : ISheetAdapter
    {
        public ExcelSheetAdapter(IWorkbook workbook, ISheet sheet)
        {
            _sheet = sheet;
            _evaluator = new XSSFFormulaEvaluator(workbook);
        }

        private readonly ISheet _sheet;
        private readonly IFormulaEvaluator _evaluator;

        public void SetValue(CellRef addr, object value)
        {
            _sheet.SetValue(addr, value);
        }

        public object GetValue(CellRef cellRef)
        {
            var cell = _sheet.GetCell(cellRef);
            if (cell == null)
            {
                return null;
            }
            var value = _evaluator.Evaluate(cell);
            return value.CellType switch
            {
                CellType.Blank => null,
                CellType.Numeric => value.NumberValue,
                CellType.Boolean => value.BooleanValue,
                CellType.String => value.StringValue,
                _ => throw new NotImplementedException(),
            };
        }
        
    }
}
