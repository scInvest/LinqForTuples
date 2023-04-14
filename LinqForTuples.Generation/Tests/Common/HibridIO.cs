using CodeGeneration;
using CodeGeneration.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Common
{
    internal class HibridIO : IInputReader, IOutputWriter
    {
        MemoryIO inMemory = new MemoryIO();
        FileInput realRead = new FileInput();

        public string[] ReadAllLines(string path)
        {
            if(inMemory.FileExist(path))
                return inMemory.ReadAllLines(path);
            
            return realRead.ReadAllLines(path);
        }

        public void Write(string text, ICaseSource @case)
        {
            inMemory.Write(text, @case);
        }
    }
}
