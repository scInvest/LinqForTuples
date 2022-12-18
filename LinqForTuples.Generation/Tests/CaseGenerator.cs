using CodeGeneration.Models.ParameterReplacers;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Shouldly;
using NUnit.Framework;
using Tests.Common;

namespace Tests
{
    public class CaseGenerator
    {
        [SetUp]
        public void Setup()
        {
            StaticSetup.Initialize();
        }
        [Test]
        public void TestCount()
        {
            var generator = new AllTypesTupleGenerator("T", 2, 8);
            generator.Generate().Count().ShouldBe(6);
        }
    }
}
