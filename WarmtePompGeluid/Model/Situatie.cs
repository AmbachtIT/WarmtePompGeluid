using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Ambacht.Common.Excel;
using NPOI.SS.Util;

namespace WarmtePompGeluid.Model
{
    public record class Situatie
    {

        public string Name { get; init; }

        public string Description { get; init; }

        /// <summary>
        /// Row containing result (voldoet/voldoet niet), 1-based
        /// </summary>
        public int ResultRow { get; init; }

        /// <summary>
        /// First row of ontvangstpositie columns (will contain x if position is used, 'nvt' if it is not), 1-based
        /// </summary>
        public int OntvangstPositieInputRow { get; init; }

        /// <summary>
        /// Maximum number of ontvangstposities
        /// </summary>
        public int OntvangstPositieCount { get; init; }


        /// <summary>
        /// Row of containing day and night values of maximum allowed level, 1-based
        /// </summary>
        public int OntvangstPositieToelaatbaarRow { get; init; }


        public virtual Input GenerateInput(Random random)
        {
            var result = new Input()
            {
                DagProductie = GenerateProductie(random),
            };
            result.NachtProductie = result.DagProductie with { LwAMax = result.DagProductie.LwAMax - random.Next(0, 6) };
            return result;
        }



        protected double GenerateQ(Random random)
        {
            var q = random.NextDouble();
            if (q < 0.5)
            {
                return 2;
            }

            if (q < 0.75)
            {
                return 1;
            }

            return 0.5;
        }


        protected Vector3 GenerateVector(Random random)
        {
            return new Vector3(
                (float)(random.NextDouble() * 2 - 1),
                (float)(random.NextDouble() * 2 - 1),
                (float)(random.NextDouble() * 2 - 1)
            );
        }
        private GeluidsProductie GenerateProductie(Random random) => new GeluidsProductie()
        {
            LwAMax = random.Next(45, 65),
            DOmkasting = random.Next(0, 3),
            K1 = random.Next(0, 3)
        };


        public virtual IEnumerable<CellReference> AllResultCells()
        {
            if (ResultRow == 0)
            {
                yield break;
            }

            foreach (var col in new[] { 1, 4 })
            {
                yield return new CellReference(ResultRow - 15 - 1, col + 1);
                yield return new CellReference(ResultRow - 1 - 1, col + 1);
                yield return new CellReference(ResultRow - 1, col);
            }
        }


        public virtual IEnumerable<(CellReference, ValueGenerator)> AllInputCells()
        {
            if (ResultRow == 0)
            {
                yield break;
            }


            foreach (var col in new[] { 2, 5 })
            {
                yield return (new CellReference(ResultRow - 4 - 1, col), new RangeValueGenerator(10, 100));
                yield return (new CellReference(ResultRow - 3 - 1, col), new RangeValueGenerator(0, 3));
                yield return (new CellReference(ResultRow - 2 - 1, col), new RangeValueGenerator(0, 3));
            }
        }


        public static readonly Situatie AP = new Situatie_Ap()
        {
            Name = nameof(AP),
            Description = "Buitenunit bij/op appartementengebouw",
            ResultRow = 70,
            OntvangstPositieInputRow = 20,
            OntvangstPositieCount = 8,
            OntvangstPositieToelaatbaarRow = 44
        };
        public static readonly Situatie Gg_1 = new Situatie()
        {
            Name = nameof(Gg_1),
            Description = "Buitenunit op maaiveld in tuin",
            ResultRow = 89
        };
        public static readonly Situatie Gg_2 = new Situatie()
        {
            Name = nameof(Gg_2),
            Description = "Buitenunit op aanbouw tegen woning",
            ResultRow = 89
        };
        public static readonly Situatie Gg_2A = new Situatie()
        {
            Name = nameof(Gg_2A),
            Description = "Buitenunit op tuinhuis achter in tuin",
            ResultRow = 89

        };
        public static readonly Situatie Gg_3 = new Situatie()
        {
            Name = nameof(Gg_3),
            Description = "Buitenunit op dak woning",
            ResultRow = 86
        };



        public static IEnumerable<Situatie> All()
        {
            yield return Gg_1;
            yield return Gg_2;
            yield return Gg_2A;
            yield return Gg_3;
            yield return AP;
        }

        public static Situatie ByName(string name) => All().SingleOrDefault(s => s.Name == name);


    }
}
