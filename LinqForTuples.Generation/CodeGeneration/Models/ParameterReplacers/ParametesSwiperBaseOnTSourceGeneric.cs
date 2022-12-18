using CodeGeneration.Language.Implementations;
using Common;
using System.Collections.Generic;
using System.Linq;

namespace CodeGeneration.Models.ParameterReplacers
{
    class ParametesSwiperBaseOnTSourceGeneric : ParamentersSwiperTuple, MethodSubcasesGenerator
    {
        public override (IEnumerable<string> Collection, bool IsValid) Generate(MethodTemplate method)
        {
            var signature = method.Signature;
            if (signature.Parameters.IsNullOrEmpty() || !signature.Parameters.First().ThisPrefix)
                return (new string[0], false);

            var firstParamType = signature.Parameters.First().Type;
            if (firstParamType.GenericParams?.Count() != 1)
                return (new string[0], false);
            if(firstParamType.GenericParams.First().Name != "TSource")
                return (new string[0], false);

            var genericParamName = firstParamType.GenericParams.First().Name;
            return (Generate(method, genericParamName), true);
        }
    }
}
