using CodeGeneration;
using CodeGeneration.Models;
using Common;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class FullGeneartionTest
    {
        static bool isInitialized;
        public static void Initialize()
        {
            if (isInitialized)
                return;

            ProjectIO.Reader = new FileInput();
            ProjectIO.Writer = new FileInjectorWriter();
            PathResolver.Instance = new PathResolver(1);
            isInitialized = true;
        }

        [SetUp]
        public void Init()
        {
            Initialize();
        }
        [Test]
        public void NetFramework_FullGeneartionTest()
        {
            //To run this test you have to have msbuild in ur path foler or as enviroment variable
            // to find path call in cmd:
            // reg.exe query "HKLM\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0" /v MSBuildToolsPath
            //var gen = new GenrerateNetFramework();
            //gen.Generate();

            var project = PathResolver.Instance.Solutions.NetFrameworkSolution;
            RunMsBuild(project, "msbuild");
        }
        [Test]
        public void DotNet6_FullGeneartionTest()
        {
            //To run this test you have to have dotnet in ur path foler or as enviroment variable

            //var gen = new GenerateDotNet6();
            //gen.Generate();

            var project = PathResolver.Instance.Solutions.DotNet6Solution;
            RunMsBuild(project, "dotnet build");
        }
        [Test]
        public void Standrad_FullGeneartionTest()
        {
            //To run this test you have to have dotnet in ur path foler or as enviroment variable

            var gen = new GenrerateNetStandard();
            gen.Generate();

            var project = PathResolver.Instance.Solutions.StandradSolution;
            RunMsBuild(project, "dotnet build");
        }

        static void RunMsBuild(string projectPath, string buildType)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + buildType + " " + projectPath;

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            output.Length.ShouldBeGreaterThan(200);
            Console.WriteLine(output);
            output.Contains("0 Error(s)").ShouldBeTrue();
            output.Contains("Build succeeded.").ShouldBeTrue();
            string err = process.StandardError.ReadToEnd();
            Console.WriteLine(err);

            string.IsNullOrWhiteSpace(err).ShouldBeTrue();

            process.WaitForExit();

        }
    }
}
