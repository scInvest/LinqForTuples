using Common.Metadata;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class ProgrammingPaths : InternalPaths
    {
        public ProgrammingPaths()
        {
        }
        public ProgrammingPaths(IEnumerable<string> upperToOutputPath, IEnumerable<string> upperToInputPath)
        {
            this.solutionFolerPath = upperToOutputPath;
            this.upperToInputPath = upperToInputPath;
        }
        public string DotNet6Solution => PathResolver.Instance.Resolve(netStadardFolder, "LinqForTuples.DotNet6.sln");
        public string NetFrameworkSolution => PathResolver.Instance.Resolve(netFrameworkFolder, "LinqForTuples.NetFramework.sln");
        public string StandradSolution => PathResolver.Instance.Resolve(standardFolder, "LinqForTuples.Standard.sln");

        public IEnumerable<string> All => new string[] {
            DotNet6Solution,
            NetFrameworkSolution,
            StandradSolution,
        };

    }
    public class InternalPaths
    {
        protected IEnumerable<string> solutionFolerPath = new string[] { "~", "~", "~", "~" };
        protected IEnumerable<string> upperToInputPath = new string[] { "~", "~", "~" };
        protected IEnumerable<string> generationFolder = new string[] { "LinqForTuples.Testing", "LinqForTuplesExtensionsStandard", "GeneratedCode" };
        protected IEnumerable<string> dataFolder = new string[] { "CodeGeneration", "Data" };
        protected IEnumerable<string> dataManuallFolder = new string[] { "CodeGeneration", "Data", "ManuallyWriten" };

        protected IEnumerable<string> manuallyWritenFoler => upperToInputPath.Concat(new string[] { "ManuallyWritenExtensions" });
        protected IEnumerable<string> generationPath => solutionFolerPath.Concat(generationFolder);
        protected IEnumerable<string> dataPath => upperToInputPath.Concat(dataFolder);
        protected IEnumerable<string> dataManuallyPath => upperToInputPath.Concat(dataManuallFolder);
        protected IEnumerable<string> netStadardFolder => solutionFolerPath.Concat(new string[] { "LinqForTuples.DotNet6" });
        protected IEnumerable<string> netFrameworkFolder => solutionFolerPath.Concat(new string[] { "LinqForTuples.NetFramework" });
        protected IEnumerable<string> standardFolder => solutionFolerPath.Concat(new string[] { "LinqForTuples.Standard" });
    }
    public class OutputPaths : InternalPaths
    {
        public OutputPaths()
        {
        }
        public OutputPaths(IEnumerable<string> upperToOutputPath, IEnumerable<string> upperToInputPath)
        {
            this.solutionFolerPath = upperToOutputPath;
            this.upperToInputPath = upperToInputPath;
        }
        public string LinqTuplesExtensions => PathResolver.Instance.Resolve(generationPath, "SimpleLinqTuplesExtensions.cs");
        public string SimpleLinqTuplesExtensions => LinqTuplesExtensions;
        public string NotGenericTuplesExtensions => PathResolver.Instance.Resolve(generationPath, "NotGenericTuplesExtensions.cs");
        public string NotGeneric_Numeric => PathResolver.Instance.Resolve(generationPath, "NumericNonGeneric.cs");
        public string GenericRequiredInBodyExtensions => PathResolver.Instance.Resolve(generationPath, "GenericRequiredInBodyLinq.cs");
        public string Temp => PathResolver.Instance.Resolve(generationPath, "Temp.cs");
        public string NotGeneric_TSource => PathResolver.Instance.Resolve(generationPath, "TSourceNotGeneric.cs");

        public string DotNet6Extensions_cs => PathResolver.Instance.Resolve(netStadardFolder, "LinqForTuplesExtenstions.cs");
        public string DotNet6Folder => PathResolver.Instance.Resolve(netStadardFolder);

        public string NetFrameworkExtensions_cs => PathResolver.Instance.Resolve(netFrameworkFolder, "LinqForTuplesExtenstions.cs");
        public string NetFrameworkFolder => PathResolver.Instance.Resolve(netFrameworkFolder);

        public string LinqForTuplesStandardExtensions_cs => PathResolver.Instance.Resolve(standardFolder, "LinqForTuplesExtenstions.cs");
        public string LinqForTuplesStandardFolder => PathResolver.Instance.Resolve(standardFolder);

        public string TestsProjectFoler => PathResolver.Instance.Resolve(generationPath);

        public string TupleToEnumerable_Many => PathResolver.Instance.Resolve(generationPath, "TupleToEnumerable_Many.cs");
        public string CustomTupleExtenstions => PathResolver.Instance.Resolve(generationPath, "CustomTupleExtenstions.cs");

        public string ComentsType => PathResolver.Instance.Resolve(dataPath.Concat(new string[] { "ComentsTypeFromDeclarations.txt" }));

        public IEnumerable<string> All => new string[] {
                                           LinqTuplesExtensions,
                                           NotGenericTuplesExtensions,
                                           NotGeneric_Numeric,
                                           NotGeneric_TSource,
                                           ComentsType,
                                           GenericRequiredInBodyExtensions,
                                           Temp,
                                           NetFrameworkExtensions_cs,
                                           NetFrameworkFolder,
                                           TupleToEnumerable_Many,
                                           CustomTupleExtenstions,
                                           DotNet6Extensions_cs,
                                           DotNet6Folder,
                                           LinqForTuplesStandardExtensions_cs,
                                           LinqForTuplesStandardFolder
        };
    }

    public class InputPaths : InternalPaths
    {
        public InputPaths()
        {
        }
        public InputPaths(IEnumerable<string> upperToOutputPath, IEnumerable<string> upperToInputPath)
        {
            this.solutionFolerPath = upperToOutputPath;
            this.upperToInputPath = upperToInputPath;
        }
        public string Other => PathResolver.Instance.Resolve(dataPath, "Other.txt");



        public string ALLLinqDecaration => PathResolver.Instance.Resolve(dataPath, "AllLinqDecaration.txt");
        public string NonGenric => PathResolver.Instance.Resolve(dataPath, "NotGenericTuplesDeclaration.txt");
        public string NotGeneric_Numeric => PathResolver.Instance.Resolve(dataPath, "NumericNonGeneric.txt");
        public string NotGeneric_TSource => PathResolver.Instance.Resolve(dataPath, "TSourceNotGeneric.txt");
        public string AllLinqPlusComments => PathResolver.Instance.Resolve(dataPath, "AllLinqPlusComments.txt");
        public string SimpleLinqDeclaration => PathResolver.Instance.Resolve(dataPath, "SimpleLinqDeclaration.txt");
        public string GenericRequiredInBody => PathResolver.Instance.Resolve(dataPath, "GenericRequiredInBodyLinqDeclaration.txt");

        public string TupleToEnumerable_Many => PathResolver.Instance.Resolve(dataManuallyPath, "TupleToEnumerable_Many.txt");
        public string CustomTupleExtenstions => PathResolver.Instance.Resolve(dataManuallyPath, "CustomTupleExtenstions.txt");

        public string Current => PathResolver.Instance.Resolve(dataPath, "Current.txt");


        public string[] ManuallyWritenClasses()
        {
            var path = PathResolver.Instance.Resolve(manuallyWritenFoler);
            var files = System.IO.Directory.GetFiles(path, "*.cs");
            return files;
        }


        public IEnumerable<string> All => new string[] { Other,
                                           ALLLinqDecaration,
                                           NonGenric,
                                           AllLinqPlusComments,
                                           SimpleLinqDeclaration,
                                           GenericRequiredInBody,
                                           NotGeneric_TSource,
                                           NotGeneric_Numeric,
                                           TupleToEnumerable_Many,
                                           CustomTupleExtenstions,
                                           Current};
    }
}
