using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace CodeGeneration.Language.Implementations
{
    public class MethodSignature : IMethodSignature
    {
        public MethodSignature()
        {
        }
        public Access Access { get; set; }
        public MethodModifiers Modifier { get; set; }
        public string Name { get; set; }
        public IReadOnlyList<IMethodParam> Parameters { get; set; }
        public ICSharpType ReturnType { get; set; }
        public IReadOnlyList<ICSharpType> Generic { get; set; }

        public override string ToString()
        {
            var access = Enum.GetName(typeof(Access), Access).ToLower();
            var modifier = Enum.GetName(typeof(MethodModifiers), Modifier).ToLower();
            var @params = ParamsToString();
            var generic = "";
            if (!Generic.IsNullOrEmpty())
                generic = "<" + string.Join(", ", Generic) + ">";
            return $"{access} {modifier} {ReturnType} {Name}{generic}({@params})";
        }

        private string ParamsToString()
        {
            return string.Join(", ", Parameters.Select(x => x.ToString()));
        }
    }
}
