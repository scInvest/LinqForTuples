using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CodeGeneration.Models
{
    class CommentsTypesGenerator : ICasesGenerator
    {
        public CommentsTypesGenerator(ICaseSource caseSource)
        {
            Source = caseSource;
        }

        public ICaseSource Source { get; set; }

        public (string Output, IReadOnlyList<string> NotProcessesed, IReadOnlyList<string> Processesed) Generate(string[] cases)
        {
            var used = new List<string>();
            var notUsed = new List<string>();
            var buildier = new DocumentationCommentsTreesBuilder();

            foreach (var item in cases)
            {
                if (buildier.IsCommentLine(item))
                {
                    buildier.Add(item);
                    used.Add(item);
                }
                else
                {
                    notUsed.Add(item);
                }
            }

            var trees = buildier.BuildTrees();
            var output = new Dictionary<string, HashSet<string>>();
            foreach (var topTreeNode in trees)
            {
                if (!output.ContainsKey(topTreeNode.Name))
                    output.Add(topTreeNode.Name, new HashSet<string>());

                foreach (var paramNode in topTreeNode.Childs)
                {
                    output[topTreeNode.Name].Add(paramNode.Name);
                }
            }

            return (FormatOutput(output), notUsed, used);
        }
        private string FormatOutput(Dictionary<string, HashSet<string>> output)
        {
            StringBuilder rtn = new StringBuilder();
            foreach (var item in output)
            {
                rtn.Append(item.Key + '\n');
                foreach (var value in item.Value)
                {
                    rtn.Append('\t' + value + '\n');
                }
            }
            return rtn.ToString();
        }

    }
}
