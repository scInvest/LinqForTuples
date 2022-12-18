using CodeGeneration.Models.ParameterReplacers;
using Common;
using System.Collections.Generic;
using System.Text;

namespace CodeGeneration.Models
{
    class DefaultDeclarationGenerator : ICasesGenerator
    {
        private readonly IMethodTemplateSource methodFactory;

        public DefaultDeclarationGenerator(MethodSubcasesGenerator cutomization, ICaseSource source, IMethodTemplateSource methodTemplateSource)
        {
            Cutomization = cutomization ?? new ParamentersSwiperTuple();
            Source = source;
            this.methodFactory = methodTemplateSource;
        }
        public MethodSubcasesGenerator Cutomization { get; }
        public ICaseSource Source { get; set; }

        public (string Output, IReadOnlyList<string> NotProcessesed, IReadOnlyList<string> Processesed) Generate(string[] cases)
        {
            var leftovers = new List<string>();
            var processesed = new List<string>();
            StringBuilder rtn = new StringBuilder();
            var queue = new List<string>();


            foreach (var methodDeclaration in cases)
            {
                queue.Add(methodDeclaration);
                var method = methodFactory.MakeMethod(methodDeclaration);
                if (method == null)
                    continue;

                var subCases = Cutomization.Generate(method);
                if (!subCases.IsValid)
                {
                    leftovers.AddRange(queue);
                    queue.Clear();
                    continue;
                }
                else
                {
                    processesed.AddRange(queue);
                    queue.Clear();
                }

                foreach (var @case in subCases.Collection)
                {
                    rtn.Append(@case + "\n");
                }
            }
            return (rtn.ToString(), leftovers.ToArray(), processesed.ToArray());
        }
    }
}
