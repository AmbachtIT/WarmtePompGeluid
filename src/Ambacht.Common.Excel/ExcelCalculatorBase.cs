using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambacht.Common.Excel
{
    public abstract class ExcelCalculatorBase
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


        protected object IF(bool condition, object resultTrue, object resultFalse) => condition ? resultTrue : resultFalse;

        public static class Addresses
        {
            public static readonly (int, int) A1 = (0, 0);
        }

    }
}
