using CodeGeneration.Language;
using CodeGeneration.Language.Implementations;
using System.Collections.Generic;
using System.Linq;

namespace CodeGeneration.Language.Implementations
{
    class LinqDecarationMethodBodyWithGeneric : MethodBodyWriter
    {
        public IReadOnlyList<string> CreateBody(MethodTemplate method)
        {
            var methodToCall = method.Signature.Name;
            var variableToUse = method.Signature.Parameters.First().Name;
            var @params = GetParams(method.Signature.Parameters);
            var @generic = method.Signature.Generic.First().ToString();
            var line = $"return {variableToUse}.ToEnumerableAsObject().{methodToCall}<{@generic}>({@params});";
            return new[] { line };
        }

        private string GetParams(IReadOnlyList<IMethodParam> @params)
        {
            @params = @params.Skip(1).ToArray();
            var names = @params.Select(x => x.Name);
            var formatedParams = string.Join(", ", names.ToArray());
            return formatedParams;
        }
    }
}
