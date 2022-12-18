using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace CodeGeneration.Models
{
    class DocumentationCommentsBuilder
    {
        private readonly DocumentationCommentsTreesBuilder buildier;

        public DocumentationCommentsBuilder()
        {
            buildier = new DocumentationCommentsTreesBuilder();
        }
        public void Add(string line)
        {
            buildier.Add(line);
        }
        public string Build()
        {
            var trees = buildier.BuildTrees();
            StringBuilder text = new StringBuilder();
            foreach (var topTreeNode in trees)
            {
                text.Append(ToString(topTreeNode));
            }
            return text.ToString();
        }
        public void Clear()
        {
            buildier.Clear();
        }
        private string ToString(CommentNode node)
        {
            PreProcesNodeNames(node);
            switch (node.Name)
            {
                case "Summary": Replace_EnumerableType_WithTuple(node); return MakeMarkup("summary", node.Content);
                case "Returns": Replace_EnumerableType_WithTuple(node); return MakeMarkup("returns", node.Content);
                case "Parameters": Replace_EnumerableType_WithTuple(node); return MakeMarkupList("param", "name", node);
                case "Type parameters": Replace_EnumerableType_WithTuple(node); return MakeMarkupList("typeparam", "name", node);
                case "Exceptions": Remove_T_MarkerFromChildsNode(node); return MakeMarkupList("exception", "cref", node);
                case "": return "";
                default: throw new NotImplementedException();
            }
        }
        private static void PreProcesNodeNames(CommentNode node)
        {
            node.Name = node.Name?.Replace(":", "")?.Trim() ?? "";
            if (node.Childs.IsNullOrEmpty())
                return;

            foreach (var child in node.Childs)
            {
                PreProcesNodeNames(child);
            }
        }
        private static CommentNode Remove_T_MarkerFromChildsNode(CommentNode node)
        {
            foreach (var item in node.Childs)
            {
                item.Name = item.Name.Substring(1);
            }
            return node;
        }
        private static CommentNode Replace_EnumerableType_WithTuple(CommentNode node)
        {
            for (int i = 0; i < (node?.Content?.Count ?? 0); i++)
            {
                node.Content[i] = node.Content[i].Replace("System.Collections.Generic.IEnumerable`1", "System.ValueTuple");
                node.Content[i] = node.Content[i].Replace("System.Collections.IEnumerable", "System.ValueTuple");
            }
            foreach (var item in node.Childs)
            {
                Replace_EnumerableType_WithTuple(item);
            }
            return node;
        }

        private string MakeMarkupList(string name, string paramName, CommentNode node)
        {
            StringBuilder rtn = new StringBuilder();
            var itemList = node.Childs.Select(x => (x.Name, x.Content));
            foreach (var item in itemList)
            {
                rtn.Append(MakeMarkupListRow(name, paramName, item.Name, item.Content));
            }
            return rtn.ToString();
        }

        private string MakeMarkupListRow(string name, string paramName, string pramContent, IEnumerable<string> content)
        {
            StringBuilder rtn = new StringBuilder();

            rtn.Append($"///<{name} {paramName}=\"{pramContent}\" >");
            rtn.Append(string.Join(" ", content));
            rtn.Append($" </{name}>\n");

            return rtn.ToString();
        }
        private string MakeMarkup(string name, IEnumerable<string> content)
        {
            StringBuilder rtn = new StringBuilder();

            rtn.Append($"///<{name}>\n");
            foreach (var line in content)
            {
                rtn.Append("/// " + line + "\n");
            }
            rtn.Append($"///</{name}>\n");

            return rtn.ToString();
        }
    }
}
