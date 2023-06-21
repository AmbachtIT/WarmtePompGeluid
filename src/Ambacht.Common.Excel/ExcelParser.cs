using NPOI.POIFS.FileSystem;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambacht.Common.Excel
{
    public class ExcelExpressionParser
    {
        private readonly List<ExcelToken> _tokens;
        private int _index = 0;

        public ExcelExpressionParser(List<ExcelToken> tokens)
        {
            _tokens = tokens;
        }

        public ExcelAstNode Parse()
        {
            return ParseExpression();
        }

        private ExcelAstNode ParseExpression(int precedence = 0)
        {
            ExcelAstNode left;

            // handle unary operators
            var ahead = LookAhead();
            if (ahead.Type == ExcelTokenType.Operator && ahead.Value == "-")
            {
                Consume(ExcelTokenType.Operator);
                left = new ExcelUnaryOperatorNode(ahead.Value, ParseExpression(30));
            }
            else
            {
                left = ParsePrimary();
            }

            while (true)
            {
                var op = LookAhead();
                if (op.Type != ExcelTokenType.Operator || !PrecedenceTable.TryGetValue((string)op.Value, out var opInfo) ||
                    opInfo.precedence < precedence)
                    break;

                Consume(ExcelTokenType.Operator);

                var right = ParseExpression(opInfo.rightAssociative ? opInfo.precedence : opInfo.precedence + 1);

                left = new ExcelOperatorNode(op.Value, left, right);
            }

            return left;
        }

        private ExcelAstNode ParsePrimary()
        {
            var token = Consume();

            switch (token.Type)
            {
                case ExcelTokenType.ParenthesisOpen:
                    var result = ParseExpression();
                    Consume(ExcelTokenType.ParenthesisClose);
                    return new ExcelParenthesesNode(result);

                case ExcelTokenType.Number:
                    return new ExcelConstantNode<double>(double.Parse(token.Value));
                case ExcelTokenType.String:
                    return new ExcelConstantNode<string>(token.Value);
                case ExcelTokenType.Boolean:
                    return new ExcelConstantNode<bool>(bool.Parse(token.Value));
                case ExcelTokenType.CellReference:
                    return new ExcelVariableNode(token.Value);
                case ExcelTokenType.Function:
                    Consume(ExcelTokenType.ParenthesisOpen);
                    List<ExcelAstNode> args = new List<ExcelAstNode>();
                    if (LookAhead().Type != ExcelTokenType.ParenthesisClose)
                    {
                        do
                        {
                            args.Add(ParseExpression());
                        } while (LookAhead().Type == ExcelTokenType.Comma && Consume().Type == ExcelTokenType.Comma);
                    }
                    Consume(ExcelTokenType.ParenthesisClose);
                    return new ExcelFunctionNode(token.Value, args);
                default:
                    throw new Exception($"Unexpected token {token.Type}");
            }
        }

        private ExcelToken Consume(ExcelTokenType? expectedType = null)
        {
            ExcelToken token = _tokens[_index++];
            if (expectedType != null && token.Type != expectedType)
                throw new Exception($"Expected token {expectedType} but got {token.Type}");
            return token;
        }

        private ExcelToken LookAhead()
        {
            return _index < _tokens.Count ? _tokens[_index] : new ExcelToken { Type = ExcelTokenType.EndOfFormula };
        }


        private static readonly Dictionary<string, (int precedence, bool rightAssociative)> PrecedenceTable =
            new()
            {
                { "=", (5, false) },
                { "<>", (5, false) },
                { "<", (5, false) },
                { "<=", (5, false) },
                { ">", (5, false) },
                { ">=", (5, false) },

                { "^", (8, false) },


                { "+", (10, false) },
                { "-", (10, false) },
                { "*", (20, false) },
                { "/", (20, false) },

                { ":", (100, false) }
                // other operators...
            };


        public static (List<ExcelToken>, ExcelAstNode) ParseExpression(string expression)
        {
            List<ExcelToken> tokens;
            try
            {
                tokens = ExcelLexer.Tokenize(expression);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error lexing Excel expression {expression}: {ex.Message}");
            }

            try
            {
                var node = new ExcelExpressionParser(tokens).Parse();
                return (tokens, node);
            }
            catch (Exception ex)
            {
                var builder = new StringBuilder();
                builder.AppendLine($"Error parsing Excel expression {expression}: {ex.Message}");
                builder.AppendLine();
                builder.AppendLine("TOKENS:");
                foreach (var token in tokens)
                {
                    builder.AppendLine($" - {token.Type}: {token.Value}");
                }

                throw new InvalidOperationException(builder.ToString());
            }


        }

    }
}
