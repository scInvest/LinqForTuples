using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Media.Animation;

namespace CodeGeneration.Models
{
   public class CopyFileGenerator : ICasesGenerator
    {
        private readonly string @namespace;
        private readonly string[] blackList;

        public CopyFileGenerator(string target, string @namespace, string[] blackList)
        {
            Target = target;
            this.@namespace = @namespace;
            this.blackList = blackList;
        }
        public ICaseSource Source { get; set; }
        public string Target { get; }
        public (string Output, IReadOnlyList<string> NotProcessesed, IReadOnlyList<string> Processesed) Generate(string[] cases)
        {
            bool isValidToCopy = false;
            List<string> lines = new List<string>();
            foreach (var line in cases)
            {
                isValidToCopy |= IsLineContainingCopyAttribute(isValidToCopy, line);
                if (blackList.Any(x => line.Contains(x)))
                {
                    continue;
                }
                if (line.StartsWith("namespace"))
                {
                    lines.Add("namespace " + @namespace);
                }
                else
                {
                    lines.Add(line);
                }
            }
            return isValidToCopy ? (string.Join("\n", lines), Array.Empty<string>(), lines)
                           : ("", Array.Empty<string>(), lines);
        }

        private bool IsLineContainingCopyAttribute(bool isValid, string line)
        {
            if (line.Contains("CopyClassAtrribute(CopyMode.CopyClass"))
            {
                if (line.Contains('"' + Target + '"'))
                {
                    isValid = true;
                }
            }
            return isValid;
        }
    }
}
