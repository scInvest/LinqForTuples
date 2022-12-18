using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace CodeGeneration.Models
{
    public class GenrerateNetStandard : FinalGeneratorBase, IFinalGenerator
    {
        public override FinalGeneratorCustomization Customization => new FinalGeneratorCustomization()
        {
            OutputToCopyPath = PathResolver.Instance.Output.LinqForTuplesStandardFolder,
            OutputExtensionsPath = PathResolver.Instance.Output.LinqForTuplesStandardExtensions_cs,
            TargetNamespace = "LinqForTuples.Standard",
            TargetName = "NetStandard_6", //purpose
            DataCases = new List<ICasesGenerator>
            {
                GeneratorsFactory.SimpleLinq(),
                GeneratorsFactory.GenerateCustomTupleExtenstions(),
                GeneratorsFactory.GenerateTupleToEnumerable(),
                GeneratorsFactory.GenericRequiredInBody(),
                GeneratorsFactory.NoGenericLinq(),
                GeneratorsFactory.NoGeneric_NumericLinq(),
                GeneratorsFactory.NoGeneric_TSourceLinq(),
            }
        };
    }
    public class GenrerateNetFramework : FinalGeneratorBase, IFinalGenerator
    {
        public override FinalGeneratorCustomization Customization => new FinalGeneratorCustomization()
        {
            OutputToCopyPath = PathResolver.Instance.Output.NetFrameworkFolder,
            OutputExtensionsPath = PathResolver.Instance.Output.NetFrameworkExtensions_cs,
            TargetNamespace = "LinqForTuples.NetFramework",
            TargetName = "NetStandard_6", //purpose
            DataCases = new List<ICasesGenerator>
            {
                GeneratorsFactory.SimpleLinq(),
                GeneratorsFactory.GenerateCustomTupleExtenstions(),
                GeneratorsFactory.GenerateTupleToEnumerable(),
                GeneratorsFactory.GenericRequiredInBody(),
                GeneratorsFactory.NoGenericLinq(),
                GeneratorsFactory.NoGeneric_NumericLinq(),
                GeneratorsFactory.NoGeneric_TSourceLinq(),
            }
        };
    }
    public class GenerateDotNet6 : FinalGeneratorBase, IFinalGenerator
    {
        public override FinalGeneratorCustomization Customization => new FinalGeneratorCustomization()
        {
            OutputToCopyPath = PathResolver.Instance.Output.DotNet6Folder,
            OutputExtensionsPath = PathResolver.Instance.Output.DotNet6Extensions_cs,
            TargetNamespace = "LinqForTuples.DotNet6",
            TargetName = "NetStandard_6",
            DataCases = new List<ICasesGenerator> 
            {
                GeneratorsFactory.SimpleLinq(),
                GeneratorsFactory.GenerateCustomTupleExtenstions(),
                GeneratorsFactory.GenerateTupleToEnumerable(),
                GeneratorsFactory.GenericRequiredInBody(),
                GeneratorsFactory.NoGenericLinq(),
                GeneratorsFactory.NoGeneric_NumericLinq(),
                GeneratorsFactory.NoGeneric_TSourceLinq(),
            }
        };

    }
    public class FinalGeneratorCustomization
    {
        public string TargetName { get; set; }
        public string TargetNamespace { get; set; }
        public string OutputToCopyPath { get; set; }
        public string OutputExtensionsPath { get; set; }
        public IReadOnlyList<ICasesGenerator> DataCases { get; set; }
}

    public abstract class FinalGeneratorBase : IFinalGenerator
    {
        string[] metadaAttribute = new[] { "CopyClassAtrribute(", "using Common.Metadata;" };
        public static readonly (string, string) Mark = ("#region start generation 1st stage init", "#endregion end generation 1st stage init");
        Dictionary<string, (string Begin, string End)> blobMarkMap;

        private IReadOnlyList<ICasesGenerator> CopyFileCases => 
            GeneratorsFactory.FilesToCopy(Customization.OutputToCopyPath, Customization.TargetName, Customization.TargetNamespace, metadaAttribute).ToArray();
        
        public IReadOnlyList<ICasesGenerator> AllUsedCases => Customization.DataCases.Concat(CopyFileCases).ToArray();

        public abstract FinalGeneratorCustomization Customization { get; }

        public void Generate()
        {
            CreateInjectionMarksInOutPutFile();

            CopyImplementedClasses();
            GenerateDataCases();
        }

        private void GenerateDataCases()
        {
            foreach (var item in MapGenrationOutput())
            {
                item.Generate();
            }
            IEnumerable<GenrationOutputBaseOnCase> MapGenrationOutput()
            {
                return Customization.DataCases.Select(x => new GenrationOutputBaseOnCase(x, MapSource(x.Source), ProjectIO.Reader, ProjectIO.Writer));
            }
        }
        private ICaseSource MapSource(ICaseSource source)
        {
            if (source is RegionsGenerator)
                return source;

            source.OutputPath = Customization.OutputExtensionsPath;
            source.BlobMark = blobMarkMap[source.Name];
            return source;
        }
        private void CopyImplementedClasses()
        {
            foreach (var item in CopyFileCases)
            {
                GenrateFileContent(item);
            }
        }

        private void CreateInjectionMarksInOutPutFile()
        {
            RegionsGenerator regionsGenrator = GeneratorsFactory.RegionGenerator();
            var casesNames = Customization.DataCases.Select(x => x.Source.Name).ToArray();
            var targetSource = new CaseSource(regionsGenrator.Source, output: Customization.OutputExtensionsPath, insertionMark: Mark);

            var regionsFile = regionsGenrator.Generate(casesNames).Output;
            this.blobMarkMap = regionsGenrator.MapCases(casesNames);

            ProjectIO.Writer.Write(regionsFile, targetSource);
        }

        private void GenrateFileContent(ICasesGenerator casesGenerator)
        {
            GenrationOutputBaseOnCase genration = new GenrationOutputBaseOnCase(casesGenerator, ProjectIO.Reader, ProjectIO.Writer);
            genration.Generate();
        }
    }
}

