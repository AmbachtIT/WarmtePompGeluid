using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambacht.Common.Excel;

namespace WarmtePompGeluid.Test.Excel
{
    public class TestCellRef
    {


        [Test(), TestCaseSource(nameof(AllTestCells))]
        public void RoundTripIsEqual(string cell)
        {
            var cellRef = CellRef.Parse(cell);
            Console.Write($"Col: {cellRef.Col}. Row: {cellRef.Row}");
            Assert.That(cellRef.ToString(), Is.EqualTo(cell));
        }


        public static IEnumerable<string> AllTestCells()
        {
            yield return "A1";
            yield return "A2";
            yield return "AB1";
            yield return "AB2";
            yield return "AZ2";
            yield return "B3";
            yield return "BA12";
        }

    }
}
