using CodeGeneration.Models;

namespace CodeGeneration
{
    public class FileInjectorWriter : OutputWriter
    {
        public void Write(string text, ICaseSource @case)
        {
            CodeInjector.Inject(@case.OutputPath, @case.BlobMark, text);
        }
    }
}
