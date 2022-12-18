using System.Collections.Generic;

namespace CodeGeneration.Models
{
    public interface ICasesGenerator
    {
        ICaseSource Source { get; set; }
        (string Output, IReadOnlyList<string> NotProcessesed, IReadOnlyList<string> Processesed) Generate(string[] cases);
    }
}
