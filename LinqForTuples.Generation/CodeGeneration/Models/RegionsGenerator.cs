using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGeneration.Models
{
    class RegionsGenerator : ICasesGenerator
    {
        public ICaseSource Source { get; set; }

        public (string Output, IReadOnlyList<string> NotProcessesed, IReadOnlyList<string> Processesed) Generate(string[] cases)
        {
            StringBuilder output = new StringBuilder();

            foreach (var @case in cases)
            {
                output.Append("\n");
                output.Append($"#region {@case}");
                output.Append("\n");
                output.Append($"#endregion {@case}");
            }
            return (output.ToString(), Array.Empty<string>(), cases.ToArray());
        }

        public Dictionary<string, (string Begin, string End)> MapCases(string[] cases)
        {
            var rtn = new Dictionary<string, (string Begin, string End)>();
            foreach (var @case in cases)
            {
                rtn[@case] = ($"#region {@case}", $"#endregion {@case}");
            }
            return rtn;
        }
    }
}
