namespace CodeGeneration.Models
{
    class GenrationOutputBaseOnCase
    {
        private readonly ICasesGenerator @case;
        private readonly ICaseSource source;
        private readonly IInputReader input;
        private readonly OutputWriter writer;

        public GenrationOutputBaseOnCase(ICasesGenerator @case, IInputReader input, OutputWriter writer)
        : this(@case, @case.Source, input, writer)
        {
        }
        public GenrationOutputBaseOnCase(ICasesGenerator @case, ICaseSource source, IInputReader input, OutputWriter writer)
        {
            this.@case = @case;
            this.source = source;
            this.input = input;
            this.writer = writer;
            BlobMark = (CodeInjector.GenerationBlobBeginMark, CodeInjector.GenerationBlobEndMark);
            Path = source.OutputPath;
        }
        public string Path { get; set; }
        public (string Begin, string End) BlobMark { get; set; }

        public void Generate()
        {
            var lines = input.ReadAllLines(source.InputPath);
            var output = @case.Generate(lines).Output;
            if (!string.IsNullOrEmpty(output))
                writer.Write(output, source);
        }
    }

}

