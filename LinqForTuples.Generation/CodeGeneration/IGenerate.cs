namespace CodeGeneration
{
    public interface IGenerate
    {
        string Path { get; set; }
        (string Begin, string End) BlobMark { get; set; }
        string Generate();
    }
}
