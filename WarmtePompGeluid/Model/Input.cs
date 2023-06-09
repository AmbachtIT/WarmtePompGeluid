using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class Input
    {

        public PlanGegevens PlanGegevens { get; init; } = new PlanGegevens();

    }
}
