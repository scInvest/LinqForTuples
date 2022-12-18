using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{

    public class PathResolver
    {
        private static SingleSetProperty<PathResolver> paths = new SingleSetProperty<PathResolver>();
        public static PathResolver Instance
        {
            get { return paths.Property; }
            set { paths.Property = value; }
        }

        private readonly int paretFolder;

        public InputPaths Input => new InputPaths();
        public OutputPaths Output => new OutputPaths();
        public ProgrammingPaths Solutions => new ProgrammingPaths();
        public PathResolver(int paretFolder = 0)
        {
            this.paretFolder = paretFolder;
        }
        public string Resolve(IEnumerable<string> paths, params string[] otherPaths)
        {
            return Resolve(paths.Concat(otherPaths).ToArray());
        }
        public string Resolve(params string[] paths)
        {
            var current = Environment.CurrentDirectory;

            for (int i = 0; i < paretFolder; i++)
            {
                current = System.IO.Directory.GetParent(current).FullName;
            }
            foreach (var item in paths)
            {
                if (item == "~")
                {
                    current = System.IO.Directory.GetParent(current).FullName;
                }
                else
                {
                    current = System.IO.Path.Combine(current, item);
                }
            }
            return current;
        }
    }
}
