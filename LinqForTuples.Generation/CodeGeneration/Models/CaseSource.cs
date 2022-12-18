namespace CodeGeneration.Models
{
    public class CaseSource : ICaseSource
    {
        public CaseSource(ICaseSource clone, string input = null, string output = null, (string End, string Begin)? insertionMark = null, string name = null)
        {
            Name = name ?? clone.Name;
            InputPath = input ?? clone.InputPath;
            OutputPath = output ?? clone.OutputPath;
            BlobMark = insertionMark ?? clone.BlobMark;
        }
        public CaseSource(string name, string input, string output )
            :this(name, input, output, CodeInjector.Mark)
        {
        }
        public CaseSource(string name, string input, string output, (string End, string Begin) insertionMark)
        {
            Name = name;
            InputPath = input;
            OutputPath = output;
            BlobMark = insertionMark;
        }
        public string Name { get; }
        public string InputPath { get; }
        public string OutputPath { get; set; }
        public (string Begin, string End) BlobMark { get; set; }

        public override string ToString()
        {
            return $"{Name} input{InputPath} output{OutputPath}";
        }
    }
}
