using System.Collections.Generic;

namespace CodeGeneration.Models.ParameterReplacers
{
    interface IParameterTypeGenerator
    {
        IEnumerable<(string[] Types, string Tuple)> Generate();
    }
}
