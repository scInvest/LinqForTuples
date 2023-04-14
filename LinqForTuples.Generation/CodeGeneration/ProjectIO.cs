using CodeGeneration.Models;
using Common;

namespace CodeGeneration
{
    public class ProjectIO
    {
        private static SingleSetProperty<IInputReader> reader = new SingleSetProperty<IInputReader>();
        public static IInputReader Reader
        {
            get { return reader.Property; }
            set { reader.Property = value; }
        }

        private static SingleSetProperty<IOutputWriter> writer = new SingleSetProperty<IOutputWriter>();
        public static IOutputWriter Writer
        {
            get { return writer.Property; }
            set { writer.Property = value; }
        }

    }
}
