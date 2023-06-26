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
        public async Task Serialize(Input input)
        {
            var outputPath = GetOutputPath(input, "input");

            var json = _serializer.SerializeObject(input);
            await File.WriteAllTextAsync(outputPath, json);
        }


        [Test(), TestCaseSource(nameof(AllScenarios)), Explicit()]
        public async Task RunExcel(Input input)
        {
            var excelPath = Path.Combine(SourceRoot, "data", @"WPAC-geluid_V2020_0.xlsx");
            var workbook = await NPOIUtil.Read(excelPath);
            var calculator = new Calculator();

            var output = await calculator.Run(workbook, input);

            var outputPath = GetOutputPath(input, "output", "-excel");


            var json = _serializer.SerializeObject(output);
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
            var outputPath = Path.Combine(dir, $"{prefix}-{input.PlanGegevens.Omschrijving}{suffix}.json");
            return outputPath;
        }



        public static IEnumerable<Input> AllScenarios() => new InputGenerator().Generate();



        private readonly IJsonSerializer _serializer =
            new SystemTextJsonSerializer(SystemTextJsonDefaults.CreateDefault(true));

        public const string SourceRoot = @"C:\Projects\WarmtePompGeluid\main";

    }
}
