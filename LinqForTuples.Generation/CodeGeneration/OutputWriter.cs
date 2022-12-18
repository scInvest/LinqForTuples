using CodeGeneration.Models;

namespace CodeGeneration
{
    public interface OutputWriter
    {
        void Write(string text, ICaseSource @case);
    }
}
