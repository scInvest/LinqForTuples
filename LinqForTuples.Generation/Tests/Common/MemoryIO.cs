using CodeGeneration;
using CodeGeneration.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Common;
using System.Diagnostics;

namespace Tests.Common
{

    internal class MemoryIO: IInputReader, OutputWriter
    {
        private static readonly Dictionary<string, string> memory = new Dictionary<string, string>();

        public string[] ReadAllLines(string path)
        {
            if (memory.ContainsKey(path))
                return memory[path].SplitAllLines();

            return Array.Empty<string>();
        }

        public void Write(string text, ICaseSource @case)
        {
            memory[@case.OutputPath] = text;
        }

        public bool FileExist(string path)
        {
            return memory.ContainsKey(path);
        }
    }
}
