using System.Collections.Generic;

namespace CodeGeneration.Models
{
    public class CommentNode
    {
        internal CommentNode(string name, CommentNode parent = null)
        {
            Parent = parent;
            Name = name;
        }
        public CommentNode Parent { get; set; }
        public string Name { get; set; }
        public List<CommentNode> Childs { get; set; } = new List<CommentNode>();
        public List<string> Content { get; set; } = new List<string>();
    }
}
