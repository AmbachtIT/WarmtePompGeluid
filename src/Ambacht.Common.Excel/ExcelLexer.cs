using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WarmtePompGeluid.Excel
{
    public class ExcelLexer
    {
        private static readonly Regex NumberRegex = new Regex(@"^\d+(.\d+)?", RegexOptions.Compiled);
        private static readonly Regex CellReferenceRegex = new Regex(@"^(\$?[A-Za-z]+\$?\d+)", RegexOptions.Compiled);
        private static readonly Regex FunctionRegex = new Regex(@"^[A-Za-z]+(?=\()", RegexOptions.Compiled);
        private static readonly Regex OperatorRegex = new Regex(@"^(<=|>=|<>|<|>|=|\+|-|\*|/)", RegexOptions.Compiled);

        public static List<ExcelToken> Tokenize(string formula)
        {
            var tokens = new List<ExcelToken>();
            var formulaSpan = formula.AsSpan();

            while (formulaSpan.Length > 0)
            {
                if (formulaSpan[0] == '(')
                {
                    tokens.Add(new ExcelToken { Type = ExcelTokenType.ParenthesisOpen, Value = "(" });
                    formulaSpan = formulaSpan.Slice(1).TrimStart();
                }
                else if (formulaSpan[0] == ')')
                {
                    tokens.Add(new ExcelToken { Type = ExcelTokenType.ParenthesisClose, Value = ")" });
                    formulaSpan = formulaSpan.Slice(1).TrimStart();
                }
                else if (formulaSpan[0] == ',')
                {
                    tokens.Add(new ExcelToken { Type = ExcelTokenType.Comma, Value = "," });
                    formulaSpan = formulaSpan.Slice(1).TrimStart();
                }
                else
                {
                    var formulaString = formulaSpan.ToString();
                    Match match;

                    if ((match = OperatorRegex.Match(formulaString)).Success)
                    {
                        tokens.Add(new ExcelToken { Type = ExcelTokenType.Operator, Value = match.Value });
                        formulaSpan = formulaSpan.Slice(match.Length).TrimStart();
                    }
                    else if ((match = NumberRegex.Match(formulaString)).Success)
                    {
                        tokens.Add(new ExcelToken { Type = ExcelTokenType.Number, Value = match.Value });
                        formulaSpan = formulaSpan.Slice(match.Length).TrimStart();
                    }
                    else if ((match = CellReferenceRegex.Match(formulaString)).Success && !IsFunction(match.Value))
                    {
                        tokens.Add(new ExcelToken { Type = ExcelTokenType.CellReference, Value = match.Value });
                        formulaSpan = formulaSpan.Slice(match.Length).TrimStart();
                    }
                    else if ((match = FunctionRegex.Match(formulaString)).Success)
                    {
                        tokens.Add(new ExcelToken { Type = ExcelTokenType.Function, Value = match.Value });
                        formulaSpan = formulaSpan.Slice(match.Length).TrimStart();
                    }
                    else
                    {
                        tokens.Add(new ExcelToken { Type = ExcelTokenType.Unknown, Value = formulaSpan[0].ToString() });
                        formulaSpan = formulaSpan.Slice(1).TrimStart();
                    }
                }
            }

            tokens.Add(new ExcelToken { Type = ExcelTokenType.EndOfFormula, Value = string.Empty });

            return tokens;
        }

        private static bool IsFunction(string name)
        {
            return name switch
            {
                "LOG10" => true,
                _ => false
            };
        }


        

    }
}
