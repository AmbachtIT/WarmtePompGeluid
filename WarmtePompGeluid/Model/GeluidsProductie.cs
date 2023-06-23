using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class GeluidsProductie
    {

        public double LwAMax { get; init; }

        public double K1 { get; init; }

        public double DOmkasting { get; init; }

    }
}
