﻿using MudBlazor.Extensions;
using NPOI.SS.UserModel;
using WarmtePompGeluid.Excel;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid.Wasm.Services
{
    public class CalculatorService
    {

        private readonly HttpClient _httpClient;

        public CalculatorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Output> Calculate(Input input)
        {
            Console.WriteLine("Creating workbook");
            var workbook = await CreateWorkbook();
            Console.WriteLine("Workbook has been created");
            var output = await new Calculator().Run(workbook, input);
            Console.WriteLine("Done");
            return output;
        }

        private async Task<IWorkbook> CreateWorkbook()
        {
            var bytes = await _httpClient.GetByteArrayAsync($"data/{Filename}");
            using var ms = new MemoryStream(bytes);
            return NPOIUtil.Read(ms, Filename);
        }


        public const string Filename = "WPAC-geluid_V2020_0.xlsx";

    }
}
