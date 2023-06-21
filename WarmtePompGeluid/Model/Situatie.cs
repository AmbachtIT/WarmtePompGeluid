using System;
using System.Collections.Generic;
using System.Linq;
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
            ResultRow = 70
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
