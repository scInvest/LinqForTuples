using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration.Language.Implementations
{
    class TextComment : IComment
    {
        public TextComment(string comment)
        {
            AsText = comment;
        }
        public string AsText { get; }
    }
}
