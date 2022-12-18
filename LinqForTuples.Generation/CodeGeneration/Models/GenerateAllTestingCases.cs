using Common;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace CodeGeneration.Models
{
    public class GenerateAllTestingCases : IFinalGenerator
    {
        const string copyFilesTag = "TestProject";
        const string @namespace = "LinqForTuplesExtensionsStandard.GeneratedCode";
        string output = PathResolver.Instance.Output.TestsProjectFoler;
        string[] metadaAttribute = new[] { "CopyClassAtrribute(", "using Common.Metadata;" };

        public IReadOnlyList<ICasesGenerator> CopyFileCases => GeneratorsFactory.FilesToCopy(output, copyFilesTag, @namespace, metadaAttribute).ToArray();
        public IReadOnlyList<ICasesGenerator> AllUsedCases => DataCases.Concat(CopyFileCases).ToArray();

        protected virtual List<ICasesGenerator> DataCases => new List<ICasesGenerator> {
            GeneratorsFactory.SimpleLinq(),
            GeneratorsFactory.GenerateCustomTupleExtenstions(),
            GeneratorsFactory.GenerateTupleToEnumerable(),
            GeneratorsFactory.GenericRequiredInBody(),
            GeneratorsFactory.NoGenericLinq(),
            GeneratorsFactory.NoGeneric_NumericLinq(),
            GeneratorsFactory.NoGeneric_TSourceLinq(),
        };
        private IEnumerable<GenrationOutputBaseOnCase> MapGenrationOutput(IEnumerable<ICasesGenerator> @cases)
        {
            return @cases.Select(x => new GenrationOutputBaseOnCase(x, MapSource(x.Source), ProjectIO.Reader, ProjectIO.Writer));
        }

        protected virtual ICaseSource MapSource(ICaseSource source)
        {
            return source;
        }
        public virtual void Generate()
        {
            foreach (var item in MapGenrationOutput(AllUsedCases))
            {
                item.Generate();
            }
        }
    }
}

