using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGeneration.Models
{
    class DocumentationCommentsTreesBuilder
    {
        List<string> lines = new List<string>();
        public void Add(string line)
        {
            if (IsCommentLine(line))
                lines.Add(line);
        }
        public bool IsCommentLine(string line)
        {
            line = line.Trim();
            if (line.Length < 3)
                return false;
            return line[0] == '/' && line[0] == '/';
        }

        public void Clear()
        {
            lines.Clear();
        }
        public IReadOnlyList<CommentNode> BuildTrees()
        {
            var cleanLines = PreProcess(lines);
            CommentNode current = null;
            List<CommentNode> rtn = new List<CommentNode>();

            foreach (var line in cleanLines)
            {
                switch (CalculateDepth(line))
                {
                    case Level.TopMost:
                        current = new CommentNode(line);
                        rtn.Add(current);
                        break;
                    case Level.Param:
                        var parent = current?.Parent ?? current;
                        current = new CommentNode(line, parent);
                        parent.Childs.Add(current);
                        break;
                    case Level.Content:
                        current.Content.Add(line.Trim());
                        break;
                    default:
                        break;
                }
            }
            return rtn;
        }
        enum Level { TopMost, Param, Content }
        private Level CalculateDepth(string line)
        {
            if (line.StartsWith("     "))
                return Level.Content;
            if (line.StartsWith("   "))
                return Level.Param;
            if (line.StartsWith(" "))
                return Level.TopMost;

            throw new InvalidOperationException("Case " + line + " is not suported");
        }
        string[] PreProcess(IEnumerable<string> lines)
        {
            return lines
                .Select(x => x.Trim())
                .Where(x => x.Length >= 3)
                .Select(x => x.Substring(2))
                .ToArray();
        }

        // Exmpale to convert to tree
        //
        // Summary:
        //     Projects each element of a sequence into a new form.
        //
        // Parameters:
        //   source:
        //     A sequence of values to invoke a transform function on.
        //
        //   selector:
        //     A transform function to apply to each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TResult:
        //     The type of the value returned by selector.
        //
        // Returns:
        //     An System.Collections.Generic.IEnumerable`1 whose elements are the result of
        //     invoking the transform function on each element of source.
        //
    }
}
