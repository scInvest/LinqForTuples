using System.Collections.Generic;

namespace CodeGeneration.Language
{
    public interface IMethodSignature
    {
        Access Access { get; set; }
        MethodModifiers Modifier { get; set; }
        ICSharpType ReturnType { get; set; }
        string Name { get; set; }
        IReadOnlyList<IMethodParam> Parameters { get; }
    }
}
