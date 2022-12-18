using CodeGeneration.Models;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tests.Common;

namespace Tests
{
    internal class HibridIOTests
    {
        [Test]
        public void NoFileCreated()
        {
            var io = new HibridIO();
            io.Write("abababba", new CaseSource("testcase", "c:\\not\\existing\\path", "c:\\not\\existing\\path"));
            System.IO.File.Exists("c:\\not\\existing\\path").ShouldBeFalse();
        }
    }
}
