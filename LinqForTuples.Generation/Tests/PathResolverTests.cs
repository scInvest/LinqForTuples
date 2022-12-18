using Common;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;
using Shouldly;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Tests.Common;

namespace Tests
{
    public class PathResolverTests
    {
        [SetUp]
        public void Setup()
        {
            StaticSetup.Initialize();
        }

        [Test]
        public void TestOutputPath()
        {
            var output = new OutputPaths();
            TestPaths(output.All);
        }
        [Test]
        public void ProgrammingPaths()
        {
            var output = new ProgrammingPaths();
            TestPaths(output.All);
        }
        [Test]
        public void TestInputPath()
        {
            var input = new InputPaths();
            TestPaths(input.All);
        }

        [Test]
        public void TestDotCsInputPath()
        {
            var input = new InputPaths();
            TestPaths(input.ManuallyWritenClasses());
        }

        private static void TestPaths(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                if (!System.IO.File.Exists(item))
                {
                    if (!System.IO.Directory.Exists(item))
                    {
                        throw new System.Exception("Path do not exists: " + item);
                    }
                }
            }
        }
        [Test]
        public void NoDuplicationBetweenInputAndOutPut()
        {
            var input = new InputPaths();
            var output = new OutputPaths();

            var inputData = input.All.ToHashSet();
            foreach (var item in output.All)
            {
                inputData.Contains(item).ShouldBeFalse("'" + item + "' is duplicated");
            }
        }
        [Test]
        public void NoDuplicationBetweenOutputs()
        {
            var output = new OutputPaths();

            var hashset = new HashSet<string>();
            var array = output.All.ToArray();

            foreach (var item in array)
            {
                if(hashset.Contains(item))
                {
                    System.Console.WriteLine(item);
                    array.Length.ShouldBe(hashset.Count, item);
                }
                hashset.Add(item);
            }
            array.Length.ShouldBe(hashset.Count);
        }
        [Test]
        public void NoDuplicationBetweenInput()
        {
            var input = new InputPaths();
            var output = new OutputPaths();

            var hashset = input.All.ToHashSet();
            var array = input.All.ToArray();

            array.Length.ShouldBe(hashset.Count);
        }
    }
}