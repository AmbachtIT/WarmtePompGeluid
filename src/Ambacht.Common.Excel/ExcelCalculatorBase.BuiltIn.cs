using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambacht.Common.Excel
{
    public partial class ExcelCalculatorBase
    {



        protected object IF(bool condition, object resultTrue, object resultFalse) => condition ? resultTrue : resultFalse;

        protected bool AND(object v1, object v2) => Get<bool>(v1) && Get<bool>(v2);


        protected double ROUND(object value, object decimals) => Math.Round(Get<double>(value), Get<int>(decimals));
        protected double LOG10(object value) => Math.Log10(Get<double>(value));

        protected double SQRT(object value) => Math.Sqrt(Get<double>(value));

        protected double PI() => Math.PI;


        protected double? MAX(object v1, object v2)
        {
            if (v1 is double d1)
            {
                if (v2 is double d2)
                {
                    return Math.Max(d1, d2);
                }

                return d1;
            }

            if (v2 is double dv2)
            {
                return dv2;
            }

            return null;
        }

        protected double MAX(((int, int), (int, int)) range)
        {
            double? result = null;
            foreach (var v in AllValues(range))
            {
                if (result == null || v > result)
                {
                    result = v;
                }
            }

            return result ?? 0.0;
        }

        protected double? MIN(object v1, object v2)
        {
            if (v1 is double d1)
            {
                if (v2 is double d2)
                {
                    return Math.Min(d1, d2);
                }

                return d1;
            }

            if (v2 is double dv2)
            {
                return dv2;
            }

            return null;
        }

        protected double MIN(((int, int), (int, int)) range)
        {
            double? result = null;
            foreach (var v in AllValues(range))
            {
                if (result == null || v < result)
                {
                    result = v;
                }
            }

            return result ?? 0.0;
        }


        protected double SUM(((int, int), (int, int)) range)
        {
            double? result = null;
            foreach (var v in AllValues(range))
            {
                if (result == null)
                {
                    result = v;
                }
                else
                {
                    result += v;
                }
            }

            return result ?? 0.0;
        }

    }
}
