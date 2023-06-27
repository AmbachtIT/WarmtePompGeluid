using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambacht.Common.Excel;
using NPOI.SS.UserModel;
using WarmtePompGeluid.Excel;
using WarmtePompGeluid.Model;
using WarmtePompGeluid.Model.Generated;

namespace WarmtePompGeluid
{
    public class CSharpCalculator : Calculator
    {
        public override async Task<Output> Run(Input input, CancellationToken token = default)
        {
            await Task.CompletedTask;
            var calculator = GetCalculator(input);

            SheetAdapter = new CSharpSheetAdapter(calculator);
            SheetAdapter.WriteToSheet(input);

            var output = SheetAdapter.ReadOutput(input.Situatie);
            await Task.CompletedTask;
            return output;
        }

        private ExcelCalculatorBase GetCalculator(Input input)
        {
            return input.Situatie switch
            {
                "AP" => new Calculator_AP(),
                "Gg_1" => new Calculator_Gg_1(),
                "Gg_2" => new Calculator_Gg_2(),
                "Gg_2A" => new Calculator_Gg_2A(),
                "Gg_3" => new Calculator_Gg_3(),
                _ => throw new NotImplementedException()
            };
        }

    }
}
