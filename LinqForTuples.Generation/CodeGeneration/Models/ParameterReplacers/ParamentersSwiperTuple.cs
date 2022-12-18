using CodeGeneration.Language.Implementations;

using Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGeneration.Models.ParameterReplacers
{
    class ParamentersSwiperTuple : MethodSubcasesGenerator
    {
        private readonly bool thisRequired;

        public ParamentersSwiperTuple(bool thisRequired = true)
        {
            this.thisRequired = thisRequired;
        }
        public virtual (IEnumerable<string> Collection, bool IsValid) Generate(MethodTemplate method)
        {
            var signature = method.Signature;
            if (signature.Parameters.IsNullOrEmpty() || (thisRequired && !signature.Parameters.First().ThisPrefix))
                return (new string[0], false);
            if (signature.Generic.IsNullOrEmpty() || signature.Generic.Count < 1)
                return (new string[0], false);

            var type = signature.Generic.First();
            return (Generate(method, type.ToString()), true);
        }

        protected virtual ParameterTypeGenerator OverridesGenerator(string type)
        {
            return new SameClassTupleGenerator(type);
        }

        protected virtual IEnumerable<string> Generate(MethodTemplate method, string type)
        {
            MethodSignature signature = method.Signature;
            var original = signature.Parameters.First().Type;
            var cases = OverridesGenerator(type);
            foreach (var @case in cases.Generate())
            {
                signature.Parameters.First().Type = new SimpleType(@case.Tuple);
                yield return method.ToString();
            }
            signature.Parameters.First().Type = original;
        }
    }
}
