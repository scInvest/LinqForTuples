using CodeGeneration.Language.Implementations;

namespace CodeGeneration.Models
{
    interface IMethodTemplateSource
    {
        MethodTemplate MakeMethod(string declaration);
    }
}
