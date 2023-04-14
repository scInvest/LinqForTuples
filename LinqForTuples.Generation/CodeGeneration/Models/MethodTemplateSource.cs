using CodeGeneration.Language;
using CodeGeneration.Language.Implementations;
using System;

namespace CodeGeneration.Models
{
    class MethodTemplateSource : IMethodTemplateSource
    {
        private readonly Func<string, MethodSignature> makeSignature;
        private readonly Func<string, IMethodBodyWriter> makeBody;
        private readonly DocumentationCommentsBuilder builder = new DocumentationCommentsBuilder();

        public MethodTemplateSource(Func<string, MethodSignature> makeSignature, Func<string, IMethodBodyWriter> makeBody)
        {
            this.makeSignature = makeSignature;
            this.makeBody = makeBody;
        }
        public MethodTemplate MakeMethod(string stringLine)
        {
            if (stringLine.StartsWith("public static"))
            {
                var comment = builder.Build();
                builder.Clear();
                return new MethodTemplate()
                {
                    Comments = new TextComment(comment),
                    Body = makeBody(stringLine),
                    Signature = makeSignature(stringLine)
                };
            }
            else
            {
                builder.Add(stringLine);
                return null;
            }
        }
    }
}
