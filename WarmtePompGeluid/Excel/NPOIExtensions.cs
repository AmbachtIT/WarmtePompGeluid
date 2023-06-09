using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using File = System.IO.File;

namespace WarmtePompGeluid.Excel
{
    public static class NPOIExtensions
    {

        public static async Task Write(this IWorkbook workbook, string path)
        {
            await using var stream = File.Create(path);
            workbook.Write(stream, false);
        }


    }
}
