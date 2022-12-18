using System.Text;

namespace CodeGeneration.Language.Implementations
{
    public class MethodTemplate : IMethodTemplate
    {
        public MethodSignature Signature { get; set; }
        public MethodBodyWriter Body { get; set; }
        public IComment Comments { get; set; }

        IMethodSignature IMethodTemplate.Signature => this.Signature;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.Comments?.AsText ?? "");
            stringBuilder.Append(Signature.ToString());
            stringBuilder.Append("\n" + "{");
            foreach (var line in Body.CreateBody(this))
            {
                 stringBuilder.Append("\n\t" + line);
            }
             stringBuilder.Append("\n" + "}");
            return stringBuilder.ToString(); ;
        }
    }
}
