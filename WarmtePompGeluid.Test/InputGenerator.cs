using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid.Test
{
    public class InputGenerator
    {

        public IEnumerable<Input> Generate() =>
                Apply(Generate_AP(), Situatie.AP);

        private IEnumerable<Input> Apply(IEnumerable<Input> inputs, Situatie situatie)
        {
            foreach (var input in inputs)
            {
                input.Situatie = situatie.Name;
                yield return input;
            }
        }

        private IEnumerable<Input> Generate_AP()
        {
            yield return SingleWindow(2);
            yield return SingleWindow(4);
            yield return SingleWindow(6);
        }

        private Input SingleWindow(float distance)
        {
            return new Input()
            {
                PlanGegevens = new PlanGegevens()
                {
                    Omschrijving = $"single-window-{distance}m"
                },
                DagProductie = new GeluidsProductie()
                {
                    LwAMax = 58
                },
                NachtProductie = new GeluidsProductie()
                {
                    LwAMax = 55
                },
                BronPositie = new Vector3(0, 0, 5),
                OntvangstPosities = new List<OntvangstPositie>()
                {
                    new OntvangstPositie()
                    {
                        Positie = new Vector3(distance, 0, 5), // 3m naar links
                        QGeluidsBron = 2,
                        QOntvanger = 2,
                        IsBuitenUnitAfgeschermd = false,
                        IsRaamDeurMetBalkon = true
                    }
                }
            };
        }

    }
}
