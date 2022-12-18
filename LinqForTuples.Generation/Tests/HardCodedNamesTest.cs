
using Common.Metadata;
using ManuallyWritenExtensions;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    internal class HardCodedNamesTest
    {
        public void TestHardCodedNames()
        {
            nameof(CustomTupleExtenstions).ShouldBe("CustomTupleExtenstions");
            nameof(GenerationMethodAttribute).ShouldBe("GenerationMethodAttribute");
            nameof(CopyClassAtrribute).ShouldBe("CopyClassAtrribute");
        }
    }
}
