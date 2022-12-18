using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Metadata
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct)]
    public class CopyClassAtrribute : System.Attribute
    {
        public CopyClassAtrribute(CopyMode mode,params string[] target)
        {
            Mode = mode;
            Target = target;
        }

        public CopyMode Mode { get; }
        public string[] Target { get; }
    }
    public enum CopyMode
    {
        CopyClass
    }
}
