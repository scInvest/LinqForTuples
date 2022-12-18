namespace CodeGeneration.Language.Implementations
{
    class MethodParam : IMethodParam
    {
        public string Name { get; set; }
        public ICSharpType Type { get; set; }
        public bool ThisPrefix { get; set; }
        public bool ParamsPrefix { get; set; }

        public override string ToString()
        {
            var @this = ThisPrefix ? "this" : "";
            var @params = ParamsPrefix ? "params" : "";
            return $"{@this}{@params} {Type} {Name}";
        }
    }
}
