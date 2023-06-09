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

        [Cell(Name = "B2")]
        public string Omschrijving { get; set; }

        [Cell(Name = "B3")]
        public string Organisatie { get; set; }

        [Cell(Name = "B4")]
        public string Uitvoerder { get; set; }

    }
}
