using System.Collections.Generic;

namespace CodeGeneration.Models.ParameterReplacers
{
    class CompositeGenerator : ParameterTypeGenerator
    {
        private readonly ParameterTypeGenerator[] parameterTypeGenerators;

        public CompositeGenerator(params ParameterTypeGenerator[] parameterTypeGenerators)
        {
            this.parameterTypeGenerators = parameterTypeGenerators;
        }

        public IEnumerable<(string[] Types, string Tuple)> Generate()
        {
            foreach (var generator in parameterTypeGenerators)
            {
                foreach (var @params in generator.Generate())
                {
                    yield return @params;
                }
            }
        }
    }
}
