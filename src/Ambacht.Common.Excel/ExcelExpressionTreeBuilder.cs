﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace Ambacht.Common.Excel
{
    public class ExcelExpressionTreeBuilder
    {
        public ExcelExpressionTreeBuilder(IWorkbook workbook)
        {
            _workbook = workbook;
        }

        private readonly IWorkbook _workbook;


        public IEnumerable<Node> Calculate(IEnumerable<CellReference> references, ISheet sheet)
        {
            var list = new LinkedList<Node>(CalculateCore(references, sheet));
            var visited = new HashSet<string>();
            while (list.Any())
            {
                var next = list.FirstOrDefault(n => IsDeclared(n, visited));
                if (next == null)
                {
                    throw new InvalidOperationException("Circular reference detected");
                }

                visited.Add(next.CellName);
                list.Remove(next);
                yield return next;

            }
        }

        private bool IsDeclared(Node node, HashSet<string> visited)
        {
            return node.GetReferencedCells().All(c => visited.Contains(c));
        }


        private IEnumerable<Node> CalculateCore(IEnumerable<CellReference> references, ISheet sheet)
        {
            var visited = new HashSet<string>();
            var queue = new Queue<string>();
            foreach (var reference in references)
            {
                queue.Enqueue(reference.FormatAsString());
            }

            while (queue.TryDequeue(out var current))
            {
                visited.Add(current);

                var cell = sheet.GetCell(current);
                if (cell?.CellType == CellType.Formula)
                {
                    yield return Visit(cell, queue, visited);
                }
                else
                {
                    yield return new Node()
                    {
                        CellName = current,
                        CellType = cell?.CellType,
                        IsInput = true,
                        Description = $"variable ({cell?.CellType})"
                    };
                }
            }
        }

        private Node Visit(ICell cell, Queue<string> queue, HashSet<string> visited)
        {
            var result = new Node()
            {
                CellName = cell.Address.FormatAsString(),
                
            };
            (result.Tokens, result.Expression) = ExcelExpressionParser.ParseExpression(cell.CellFormula);

            var description = new StringBuilder();
            foreach (var token in result.Tokens)
            {
                if (token.Type == ExcelTokenType.CellReference)
                {
                    var name = token.Value?.Replace("$", "");
                    if (!string.IsNullOrEmpty(name))
                    {
                        if (visited.Add(name))
                        {
                            queue.Enqueue(name);
                        }
                    }
                    description.Append(name);
                }
                else
                {
                    description.Append(token.Value);
                }
            }
            result.Description = description.ToString();
            return result;
        }


        public class Node
        {

            public string CellName { get; set; }

            public ExcelAstNode Expression { get; set; }

            public List<ExcelToken> Tokens { get; set; } = new();

            public string Description { get; set; }

            public bool IsInput { get; set; }

            public CellType? CellType { get; set; }

            public override string ToString() => $"{CellName} = {Description}";

            public IEnumerable<string> GetReferencedCells() =>
                Tokens
                    .Where(t => t.Type == ExcelTokenType.CellReference)
                    .Select(t => t.Value.Replace("$", ""));

            
        }
    }
}
