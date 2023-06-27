using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class Input
    {

        public string Situatie { get; set; } = "AP";

        public PlanGegevens PlanGegevens { get; init; } = new PlanGegevens();


        public Vector3 BronPositie { get; set; } = Vector3.Zero;

        public List<OntvangstPositie> OntvangstPosities { get; set; } = new List<OntvangstPositie>();

        public Perceel Perceel { get; set; } = new Perceel();

        public Gevel Gevel { get; set; } = new Gevel();

        public Installatie Installatie { get; set; } = new Installatie();

        public GeluidsProductie DagProductie { get; set; } = new GeluidsProductie();

        public GeluidsProductie NachtProductie { get; set; } = new GeluidsProductie();


    }
}
