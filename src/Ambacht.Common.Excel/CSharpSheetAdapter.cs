using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ambacht.Common.Excel
{
    public class CSharpSheetAdapter : ISheetAdapter
    {

        public CSharpSheetAdapter(ExcelCalculatorBase calculator)
        {
            _calculator = calculator;
            _calculatorType = calculator.GetType();
        }

        private readonly ExcelCalculatorBase _calculator;
        private readonly Type _calculatorType;
        private readonly Dictionary<string, PropertyInfo> _props = new Dictionary<string, PropertyInfo>();

        public void SetValue(CellRef addr, object value)
        {
            _calculator[addr] = value;
        }

        public object GetValue(CellRef cellRef) => GetOrCalculateValue(cellRef);


        private object GetOrCalculateValue(CellRef addr)
        {
            var name = addr.ToString();
            if (!_props.TryGetValue(name, out var prop))
            {
                _props.Add(name, prop = _calculatorType.GetProperty(name));
            }

            if (prop == null)
            {
                return _calculator[addr];
            }

            return prop.GetValue(_calculator);
        }
    }
}
