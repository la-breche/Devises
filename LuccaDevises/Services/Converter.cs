using Graphalo;
using Graphalo.Traversal;
using LuccaDevises.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LuccaDevises.Services
{
    public class Converter
    {

        public int Convert(List<string> lines)
        {
            var firstLine = lines.First();
            var secondLine = lines.Skip(1).First();
            var othersLines = lines.Skip(2).ToList();

            var graph = this.SetGraph(othersLines);
            var splitedRequest = firstLine.Split(';');
            var start = splitedRequest[0];
            var initialAmount = int.Parse(splitedRequest[1]);
            var target = splitedRequest[2];
            var rates = GetRates(othersLines);
            var result = graph.Traverse(TraversalKind.Dijkstra, start, target);
            if (result.Success)
            {
                string previous = null;
                decimal amout = initialAmount;
                foreach (var path in result.Results)
                {
                    if (previous == null)
                    {
                        previous = path;
                        continue;
                    }

                    RateConv conv = rates.FirstOrDefault(r => r.Source == previous && r.Target == path);
                    if (conv == null)
                    {
                        conv = rates.FirstOrDefault(r => r.Source == path && r.Target == previous);
                        if (conv == null)
                        {
                            return 0;
                        }

                        amout = Decimal.Round(amout * Decimal.Round((1 / conv.Rate), 4, MidpointRounding.AwayFromZero), 4, MidpointRounding.AwayFromZero);
                    }
                    else
                    {
                        amout = amout * conv.Rate;
                    }
                    previous = path;
                }
                return Decimal.ToInt32(Math.Round(amout, MidpointRounding.AwayFromZero));
            }
            return 0;
        }

        private List<RateConv> GetRates(List<string> lines)
        {
            return lines.Select(l =>
            {
                var split = l.Split(';');
                return new RateConv() { Source = split[0], Target = split[1], Rate = decimal.Parse(split[2], CultureInfo.InvariantCulture) };
            }).ToList();
        }

        private DirectedGraph<string> SetGraph(IList<string> othersLines)
        {
            var graph = new DirectedGraph<string>();

            foreach (var line in othersLines)
            {
                var splited = line.Split(';');
                var s = splited[0];
                var t = splited[1];
                var ed1 = new Edge<string>(s, t);
                graph.AddEdge(ed1);

                var ed2 = new Edge<string>(t, s);
                graph.AddEdge(ed2);
            }

            return graph;
        }
    }
}
