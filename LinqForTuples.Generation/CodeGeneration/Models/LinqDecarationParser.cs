using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGeneration.Language;
using CodeGeneration.Language.Implementations;
using Common;

namespace CodeGeneration.Models
{
    public class LinqDecarationParser
    {
        public static MethodSignature FromLinqDeclaration(string declarationLine)
        {
            if (declarationLine == null)
                throw new NullReferenceException();

            var words = declarationLine.Split(' ');
            var rtn = new MethodSignature();
            rtn.Access = GenarationHelper.Access(words[0]);
            rtn.Modifier = GenarationHelper.MethodModifiers(words[1]);

            var typeAndName = MethodNameAndTypeSection(declarationLine);
            words = BracesWordsResolver.Resolve(typeAndName, new[] { ',', ' ' }, ('(', ')'), ('<', '>'), ('[', ']')).ToArray();
            rtn.ReturnType = new SimpleType(words[2]);
            SetNameAndGenericType(words[3], rtn);

            var paramsSection = ParemsSection(declarationLine);
            var rawParams = BracesWordsResolver.Resolve(paramsSection, new[] { ',' }, ('<', '>'), ('(', ')'), ('[', ']')).ToArray();
            var @params = GetParams(rawParams);

            rtn.Parameters = @params.ToList();
            return rtn;
        }
        public static void SetNameAndGenericType(string nameAndGeneric, MethodSignature signature)
        {
            var start = nameAndGeneric.IndexOf("<");
            var end = nameAndGeneric.LastIndexOf(">");

            if (start < 0 && end < 0)
            {
                signature.Name = nameAndGeneric;
                return;
            }
            signature.Name = nameAndGeneric.Substring(0, start);

            var allGenerics = nameAndGeneric.Slice(start + 1, end);
            var items = BracesWordsResolver.Resolve(allGenerics, new[] { ',', ' ' }, ('(', ')'), ('<', '>'), ('[', ']')).ToList(); ;
            signature.Generic = items.Select(x => new SimpleType(x)).ToList();
        }

        private static string MethodNameAndTypeSection(string declarationLine)
        {
            var beg = declarationLine.IndexOf("(");
            return declarationLine.Substring(0, beg);
        }
        private static string ParemsSection(string declarationLine)
        {
            var beg = declarationLine.IndexOf("(") + 1;
            var len = declarationLine.Length - beg - 2;
            return declarationLine.Substring(beg, len);
        }
        private static IEnumerable<IMethodParam> GetParams(string[] rawParmas)
        {
            foreach (var RawParma in rawParmas)
            {
                yield return MakeMethodParam(RawParma);
            }
        }

        private static IMethodParam MakeMethodParam(string rawParma)
        {
            var words = BracesWordsResolver.Resolve(rawParma, new[] { ' ' }, ('<', '>'), ('(', ')'), ('[', ']')).ToArray();
            var rtn = new MethodParam();

            int index = 0;
            if (words.Length == 3)
            {
                rtn.ParamsPrefix = words[index] == "params";
                rtn.ThisPrefix = words[index] == "this";
                index++;
            }

            rtn.Type = new SimpleType(words[index]);
            rtn.Name = words[index + 1];

            if (rtn.Name == null)
                return null;

            return rtn;
        }
    }
}
