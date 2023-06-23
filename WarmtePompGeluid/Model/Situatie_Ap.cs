using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Random;
using NPOI.SS.Util;


namespace WarmtePompGeluid.Model
{
    public record class Situatie_Ap : Situatie
    {
        public override Input GenerateInput(Random random)
        {
            var result = base.GenerateInput(random);

            result.OntvangstPosities =
                Enumerable
                    .Range(0, random.Next(0, 8))
                    .Select(_ => GenerateOntvangstPositie(random))
                    .ToList();

            return result;
        }

        protected OntvangstPositie GenerateOntvangstPositie(Random random)
        {
            var result = new OntvangstPositie()
            {
                Positie = GenerateVector(random) * 10,
                IsBuitenUnitAfgeschermd = random.NextDouble() < 0.1,
                IsRaamDeurMetBalkon = random.NextDouble() < 0.1,
                QGeluidsBron = GenerateQ(random),
                QOntvanger = GenerateQ(random)
            };
            if (result.Positie.Y < 0)
            {
                result.Positie = result.Positie with { Y = 0 };
            }
            return result;
        }


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
