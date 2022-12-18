using CodeGeneration.Language;
using CodeGeneration.Language.Implementations;
using Common;
using System.Collections.Generic;
using System.Linq;

namespace CodeGeneration.Models.ParameterReplacers
{
    class ParametesSwiperBaseOnFirstType : ParamentersSwiperTuple, MethodSubcasesGenerator
    {
        public override (IEnumerable<string> Collection, bool IsValid) Generate(MethodTemplate method)
        {
            var signature = method.Signature;
            if (signature.Parameters.IsNullOrEmpty() || !signature.Parameters.First().ThisPrefix)
                return (new string[0], false);

            var type = signature.Parameters.First().Type;
           
            if(type?.GenericParams?.Count != 1)
                return (new string[0], false);

            if (signature?.Generic == null || signature.Generic.Count() == 0)
            {
                return (Generate(method, type.GenericParams.First().ToString()), true);
            }
            return (new string[0], false);
        }
    }
}
