using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class Perceel
    {

        public double Breedte { get; set; }

        public double Diepte { get; set; }

        public bool LinksWoonBestemming { get; set; }
        public bool RechtsWoonBestemming { get; set; }
        public bool BovenWoonbestemming { get; set; }

    }
}
