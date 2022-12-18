using System.Collections.Generic;
using CodeGeneration.Language.Implementations;


namespace CodeGeneration.Language
{
    public interface MethodBodyWriter
    {
        IReadOnlyList<string> CreateBody(MethodTemplate method);
    }
}
