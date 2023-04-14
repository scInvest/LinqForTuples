using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CodeGeneration.Language.Implementations
{
    class CallStatickMethodWhitEnumerable : IMethodBodyWriter
    {
        private readonly string @class;

        public CallStatickMethodWhitEnumerable(string @class)
        {
            this.@class = @class;
        }
        public IReadOnlyList<string> CreateBody(MethodTemplate method)
        {
            var methodToCall = method.Signature.Name;
            var variableToUse = method.Signature.Parameters.First().Name;
            var @params = GetParams(method.Signature.Parameters);
            var comma = method.Signature.Parameters.Count > 1 ? ", " : "";
            var @return = "return ";
            if (method.Signature.ReturnType.ToString() == "void")
                @return = "";
            var line = $"{@return}{@class}.{methodToCall}({variableToUse}.ToEnumerable(){comma}{@params});";
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
