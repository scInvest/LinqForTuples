using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
namespace CodeGeneration
{
    class CodeInjectorStateMachine
    {
        int state = ADD_INIT_LINES;
        const int ADD_INIT_LINES = 0;
        const int GENERATED_LINES_AREA = 1;
        const int ADD_END_LINES = 2;

        string whiteSpace = "        "; //8 white spaces for my vs settings;

        public string MakeFileContent(string[] existingLines, IEnumerable<string> generatedCode, (string Begin, string End) blobMark)
        {
            var beginMark = blobMark.Begin;
            var endMark = blobMark.End;
            StringBuilder rtn = new StringBuilder();

            foreach (var line in existingLines)
            {
                switch (state)
                {
                    case ADD_INIT_LINES: AddInitLine(line); break;
                    case GENERATED_LINES_AREA: GeneratedArea(line); break;
                    case ADD_END_LINES: AddEndLine(line); break;
                }
            }

            return rtn.ToString();

            void AddInitLine(string line)
            {
                rtn.Append(line + "\n");
                if (line.Contains(beginMark))
                {
                    state = GENERATED_LINES_AREA;
                    rtn.Append("\n");
                    var generated = generatedCode.SelectMany(Extensions.SplitAllLines).Select(x => whiteSpace + x);

                    rtn.Append(string.Join("\n", generated.ToArray()));
                }
            }
            void GeneratedArea(string line)
            {
                if (line.Contains(endMark))
                {
                    state = ADD_END_LINES;
                    rtn.Append("\n" + line + "\n");
                }
            }
            void AddEndLine(string line)
            {
                rtn.Append(line + "\n");
            }
        }
    }
}
