using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class Output
    {

        public List<OntvangstPositieOutput> OntvangstPosities { get; set; } = new List<OntvangstPositieOutput>();

        public DagDeelOutput Dag { get; set; } = new DagDeelOutput();

        public DagDeelOutput Nacht { get; set; } = new DagDeelOutput();

        public bool Voldoet => Dag.Voldoet && Nacht.Voldoet;

        public Dictionary<string, object> AdditionalCells { get; set; }

    }
}
