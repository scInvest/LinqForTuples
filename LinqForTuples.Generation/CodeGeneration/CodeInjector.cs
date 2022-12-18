using System;
using System.Windows;

namespace CodeGeneration
{
    class CodeInjector
    {
        public static readonly string GenerationBlobBeginMark = "#region generated code block";
        public static readonly string GenerationBlobEndMark = "#endregion generated code block";
        public static readonly (string End, string Begin) Mark = (GenerationBlobBeginMark, GenerationBlobEndMark);
        public static readonly (string End, string Begin) WriteWholeFile = (null, null);
        public static void Inject(string path, params string[] generatedCode)
        {
            Inject(path, (GenerationBlobBeginMark, GenerationBlobEndMark), generatedCode);
        }
        public static void Inject(string path, string text, (string Begin, string End) blobMark)
        {
            Inject(path, text, blobMark);
        }
        public static void Inject(string path, (string Begin, string End) blobMark, params string[] generatedCode)
        {
            string[] lines = new string[0];
            try
            {
                if (System.IO.Path.GetExtension(path) == ".cs" && (blobMark.End ?? blobMark.Begin) != null)
                {
                    lines = System.IO.File.ReadAllLines(path);
                    var newContent = new CodeInjectorStateMachine().MakeFileContent(lines, generatedCode, blobMark);
                    System.IO.File.WriteAllText(path, newContent);
                }
                else
                {
                    System.IO.File.WriteAllLines(path, generatedCode);
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllLines(path, lines);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
