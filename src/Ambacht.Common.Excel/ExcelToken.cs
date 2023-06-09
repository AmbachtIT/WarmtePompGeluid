﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambacht.Common.Excel
{

    public class ExcelToken
    {

        public ExcelTokenType Type { get; set; }
        public string Value { get; set; }


        public override string ToString() =>
            Type switch
            {
                ExcelTokenType.EndOfFormula => "",
                _ => Value
            };

        public bool IsOperator(string op)
        {
            return Type == ExcelTokenType.Operator && Value == op;
        }
    }
}
