using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarmtePompGeluid.Excel;

namespace WarmtePompGeluid.Model
{
    public record class PlanGegevens
    {
        public string Omschrijving { get; set; }

        public string Organisatie { get; set; }

        public string Uitvoerder { get; set; }

    }
}
