using System.Collections.Generic;
using System.Linq;

namespace CodeGeneration.Language.Implementations
{
    class FirtsParamToEnumerable : IMethodBodyWriter
    {
        private static readonly string[] methodsToCall = new[] { ".ToEnumerable()" };
        public IReadOnlyList<string> CreateBody(MethodTemplate method)
        {
            var methodToCall = method.Signature.Name;
            var variableToUse = method.Signature.Parameters.First().Name;
            var @params = GetParams(method.Signature.Parameters, methodsToCall);
            var line = $"return {variableToUse}.ToEnumerable().{methodToCall}({@params});";
            return new[] { line };
        }

        private string GetParams(IReadOnlyList<IMethodParam> @params, IReadOnlyList<string> extensionToCall)
        {
            @params = @params.Skip(1).ToArray(); //skip this collection, param
            var names = @params.Select((x, i) => x.Name + GetExtenstion(i));
            var formatedParams = string.Join(", ", names.ToArray());
            return formatedParams;

            string GetExtenstion(int index)
            {
                if (index >= extensionToCall.Count)
                    return "";
                return extensionToCall[index];
            }
        }
    }
}
