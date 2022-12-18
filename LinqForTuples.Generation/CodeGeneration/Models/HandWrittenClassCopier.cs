using System.Collections.Generic;
using System.IO;

namespace CodeGeneration.Models
{
    public class HandWrittenClassCopier 
    {
        public string[] FrazesToBlackListLine { get; set; }
        public string Tag { get; set; }
        public string Namespace { get; set; }
        public string[] FilesToCopy { get; set; }
        public string OutputFolder { get; set; }

        public IEnumerable<CopyFileGenerator> GetGenerators()
        {
            return GetCopyClassesCases();
        }
        private IEnumerable<CopyFileGenerator> GetCopyClassesCases()
        {
            var cases = new List<ICaseSource>();
            foreach (var file in FilesToCopy)
            {
                var name = Path.GetFileName(file);
                var @out = Path.Combine(OutputFolder, name);
                var @case = new CaseSource(name, file, @out, CodeInjector.WriteWholeFile);
                cases.Add(@case);
            }

            foreach (var @case in cases)
            {
                CopyFileGenerator generator = GeneratorsFactory.CopyFileGenerator(Tag, Namespace, FrazesToBlackListLine);
                generator.Source = @case;
                yield return generator;
            }
        }
    }
}

