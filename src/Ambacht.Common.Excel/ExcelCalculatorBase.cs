using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellRange = System.Tuple<System.Tuple<int, int>, System.Tuple<int, int>>;

namespace Ambacht.Common.Excel
{
    public abstract partial class ExcelCalculatorBase
    {

        protected ExcelCalculatorBase()
        {
            AddFormulas();
        }

        private void AddFormulas()
        {
            foreach (var kv in GetFormulas())
            {
                _formulas.Add(new CellRef(kv.Key), kv.Value);
            }
        }

        protected virtual IEnumerable<KeyValuePair<string, Func<object>>> GetFormulas()
        {
            yield break;
        }


        private readonly Dictionary<CellRef, Func<object>> _formulas = new Dictionary<CellRef, Func<object>>();
        private readonly Dictionary<CellRef, object> _values = new Dictionary<CellRef, object>();



        public object this[int row, int column]
        {
            get => this[new CellRef(row, column)];
            set => this[new CellRef(row, column)] = value;
        }


        public object this[CellRef addr]
        {
            get
            {
                if (_formulas.TryGetValue(addr, out var formula))
                {
                    var result = formula();
                    if (result is double dbl)
                    {
                        if (double.IsNaN(dbl))
                        {
                            throw new InvalidOperationException();
                        }
                    }
                    return result;
                }
                if (_values.TryGetValue(addr, out var value))
                {
                    return value;
                }
                return null;
            }
            set
            {
                if (value is float flt)
                {
                    _values[addr] = (double)flt;
                }
                else
                {
                    _values[addr] = value;
                }
            }
        }


        protected IEnumerable<double> AllValues(CellRange range)
        {
            foreach (var addr in range)
            {
                var value = this[addr];
                if (value is double v)
                {
                    yield return v;
                }
            }
        }



        protected double Negate(object value) => -GetDouble(value);

        protected object Plus(object value) => GetDouble(value);



        protected double Add(object v1, object v2) => GetDouble(v1) + GetDouble(v2);
        protected double Subtract(object v1, object v2) => GetDouble(v1) - GetDouble(v2);
        protected double Multiply(object v1, object v2) => GetDouble(v1) * GetDouble(v2);
        protected double Divide(object v1, object v2) => GetDouble(v1) / GetDouble(v2);

        protected double Pow(object v1, object v2) => Math.Pow(GetDouble(v1), GetDouble(v2));


        protected bool Less(object v1, object v2) => GetDouble(v1) < GetDouble(v2);
        protected bool LessOrEqual(object v1, object v2) => GetDouble(v1) <= GetDouble(v2);
        protected bool Greater(object v1, object v2) => GetDouble(v1) > GetDouble(v2);
        protected bool GreaterOrEqual(object v1, object v2) => GetDouble(v1) >= GetDouble(v2);


        private static double GetDouble(object value)
        {
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

            return 0;
        }

        private static T Get<T>(object value, T defaultValue = default) where T: struct
        {
            if (value is T t)
            {
                return t;
            }
            return defaultValue;
        }


        public static class Addresses
        {
            public static readonly (int, int) A1 = (0, 0);
        }

    }
}
