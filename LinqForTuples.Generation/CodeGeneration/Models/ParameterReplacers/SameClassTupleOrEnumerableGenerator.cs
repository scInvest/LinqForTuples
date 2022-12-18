using System.Collections.Generic;

namespace CodeGeneration.Models.ParameterReplacers
{
    public class SameClassTupleOrEnumerableGenerator : ParameterTypeGenerator
    {
        private readonly string type;

        public SameClassTupleOrEnumerableGenerator(string type)
        {
            this.type = type;
        }
        public IEnumerable<(string[] Types, string Tuple)> Generate()
        {
            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    if (i + j > 8)
                        break;
                    yield return GetCase(i, j, type);
                }
            }
            for (int i = 2; i < 8; i++)
            {
                yield return GetCase(0, i, type);
            }
        }

        private (string[] Types, string Tuple) GetCase(int TCount, int EnumerableCount, string type)
        {
            var rtn = "";
            List<string> types = new List<string>();
            for (int i = 0; i < TCount; i++)
            {
                types.Add(type);
                rtn += type;
                rtn += ", ";
            }
            for (int i = 0; i < EnumerableCount; i++)
            {
                types.Add("IEnumerable<" + type + ">");
                rtn += "IEnumerable<" + type + ">";
                rtn += ", ";
            }
            rtn = rtn.Remove(rtn.Length - 2);
            rtn = "(" + rtn + ")";

            return (types.ToArray(), rtn);
        }
    }
}
