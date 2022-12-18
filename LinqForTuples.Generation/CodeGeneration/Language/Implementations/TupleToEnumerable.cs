using System.Collections.Generic;
using System.Linq;

namespace CodeGeneration.Language.Implementations
{
    class TupleToEnumerableMethodBody : MethodBodyWriter
    {
        public IReadOnlyList<string> CreateBody(MethodTemplate method)
        {
            var methodToCall = method.Signature.Name;
            var tuple = method.Signature.Parameters.First();
            List<string> rtn = new List<string>();
            var tupleFields = tuple.Type.GenericParams;
            for (int i = 0; i < tupleFields.Count; i++)
            {
                var item = tupleFields[i];
                if (item.ToString().Contains("IEnumerable"))
                {
                    rtn.Add(WriteEnumerable(i, tuple.Name));
                }
                else
                {
                    rtn.Add(WriteSingleParam(i, tuple.Name));
                }
            }
            return rtn;
        }

        private string WriteSingleParam(int index, string tupleName)
        {
            return $"yield return {tupleName}.Item{index + 1};";
        }
        private string WriteEnumerable(int index, string tupleName)
        {
            var rtn = new[] {
                $"if({tupleName}.Item{index +1} == null)",
                "      yield break;",
                $"foreach (var item in {tupleName}.Item{index+1})",
                "{",
                 $"    yield return item;",
                "}"
           };
            return string.Join("\n", rtn);
        }
    }
}
