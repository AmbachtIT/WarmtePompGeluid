using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class Output
    {

        public string Model { get; set; } = "AP";

        public PlanGegevens PlanGegevens { get; init; } = new PlanGegevens();


    }
}
