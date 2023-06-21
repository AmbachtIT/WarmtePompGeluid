using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.Util;

namespace Ambacht.Common.Excel
{
    public abstract record class ValueGenerator
    {

        public double NullProbability { get; set; }

        public object NullValue { get; set; }

        public object GenerateValue(Random random)
        {
            if (NullProbability > 0)
            {
                if (random.NextDouble() < NullProbability)
                {
                    return NullValue;
                }
            }

            return GenerateValueCore(random);
        }

        protected abstract object GenerateValueCore(Random random);

    }

    public record class ChoiceValueGenerator<T>(T[] Choices) : ValueGenerator
    {
        protected override object GenerateValueCore(Random random) => Choices[random.Next(0, Choices.Length)];
    }


    public record class RangeValueGenerator(double Min, double Max) : ValueGenerator
    {
        protected override object GenerateValueCore(Random random) => Min + random.NextDouble() * (Max - Min);
    }






}
