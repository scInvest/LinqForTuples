using CodeGeneration.Models;

namespace CodeGeneration
{
    public class FileInjectorWriter : IOutputWriter
    {
        public void Write(string text, ICaseSource @case)
        {
            CodeInjector.Inject(@case.OutputPath, @case.BlobMark, text);
        }
    }
}
