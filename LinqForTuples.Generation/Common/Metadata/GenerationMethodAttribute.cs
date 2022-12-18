using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Metadata
{
    [AttributeUsage(AttributeTargets.Method)]
    public class GenerationMethodAttribute : Attribute
    {
        public GenerationMethodAttribute(bool generateTuples, bool generateRegularExtension)
        {
            GenerateTuples = generateTuples;
            GenerateRegularExtension = generateRegularExtension;
        }

        public bool GenerateTuples { get; }
        public bool GenerateRegularExtension { get; }
    }
}
