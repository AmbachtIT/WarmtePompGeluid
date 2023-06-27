using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class DagDeelOutput
    {

        /// <summary>
        /// Maximaal geluid dat de bron zou mogen produceren
        /// </summary>
        public double? LwAMaxBerekend { get; set; }

        /// <summary>
        /// Maximaal geluid dat de bron daadwerkelijk produceert
        /// </summary>
        public double? LwATotaal { get; set; }

        public bool Voldoet { get; set; }

    }
}
