using CodeGeneration.Language.Implementations;
namespace CodeGeneration.Language
{
    public interface IMethodTemplate
    {
        IComment Comments { get; }
        IMethodSignature Signature { get; }
        MethodBodyWriter Body { get; }
    }
}