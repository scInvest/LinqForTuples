using System.Collections.Generic;

namespace CodeGeneration.Models.ParameterReplacers
{
    class CompositeGenerator : IParameterTypeGenerator
    {
        private readonly IParameterTypeGenerator[] parameterTypeGenerators;

        public CompositeGenerator(params IParameterTypeGenerator[] parameterTypeGenerators)
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
