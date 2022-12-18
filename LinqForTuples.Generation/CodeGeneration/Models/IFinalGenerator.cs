using System.Collections;
using System.Collections.Generic;

namespace CodeGeneration.Models
{
    public interface IFinalGenerator
    {
        IReadOnlyList<ICasesGenerator> AllUsedCases { get; }
    }
}

