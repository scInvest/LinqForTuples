using CodeGeneration.Language;
using CodeGeneration.Language.Implementations;
using Common;
using System.Collections.Generic;
using System.Linq;

namespace CodeGeneration.Models.ParameterReplacers
{
    class MultiCollectionSwiper : MethodSubcasesGenerator
    {
        public (IEnumerable<string> Collection, bool IsValid) Generate(MethodTemplate method)
        {
            var signature = method.Signature;
            if (signature.Parameters.IsNullOrEmpty() || !signature.Parameters.First().ThisPrefix)
                return (new string[0], false);

            if (signature.Parameters.Count < 2 || FirstParam(method).Type.GenericParams?.Count != 1 && SecondParam(method).Type.GenericParams?.Count != 1)
            {
                return (new string[0], false);
            }

            return (GenerateCases(method), true);
        }

        private IMethodParam FirstParam(MethodTemplate method) { return method.Signature.Parameters.First(); }
        private IMethodParam SecondParam(MethodTemplate method) { return method.Signature.Parameters.Skip(1).First(); }

        private IEnumerable<string> GenerateCases(MethodTemplate method)
        {
            MethodSignature signature = method.Signature;
            var original = FirstParam(method).Type;
            var cases = new SameClassTupleGenerator(original.GenericParams.First().ToString());
            var originalSecond = SecondParam(method).Type;
            var nestedCase = new SameClassTupleGenerator(originalSecond.GenericParams.First().ToString()).Generate();


            foreach (var caseNested in nestedCase)
            {
                SecondParam(method).Type = new SimpleType(caseNested.Tuple);
                yield return method.ToString();
            }
            SecondParam(method).Type = originalSecond;

            foreach (var @case in cases.Generate())
            {
                FirstParam(method).Type = new SimpleType(@case.Tuple);
                yield return method.ToString();

                foreach (var caseNested in nestedCase)
                {
                    SecondParam(method).Type = new SimpleType(caseNested.Tuple);
                    yield return method.ToString();
                }
                SecondParam(method).Type = originalSecond;
            }
            FirstParam(method).Type = original;
        }
    }
}
