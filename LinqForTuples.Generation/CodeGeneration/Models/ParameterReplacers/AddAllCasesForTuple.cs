using CodeGeneration.Language;
using CodeGeneration.Language.Implementations;
using System.Collections.Generic;
using System.Linq;

namespace CodeGeneration.Models.ParameterReplacers
{
    class AddAllCasesForTuple : MethodSubcasesGenerator
    {
        public (IEnumerable<string> Collection, bool IsValid) Generate(MethodTemplate method)
        {
            var originalGeneric = method.Signature?.Generic?.ToList() ?? new List<ICSharpType>();
            var originalPram = method.Signature.Parameters;

            var rtn = Generate(method, originalGeneric);

            method.Signature.Parameters = originalPram;
            method.Signature.Generic = originalGeneric;

            return (rtn, true);
        }

        protected virtual IEnumerable<string> Generate(MethodTemplate method, IReadOnlyList<ICSharpType> originalGeneric)
        {
            var genericNameBase = "T";
            var generator = new AllTypesTupleGenerator(genericNameBase, 2, 8);
            foreach (var @case in generator.Generate())
            {
                var generic = originalGeneric.ToList();
                foreach (var t in @case.Types)
                {
                    generic.Add(new SimpleType(t));
                }
                method.Signature.Generic = generic;
                method.Signature.Parameters.First().Type = new SimpleType(@case.Tuple);
                method.Signature.Parameters.First().ThisPrefix = true;
                yield return method.ToString();
            }
        }
    }
}
