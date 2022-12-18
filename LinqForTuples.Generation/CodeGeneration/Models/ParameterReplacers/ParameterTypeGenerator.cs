using System.Collections.Generic;

namespace CodeGeneration.Models.ParameterReplacers
{
    interface ParameterTypeGenerator
    {
        IEnumerable<(string[] Types, string Tuple)> Generate();
    }
}
