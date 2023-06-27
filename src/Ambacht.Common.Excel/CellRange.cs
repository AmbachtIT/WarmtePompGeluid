using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambacht.Common.Excel
{
    public record struct CellRange(CellRef From, CellRef To) : IEnumerable<CellRef>
    {
        public IEnumerator<CellRef> GetEnumerator()
        {
            var fromCol = Math.Min(From.Col, To.Col);
            var toCol = Math.Max(From.Col, To.Col);
            var fromRow = Math.Min(From.Row, To.Row);
            var toRow = Math.Max(From.Row, To.Row);
            for (var r = fromRow; r <= toRow; r++)
            {
                for (var c = fromCol; c <= toCol; c++)
                {
                    yield return new CellRef(r, c);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
