using CodeGeneration.Language;
using CodeGeneration.Language.Implementations;
using CodeGeneration.Models.ParameterReplacers;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Windows.Ink;

namespace CodeGeneration.Models
{
    class CasesFactory
    {
        public static ICaseSource Regions => new CaseSource("Regions", "", "");
        public static ICaseSource SimpleLinq => new CaseSource("Simple linq", PathResolver.Instance.Input.SimpleLinqDeclaration, PathResolver.Instance.Output.SimpleLinqTuplesExtensions);
        public static ICaseSource AllLinq => new CaseSource("All linq", PathResolver.Instance.Input.ALLLinqDecaration, PathResolver.Instance.Output.LinqTuplesExtensions);
        public static ICaseSource NotGeneric => new CaseSource("Not generic", PathResolver.Instance.Input.NonGenric, PathResolver.Instance.Output.NotGenericTuplesExtensions);
        public static ICaseSource NotGeneric_Numeric => new CaseSource("Not generic numeric", PathResolver.Instance.Input.NotGeneric_Numeric, PathResolver.Instance.Output.NotGeneric_Numeric);
        public static ICaseSource NotGeneric_TSource => new CaseSource("Not generic TSource", PathResolver.Instance.Input.NotGeneric_TSource, PathResolver.Instance.Output.NotGeneric_TSource);
        public static ICaseSource ComentsType => new CaseSource("Coments type", PathResolver.Instance.Input.AllLinqPlusComments, PathResolver.Instance.Output.ComentsType);
        public static ICaseSource AllLinqAndComments => new CaseSource("All linq + comments", PathResolver.Instance.Input.AllLinqPlusComments, PathResolver.Instance.Output.LinqTuplesExtensions);
        public static ICaseSource GenericRequiredInBody => new CaseSource("GenericRequiredInBody", PathResolver.Instance.Input.GenericRequiredInBody, PathResolver.Instance.Output.GenericRequiredInBodyExtensions);

        public static ICaseSource TupleToEnumerable_Many => new CaseSource("CustomTupleExtenstions_Many", PathResolver.Instance.Input.TupleToEnumerable_Many, PathResolver.Instance.Output.TupleToEnumerable_Many);
        public static ICaseSource CustomTupleExtenstions => new CaseSource("CustomTupleExtenstions", PathResolver.Instance.Input.CustomTupleExtenstions, PathResolver.Instance.Output.CustomTupleExtenstions);

        public static ICaseSource Current => new CaseSource("Current work", PathResolver.Instance.Input.Current, PathResolver.Instance.Output.Temp);
    }
    class GeneratorsFactory
    {

        public static CopyFileGenerator CopyFileGenerator(string target, string @namespace, string[] blackList)
        {
            return new CopyFileGenerator(target, @namespace, blackList);
        }
        public static CommentsTypesGenerator CommentsTypesGenerator()
        {
            return new CommentsTypesGenerator(CasesFactory.ComentsType);
        }
        public static ICasesGenerator Current()
        {
            var current = GenerateTupleToEnumerable();
            //current.Source = CasesFactory.Current;
            current.Source.OutputPath = CasesFactory.Current.OutputPath;
            return current;
        }
        public static RegionsGenerator RegionGenerator()
        {
            return new RegionsGenerator() { Source = CasesFactory.Regions };
        }
        public static ICasesGenerator NoGeneric_NumericLinq()
        {
            return new DefaultDeclarationGenerator(new ParametesSwiperBaseOnFirstType(), CasesFactory.NotGeneric_Numeric, MethodGeneratorFactory.SimpleLinq);
        }
        public static ICasesGenerator NoGeneric_TSourceLinq()
        {
            return new DefaultDeclarationGenerator(new ParametesSwiperBaseOnTSourceGeneric(), CasesFactory.NotGeneric_TSource, MethodGeneratorFactory.SimpleLinq);
        }
        public static ICasesGenerator NoGenericLinq()
        {
            return new DefaultDeclarationGenerator(new MultiCollectionSwiper(), CasesFactory.NotGeneric, MethodGeneratorFactory.MultipleLinq);
        }
        public static ICasesGenerator SimpleLinq()
        {
            return new DefaultDeclarationGenerator(new ParamentersSwiperTuple(), CasesFactory.SimpleLinq, MethodGeneratorFactory.SimpleLinq);
        }
        public static ICasesGenerator AllLinq()
        {
            return new DefaultDeclarationGenerator(new ParamentersSwiperTuple(), CasesFactory.AllLinqAndComments, MethodGeneratorFactory.SimpleLinq);
        }
        public static ICasesGenerator GenericRequiredInBody()
        {
            return new DefaultDeclarationGenerator(new AddAllCasesForTuple(), CasesFactory.GenericRequiredInBody, MethodGeneratorFactory.GenericRequiredInBody);
        }

        public static ICasesGenerator GenerateCasesForStaticClass(string @class)
        {
            return new DefaultDeclarationGenerator(new AddAllCasesForTuple(), CasesFactory.GenericRequiredInBody, MethodGeneratorFactory.StaticMethodCallForLinq(@class));
        }
        public static ICasesGenerator GenerateCustomTupleExtenstions()
        {
            return GenerateCasesForStaticClass("CustomTupleExtenstions", CasesFactory.CustomTupleExtenstions, new ParamentersSwiperTuple(false));
        }
        public static ICasesGenerator GenerateCasesForStaticClass(string @class, ICaseSource @case, MethodSubcasesGenerator paramsGenerator)
        {
            return new DefaultDeclarationGenerator(paramsGenerator, @case, MethodGeneratorFactory.StaticMethodCallForLinq(@class));
        }

        public static ICasesGenerator GenerateTupleToEnumerable()
        {
            return new DefaultDeclarationGenerator(new ParamentersSwiperTuple_EnumerationOrT(),
                CasesFactory.TupleToEnumerable_Many, 
                MethodGeneratorFactory.TupleToEnumerable);
        }


        public static IEnumerable<ICasesGenerator> FilesToCopy(string output, string tag, string @namespace, string[] blackLsit)
        {
            var classCopierSource = new HandWrittenClassCopier();
            classCopierSource.FrazesToBlackListLine = blackLsit;
            classCopierSource.Tag = tag;
            classCopierSource.Namespace = @namespace;
            classCopierSource.FilesToCopy = PathResolver.Instance.Input.ManuallyWritenClasses();
            classCopierSource.OutputFolder = output;
                
            return classCopierSource.GetGenerators().Where(x => true).ToArray();
        }
    }
    class MethodGeneratorFactory
    {
        public static IMethodTemplateSource StaticMethodCallForLinq(string @class) => LinqMethod(x => new CallStatickMethodWhitEnumerable(@class));
        public static IMethodTemplateSource SimpleLinq => LinqMethod(x => new ParamsToEnumerable());
        public static IMethodTemplateSource MultipleLinq => LinqMethod(x => new FirtsParamToEnumerable());
        public static IMethodTemplateSource GenericRequiredInBody => LinqMethod(x => new LinqDecarationMethodBodyWithGeneric());
        public static IMethodTemplateSource TupleToEnumerable => LinqMethod(x => new TupleToEnumerableMethodBody());

        private static MethodTemplateSource LinqMethod(Func<string, MethodBodyWriter> makeBody)
        {
            return new MethodTemplateSource(LinqDecarationParser.FromLinqDeclaration, makeBody);
        }
    }
}
