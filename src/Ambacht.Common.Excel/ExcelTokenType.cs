using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Excel
{
    public enum ExcelTokenType
    {
        Function,
        CellReference,
        Number,
        Operator,
        ParenthesisOpen,
        ParenthesisClose,
        Comma,
        EndOfFormula,
        Unknown
    }
}
