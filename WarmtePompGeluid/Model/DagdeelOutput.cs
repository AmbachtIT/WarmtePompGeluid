using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class DagDeelOutput
    {

        public double LwABerekend { get; set; }

        public double LwATotaal { get; set; }

        public bool Voldoet { get; set; }

    }
}
