using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace CodeGeneration.Language.Implementations
{
    public class SimpleType : ICSharpType
    {
        private readonly string rawString;

        public SimpleType(string nameAndGeneric)
        {
            rawString = nameAndGeneric;
            if (IsTupleShortCut(nameAndGeneric))
            {
                Name = nameAndGeneric;
                nameAndGeneric = (nameAndGeneric.Remove(nameAndGeneric.Length - 1)).Substring(1);

                var items = BracesWordsResolver.Resolve(nameAndGeneric, new[] { ',', ' ' }, ('(', ')'), ('<', '>'), ('[', ']')).ToList(); ;
                var generics = items.Select(x => new SimpleType(x)).ToList();
                this.GenericParams = generics;
            }
            else
            {
                var words = BracesWordsResolver.Resolve(nameAndGeneric, new[] { '<', '>' }, ('(', ')'), ('[', ']')).ToList(); ;
                Name = words[0];

                if (words.Count == 1)
                {
                    return;
                }
                var allGenerics = nameAndGeneric.Slice(Name.Length + 1, nameAndGeneric.Length - 1);
                var items = BracesWordsResolver.Resolve(allGenerics, new[] { ',', ' ' }, ('(', ')'), ('<', '>'), ('[', ']')).ToList(); ;

                var generics = items.Select(x => new SimpleType(x)).ToList();
                this.GenericParams = generics;
            }
        }

        private bool IsTupleShortCut(string nameAndGeneric)
        {
            return nameAndGeneric.StartsWith("(") && nameAndGeneric.EndsWith(")");
        }

        public string Name { get; set; }
        public IReadOnlyList<ICSharpType> GenericParams { get; set; } = new List<ICSharpType>();

        public override string ToString()
        {
            return rawString;
        }
    }
}
