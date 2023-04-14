using CodeGeneration.Language;
using CodeGeneration.Language.Implementations;
using System.Collections.Generic;
using System.Linq;

namespace CodeGeneration.Language.Implementations
{
    class ParamsToEnumerable : IMethodBodyWriter
    {
        public IReadOnlyList<string> CreateBody(MethodTemplate method)
        {
            var methodToCall = method.Signature.Name;
            var variableToUse = method.Signature.Parameters.First().Name;
            var @params = GetParams(method.Signature.Parameters);
            var line = $"return {variableToUse}.ToEnumerable().{methodToCall}({@params});";
            return new[] { line };
        }

        private string GetParams(IReadOnlyList<IMethodParam> @params)
        {
            @params = @params.Skip(1).ToArray(); //skip this collection, param
            var names = @params.Select(x => x.Name);
            var formatedParams = string.Join(", ", names.ToArray());
            return formatedParams;
        }
    }
}
