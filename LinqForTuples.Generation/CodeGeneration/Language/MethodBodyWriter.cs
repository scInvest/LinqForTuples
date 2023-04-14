using System.Collections.Generic;
using CodeGeneration.Language.Implementations;


namespace CodeGeneration.Language
{
    public interface IMethodBodyWriter
    {
        IReadOnlyList<string> CreateBody(MethodTemplate method);
    }
}
