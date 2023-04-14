using CodeGeneration.Models;

namespace CodeGeneration
{
    public interface IOutputWriter
    {
        void Write(string text, ICaseSource @case);
    }
}
