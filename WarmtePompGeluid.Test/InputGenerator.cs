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
            yield return Base_AP() with
            {
                PlanGegevens = new PlanGegevens()
                {
                    Omschrijving = "ok",
                }
            };
        }

        private Input Base_AP()
        {
            return new Input()
            {
                BronPositie = new Vector3(0, 0, 5),
                OntvangstPosities = new List<OntvangstPositie>()
                {
                    new OntvangstPositie()
                    {
                        Positie = new Vector3(-3, 0, 5), // 5m naar links
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
