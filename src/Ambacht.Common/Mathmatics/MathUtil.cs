﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Ambacht.Common.Mathmatics
{
    public static class MathUtil
    {


        public static (T, T) GetExtremes<T>(this IEnumerable<T> items) where T : struct, IComparable<T>
        {
            T? min = null;
            T? max = null;
            foreach (var item in items)
            {
                if (min == null || min.Value.IsGreater(item))
                {
                    min = item;
                }
                if (max == null || max.Value.IsLess(item))
                {
                    max = item;
                }
            }
            return (min ?? default, max ?? default);
        }

        public static float NextMultiple(float value, float multiple)
        {
            return (float)(Math.Ceiling(value / multiple) * multiple);
        }

        public static float PreviousMultiple(float value, float multiple)
        {
            return (float)(Math.Floor(value / multiple) * multiple);
        }


        public static bool IsGreater<T>(this T value1, T value2) where T : IComparable<T>
        {
            return value1.CompareTo(value2) > 0;
        }

        public static bool IsGreaterOrEqual<T>(this T value1, T value2) where T : IComparable<T>
        {
            return value1.CompareTo(value2) >= 0;
        }

        /// <summary>
        /// Returns 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public static bool IsLess<T>(this T value1, T value2) where T : IComparable<T>
        {
            return value1.CompareTo(value2) < 0;
        }

        public static bool IsLessOrEqual<T>(this T value1, T value2) where T : IComparable<T>
        {
            return value1.CompareTo(value2) <= 0;
        }



        public static T Min<T>(this T item, T other) where T : IComparable<T>
        {
            if (item.IsLessOrEqual(other))
            {
                return item;
            }

            return other;
        }

        public static T Max<T>(this T item, T other) where T : IComparable<T>
        {
            if (item.IsGreaterOrEqual(other))
            {
                return item;
            }

            return other;
        }

        public static T Clamp<T>(this T item, T min, T max) where T : IComparable<T>
        {
            if (item.IsLessOrEqual(min))
            {
                return min;
            }
            if (item.IsGreaterOrEqual(max))
            {
                return max;
            }

            return item;
        }






        /// <summary>
        /// 
        /// </summary>
        /// <param name="function"></param>
        /// <param name="y"></param>
        /// <param name="xRange"></param>
        /// <param name="iterations"></param>
        /// <returns></returns>
        public static double? BinarySearch(Func<double, double> function, double y, Range<double> xRange, int iterations = 64)
        {
            var y1 = function(xRange.Min);
            var y2 = function(xRange.Max);
            var yRange = new Range<double>(y1, y2);
            if (!yRange.Contains(y))
            {
                return null;
            }


            var deltaX = xRange.Max - xRange.Min;
            if (deltaX <= double.Epsilon)
            {
                return xRange.Min;
            }

            var midpoint = xRange.Min + 0.5 * deltaX;
            if (iterations == 0)
            {
                return midpoint;
            }

            var range1 = new Range<double>(xRange.Min, midpoint);
            var range2 = new Range<double>(midpoint, xRange.Max);
            return BinarySearch(function, y, range1, iterations - 1) ?? BinarySearch(function, y, range2, iterations - 1);
        }



        public static double Variance(this IEnumerable<double> values)
        {
            var count = 0.0;
            var total = 0.0;
            foreach (var value in values)
            {
                count++;
                total += value;
            }

            if (count == 0)
            {
                return double.NaN;
            }

            var mean = total / count;
            var variance = 0.0;
            foreach (var value in values)
            {
                var deviation = value - mean;
                variance += deviation * deviation;
            }

            variance /= count;
            return variance;
        }

        public static double StandardDeviation(this IEnumerable<double> values)
        {
            return Math.Sqrt(values.Variance());
        }


        public static T Lerp<T>(T from, T to, T alpha) where T : IFloatingPoint<T>
        {
            return from + (to - from) * alpha;
        }

        /// <summary>
        /// Reverse linear interpolation
        /// </summary>
        public static T ReverseLerp<T>(T from, T to, T value) where T: IFloatingPoint<T>
        {
            if (to <= from)
            {
                to = from + T.One;
            }

            var delta = to - from;
            return (value - from) / delta;
        }



        public static float AngleLerpDegrees(float from, float to, float alpha)
        {
            var delta = from - to;
            if (delta < -180)
            {
                return AngleLerpDegrees(from + 360, to, alpha);
            }

            if (delta > 180)
            {
                return AngleLerpDegrees(from, to + 360, alpha);
            }

            return Lerp(from, to, alpha) % 360;
        }


        public static float AngleLerpRadians(float from, float to, float alpha)
        {
            var delta = from - to;
            if (delta < -Math.PI)
            {
                return AngleLerpRadians(from + 2 * (float)Math.PI, to, alpha);
            }

            if (delta > Math.PI)
            {
                return AngleLerpRadians(from, to + (float)Math.PI, alpha);
            }

            return (from + (to - from) * alpha) % (float)Math.PI;
        }
    }
}
