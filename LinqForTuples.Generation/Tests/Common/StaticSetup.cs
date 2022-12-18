using CodeGeneration;
using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Common
{
    internal class StaticSetup
    {
        static bool isInitialized;
        public static void Initialize()
        {
            if (!isInitialized)
            {
                var testIO = new HibridIO();
                ProjectIO.Reader = testIO;
                ProjectIO.Writer = testIO;
                PathResolver.Instance = new PathResolver(1);
                isInitialized = true;
            }
        }
    }
}
