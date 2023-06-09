using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class GeluidsProductie
    {

        public double LwAMax { get; set; }

        public double K1 { get; set; }

        public double DOmkasting { get; set; }

        public double LwATotaal => LwAMax + K1 - DOmkasting;

    }
}
