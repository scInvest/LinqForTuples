namespace CodeGeneration.Language
{
    public interface IMethodParam
    {
        string Name { get; set; }
        ICSharpType Type { get; set; }
        bool ThisPrefix { get; set; }
        bool ParamsPrefix { get; set; }
    }
}
