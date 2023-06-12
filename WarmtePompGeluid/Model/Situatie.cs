using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class Situatie
    {

        public string Name { get; init; }

        public string Description { get; init; }


        public static readonly Situatie AP = new Situatie()
        {
            Name = nameof(AP),
            Description = "Buitenunit bij/op appartementengebouw"
        };
        public static readonly Situatie Gg_1 = new Situatie()
        {
            Name = nameof(Gg_1),
            Description = "Buitenunit op maaiveld in tuin"
        };
        public static readonly Situatie Gg_2 = new Situatie()
        {
            Name = nameof(Gg_2),
            Description = "Buitenunit op aanbouw tegen woning"
        };
        public static readonly Situatie Gg_2A = new Situatie()
        {
            Name = nameof(Gg_2A),
            Description = "Buitenunit op tuinhuis achter in tuin"
        };
        public static readonly Situatie Gg_3 = new Situatie()
        {
            Name = nameof(Gg_3),
            Description = "Buitenunit op dak woning"
        };


        public static IEnumerable<Situatie> All()
        {
            yield return Gg_1;
            yield return Gg_2;
            yield return Gg_2A;
            yield return Gg_3;
            yield return AP;
        }

    }
}
