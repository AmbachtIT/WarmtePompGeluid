using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambacht.Common.Excel
{
    public enum ExcelTokenType
    {
        Function,
        CellReference,
        Number,
        String,
        Boolean,
        Operator,
        ParenthesisOpen,
        ParenthesisClose,
        Comma,
        EndOfFormula,
        Unknown
    }
}
