using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class Output
    {


        public bool VoldoetDag { get; set; }

        public bool VoldoetNacht { get; set; }
        public bool Voldoet => VoldoetNacht && VoldoetDag;
    }
}
