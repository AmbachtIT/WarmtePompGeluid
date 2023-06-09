using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class Installatie
    {

        public double MaximaalVermogen { get; set; }

        public double MaximaalBegrenstVermogen { get; set; }

        public string Merk { get; set; }

        public string Type { get; set; }

    }
}
