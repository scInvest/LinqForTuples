using CodeGeneration;
using CodeGeneration.Models;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tests.Common;

namespace Tests
{
    public class GenerationTest
    {
        [SetUp]
        public void Setup()
        {
            StaticSetup.Initialize();
        }
        [Test]
        public void GenerateAllTest()
        {
            var generator = new GenerateAllTestingCases();
            generator.Generate();
        }
        [Test]
        public void GenerateDotNet6()
        {
            var generator = new GenerateDotNet6();
            generator.Generate();
        }
        [Test]
        public void GenerateDotNet6_NoEmptyGeneratorResult()
        {
            var generator = new GenerateDotNet6();
            NoEmptyGeneratorResult(generator);
        }
        [Test]
        public void GenerateDotNet6_NoLinesSkipped()
        {
            var generator = new GenerateDotNet6();
            NoLinesSkipped(generator);
        }
        [Test]
        public void GenerateAllTest_NoEmptyGeneratorResult()
        {
            var generator = new GenerateAllTestingCases();
            NoEmptyGeneratorResult(generator);
        }
        [Test]
        public void GenerateAllTest_NoLinesSkipped()
        {
            var generator = new GenerateAllTestingCases();
            NoLinesSkipped(generator);
        }
        [Test]
        public void GenerateAllTest_SkippedAreEmpty()
        {
            var generator = new GenerateAllTestingCases();
            SkippedAreEmpty(generator);
        }
        [Test]
        public void GenerateDotNet6_SkippedAreEmpty()
        {
            var generator = new GenerateAllTestingCases();
            SkippedAreEmpty(generator);
        }
        private void SkippedAreEmpty(IFinalGenerator generator)
        {
            foreach (var item in generator.AllUsedCases)
            {
                if (skipped.Contains(item.Source.Name))
                {
                    var fileContent = ProjectIO.Reader.ReadAllLines(item.Source.InputPath);
                    var rtn = item.Generate(fileContent);
                    if (rtn.NotProcessesed != null && rtn.NotProcessesed.Count != 0)
                    {
                        throw new NotImplementedException($"Case {item.Source.Name} is missing '{rtn.NotProcessesed.Count}' lines!");
                    }
                }
            }
        }
        private readonly List<string> skipped = new List<string>() { "POC_newGeneratedExtanesion.cs" };
        private void NoEmptyGeneratorResult(IFinalGenerator generator)
        {
            foreach (var item in generator.AllUsedCases)
            {
                if (skipped.Contains(item.Source.Name))
                {
                    return;
                }

                var fileContent = ProjectIO.Reader.ReadAllLines(item.Source.InputPath);
                var rtn = item.Generate(fileContent);

                rtn.Output.ShouldNotBeNull("Case '" + item.Source.Name + "' returned empty output!");
                rtn.Output.Count().ShouldNotBe(0, "Case '" + item.Source.Name + "' returned empty output!");
            }
        }
        private void NoLinesSkipped(IFinalGenerator generator)
        {
            foreach (var item in generator.AllUsedCases)
            {
                if (skipped.Contains(item.Source.Name))
                {
                    return;
                }

                var fileContent = ProjectIO.Reader.ReadAllLines(item.Source.InputPath);
                var rtn = item.Generate(fileContent);
                if (rtn.NotProcessesed != null && rtn.NotProcessesed.Count != 0)
                {
                    throw new NotImplementedException($"Case {item.Source.Name} is missing '{rtn.NotProcessesed.Count}' lines!");
                }
            }
        }
    }
}
