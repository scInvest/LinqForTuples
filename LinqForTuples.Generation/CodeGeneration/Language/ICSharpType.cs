using System.Collections.Generic;

namespace CodeGeneration.Language
{
    public interface ICSharpType
    {
        string Name { get; set; }
        IReadOnlyList<ICSharpType> GenericParams { get; set; }
    }
}
