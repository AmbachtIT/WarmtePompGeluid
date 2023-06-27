using System.Diagnostics;
using Ambacht.Common.Excel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using WarmtePompGeluid.Excel;
using WarmtePompGeluid.Model;

namespace WarmtePompGeluid
{
    public abstract class Calculator
    {

        public ISheetAdapter SheetAdapter { get; internal set; }

        public static Calculator CreateExcel(IWorkbook workbook = null) => new ExcelCalculator(workbook);

        public static Calculator CreateCSharp() => new CSharpCalculator();


        public abstract Task<Output> Run(Input input, CancellationToken token = default);

        
    }

}