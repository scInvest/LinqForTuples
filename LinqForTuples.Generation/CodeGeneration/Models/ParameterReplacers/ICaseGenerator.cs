using CodeGeneration.Language.Implementations;
using System.Collections.Generic;

namespace CodeGeneration.Models.ParameterReplacers
{
    internal interface MethodSubcasesGenerator
    {
        (IEnumerable<string> Collection, bool IsValid) Generate(MethodTemplate method);
    }
}