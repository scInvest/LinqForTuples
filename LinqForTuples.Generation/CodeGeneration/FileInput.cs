namespace CodeGeneration
{
    public class FileInput : IInputReader
    {
        public string[] ReadAllLines(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }
    }
}
