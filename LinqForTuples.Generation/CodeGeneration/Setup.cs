using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
    public class Setup
    {
        static bool isInitialized; 
        public static void Initialize()
        {
            if (isInitialized)
                return;

            ProjectIO.Reader = new FileInput();
            ProjectIO.Writer = new FileInjectorWriter();
            PathResolver.Instance = new PathResolver();
            isInitialized = true;
        }
    }
}
