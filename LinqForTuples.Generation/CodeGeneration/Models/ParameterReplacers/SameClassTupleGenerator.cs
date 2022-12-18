using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGeneration.Models.ParameterReplacers
{
    public class SameClassTupleGenerator : ParameterTypeGenerator
    {
        private readonly string type;

        public SameClassTupleGenerator(string type)
        {
            this.type = type;
        }
        public IEnumerable<(string[] Types, string Tuple)> Generate()
        {
            yield return (new string[] { $"System.ValueTuple<{type}>" }, $"System.ValueTuple<{type}>");
            for (int i = 2; i < 8; i++)
            {
                StringBuilder tuple = new StringBuilder();

                tuple.Append("(" + type);
                for (int j = 1; j < i; j++)
                {
                    tuple.Append(", " + type);
                }
                tuple.Append(")");
                var types = Enumerable.Repeat("type", i).ToArray();
                yield return (types, tuple.ToString());
            }
        }
    }
}
