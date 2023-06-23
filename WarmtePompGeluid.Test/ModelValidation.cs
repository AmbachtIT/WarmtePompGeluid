using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Ambacht.Common.Excel;
using Ambacht.Common.Serialization;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid.Test
{
    public class ModelValidation
    {

        [Test(), TestCaseSource(nameof(AllScenarios)), Explicit()]
        public async Task Serialize((int, Situatie, Input) args)
        {
            var (i, situatie, input) = args;
            var dir = Path.Combine(SourceRoot, "data", "validation", situatie.Name);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            var outputPath = Path.Combine(dir, $"input-{i}.json");

            var json = _serializer.SerializeObject(input);
            await File.WriteAllTextAsync(outputPath, json);
        }


        [Test(), TestCaseSource(nameof(AllScenarios)), Explicit()]
        public async Task RunExcel((int, Situatie, Input) args)
        {
            var (i, situatie, input) = args;
            var excelPath = Path.Combine(SourceRoot, "data", @"WPAC-geluid_V2020_0.xlsx");
            var workbook = await NPOIUtil.Read(excelPath);
            var calculator = new Calculator();

            var output = await calculator.Run(workbook, input);

            var dir = Path.Combine(SourceRoot, "data", "validation", situatie.Name);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            var outputPath = Path.Combine(dir, $"output-excel-{i}.json");

            var json = _serializer.SerializeObject(output);
            await File.WriteAllTextAsync(outputPath, json);

        }



        public static IEnumerable<(int, Situatie, Input)> AllScenarios()
        {
            foreach (var situatie in Situatie.All().Where(s => s.Name == "AP"))
            {
                for (var i = 0; i < 5; i++)
                {
                    var random = new Random(i);
                    var input = situatie.GenerateInput(random);
                    input.PlanGegevens.Omschrijving = i.ToString();
                    yield return (i, situatie, input);
                }
            }
        }



        private readonly IJsonSerializer _serializer =
            new SystemTextJsonSerializer(SystemTextJsonDefaults.CreateDefault(true));

        public const string SourceRoot = @"C:\Projects\WarmtePompGeluid\main";

    }
}
