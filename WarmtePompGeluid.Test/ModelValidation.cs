using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Ambacht.Common;
using Ambacht.Common.Excel;
using Ambacht.Common.Serialization;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid.Test
{
    public class ModelValidation
    {

        [Test(), TestCaseSource(nameof(AllScenarios)), Explicit()]
        public async Task RunExcel(Input input)
        {
            await Serialize(input);
            var excelPath = Path.Combine(SourceRoot, "data", @"WPAC-geluid_V2020_0.xlsx");
            var workbook = await NPOIUtil.Read(excelPath);
            var calculator = Calculator.CreateExcel(workbook);

            var output = await calculator.Run(input);
            AddAdditionalInfo(output, calculator);

            await workbook.Write(GetOutputPath(input, "output", ".xlsx"));
            var json = _serializer.SerializeObject(output);
            await File.WriteAllTextAsync(GetOutputPath(input, "output", "-excel.json"), json);

        }

        private void AddAdditionalInfo(Output output, Calculator calculator)
        {
            output.AdditionalCells = new Dictionary<string, object>();
            foreach (var addr in new[] { "C35", "C36", "C37", "C38", "C39", "C40" })
            {
                output.AdditionalCells.Add(addr, calculator.SheetAdapter.GetValue(new CellRef(addr)));
            }
        }


        [Test(), TestCaseSource(nameof(AllScenarios)), Explicit()]
        public async Task RunCSharp(Input input)
        {
            await Serialize(input);
            var calculator = Calculator.CreateCSharp();

            var output = await calculator.Run(input);
            AddAdditionalInfo(output, calculator);

            var adapter = calculator.SheetAdapter;

            Console.Write(adapter.GetValue(new("B11")));
            Console.Write("-");
            Console.Write(adapter.GetValue(new("C20")));
            Console.WriteLine();

            Console.Write(adapter.GetValue(new("B11")));
            Console.Write("-");
            Console.Write(adapter.GetValue(new("C21")));
            Console.WriteLine();

            Console.Write(adapter.GetValue(new("B13")));
            Console.Write("-");
            Console.Write(adapter.GetValue(new("C22")));
            Console.WriteLine();


            Console.WriteLine(adapter.GetValue(new("C35")));

            var json = _serializer.SerializeObject(output);
            await File.WriteAllTextAsync(GetOutputPath(input, "output", "-csharp.json"), json);
        }




        private async Task Serialize(Input input)
        {
            var outputPath = GetOutputPath(input, "input", ".json");

            var json = _serializer.SerializeObject(input);
            await File.WriteAllTextAsync(outputPath, json);
        }



        private string GetOutputPath(Input input, string prefix, string suffix = "")
        {
            var situatie = Situatie.ByName(input.Situatie);
            var dir = Path.Combine(SourceRoot, "data", "validation", situatie.Name);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            var outputPath = Path.Combine(dir, $"{prefix}-{input.PlanGegevens.Omschrijving}{suffix}");
            return outputPath;
        }



        public static IEnumerable<Input> AllScenarios() => new InputGenerator().Generate();



        private readonly IJsonSerializer _serializer =
            new SystemTextJsonSerializer(SystemTextJsonDefaults.CreateDefault(true));

        public const string SourceRoot = @"C:\Projects\WarmtePompGeluid\main";

    }
}
