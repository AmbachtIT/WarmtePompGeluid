using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            yield return new CellReference(ResultRow - 1, 1);
            yield return new CellReference(ResultRow - 1, 4);
        }


        public static readonly Situatie AP = new ApSituatie()
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
            //ResultRow = 89
        };
        public static readonly Situatie Gg_2A = new Situatie()
        {
            Name = nameof(Gg_2A),
            Description = "Buitenunit op tuinhuis achter in tuin",
            //ResultRow = 89

        };
        public static readonly Situatie Gg_3 = new Situatie()
        {
            Name = nameof(Gg_3),
            Description = "Buitenunit op dak woning",
            //ResultRow = 86
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
