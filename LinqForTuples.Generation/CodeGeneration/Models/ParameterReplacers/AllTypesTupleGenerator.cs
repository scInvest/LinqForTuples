using System.Collections.Generic;
using System.Linq;

namespace CodeGeneration.Models.ParameterReplacers
{
    public class AllTypesTupleGenerator : ParameterTypeGenerator
    {
        private readonly string type;
        private readonly int start;
        private readonly int end;

        public AllTypesTupleGenerator(string type, int start, int end)
        {
            this.type = type;
            this.start = start;
            this.end = end;
        }
        public IEnumerable<(string[] Types, string Tuple)> Generate()
        {
            for (int i = start; i < end; i++)
            {
                var types = Types(type, i);

                var tuple = "(" + string.Join(", ", types) + ")";
                yield return (types.ToArray(), tuple);

            }
        }
        private IEnumerable<string> Types(string @base, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var type = @base + (i + 1);
                yield return type;
            }
        }
    }
}
