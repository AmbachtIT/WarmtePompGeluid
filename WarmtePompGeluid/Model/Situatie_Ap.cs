using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.Util;

namespace WarmtePompGeluid.Model
{
    public record class Situatie_Ap : Situatie
    {
        public override IEnumerable<CellReference> AllResultCells()
        {
            foreach (var address in base.AllResultCells())
            {
                yield return address;
            }

            foreach (var r in new[] { 40, 43, 44 })
            {
                for (var c = 2; c < 10; c++)
                {
                    yield return new CellReference(r, c);
                }
            }
        }
    }
}
