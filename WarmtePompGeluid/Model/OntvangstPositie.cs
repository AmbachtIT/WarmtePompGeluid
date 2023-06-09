using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Model
{
    public record class OntvangstPositie
    {

        public Vector3 Positie { get; set; } = Vector3.Zero;

        public bool IsBuitenUnitAfgeschermd { get; set; }

        public bool IsRaamDeurMetBalkon { get; set; }

        public double QGeluidsBron { get; set; }

        public double QOntvanger { get; set; }

    }
}
