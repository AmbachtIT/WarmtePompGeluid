using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.Util;

namespace WarmtePompGeluid.Model
{
    public record class ApSituatie : Situatie
    {
        public override IEnumerable<CellReference> AllResultCells()
        {
            foreach (var address in base.AllResultCells())
            {
                yield return address;
            }

            for (var r = 43; r <= 44; r++)
            {
                for (var c = 2; c < 10; c++)
                {
                    yield return new CellReference(r, c);
                }
            }
        }
    }
}
