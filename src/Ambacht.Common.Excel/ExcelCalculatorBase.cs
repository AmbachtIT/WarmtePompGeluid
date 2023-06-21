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

        private readonly Dictionary<(int, int), object> _values = new Dictionary<(int, int), object>();

        public object this[int row, int column]
        {
            get => this[(row, column)];
            set => this[(row, column)] = value;
        }


        public object this[(int, int) addr]
        {
            get
            {
                if (_values.TryGetValue(addr, out var result))
                {
                    return result;
                }
                return null;
            }
            set => _values[addr] = value;
        }




        protected IEnumerable<double> AllValues(((int, int), (int, int)) range)
        {
            var (from, to) = range;
            for (var r = from.Item1; r <= to.Item1; r++)
            {
                for (var c = from.Item2; c <= to.Item2; c++)
                {
                    var value = this[r, c];
                    if (value is double v)
                    {
                        yield return v;
                    }
                }
            }
        }



        protected double Negate(object value) => -Get<double>(value);

        protected object Plus(object value) => Get<double>(value);



        protected double Add(object v1, object v2) => Get<double>(v1) + Get<double>(v2);
        protected double Subtract(object v1, object v2) => Get<double>(v1) - Get<double>(v2);
        protected double Multiply(object v1, object v2) => Get<double>(v1) * Get<double>(v2);
        protected double Divide(object v1, object v2) => Get<double>(v1) / Get<double>(v2);

        protected double Pow(object v1, object v2) => Math.Pow(Get<double>(v1), Get<double>(v2));


        protected bool Less(object v1, object v2) => Get<double>(v1) < Get<double>(v2);
        protected bool LessOrEqual(object v1, object v2) => Get<double>(v1) <= Get<double>(v2);
        protected bool Greater(object v1, object v2) => Get<double>(v1) > Get<double>(v2);
        protected bool GreaterOrEqual(object v1, object v2) => Get<double>(v1) >= Get<double>(v2);

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
