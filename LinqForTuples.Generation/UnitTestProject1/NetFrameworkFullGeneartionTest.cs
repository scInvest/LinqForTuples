using CodeGeneration;
using CodeGeneration.Models;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    [TestClass]
    public class FullGeneartionTest
    {
        static bool isInitialized;
        public static void Initialize()
        {
            if (isInitialized)
                return;

            ProjectIO.Reader = new FileInput();
            ProjectIO.Writer = new FileInjectorWriter();
            PathResolver.Instance = new PathResolver(0);
            isInitialized = true;
        }

        public void Init()
        {
            Initialize();
        }
        [TestMethod]

        public void NetFramework_FullGeneartionTest()
        {
            //To run this test you have to have msbuild in ur path foler or as enviroment variable
            // to find path call in cmd:
            // reg.exe query "HKLM\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0" /v MSBuildToolsPath
            Init();

            var gen = new GenrerateNetFramework();
            gen.Generate();

            var project = PathResolver.Instance.Solutions.NetFrameworkSolution;
            RunMsBuild(project, "dotnet build");
        }
        [TestMethod]

        public void DotNet6_FullGeneartionTest()
        {
            //To run this test you have to have dotnet in ur path foler or as enviroment variable
            Init();

            var gen = new GenerateDotNet6();
            gen.Generate();

            var project = PathResolver.Instance.Solutions.DotNet6Solution;
            RunMsBuild(project, "dotnet build");
        }
        [TestMethod]

        public void Standrad_FullGeneartionTest()
        {
            //To run this test you have to have dotnet in ur path foler or as enviroment variable
            Init();

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
            Console.WriteLine(output);
            string err = process.StandardError.ReadToEnd();
            Console.WriteLine(err);

            output.Length.ShouldBeGreaterThan(180);
            output.Contains("0 Error(s)").ShouldBeTrue();
            output.Contains("Build succeeded.").ShouldBeTrue();

            EvaluateTime(output);

            string.IsNullOrWhiteSpace(err).ShouldBeTrue();

            process.WaitForExit();
        }

        private static void EvaluateTime(string output)
        {
            var minValueExpected = 4;//seconds
            var maxValueExpected = 20;//seconds
            const string sampleMessageToParse = "Time Elapsed 00:00:07.73";
            output.Contains("Time Elapsed ").ShouldBeTrue();

            var index = output.IndexOf("Time Elapsed ");
            var timeMessage = output.Substring(index, sampleMessageToParse.Length);
            var parts =  timeMessage.Split(':','.');
            var secondsPart = parts[2];
            if (secondsPart.Length != 2)
                throw new Exception("invalid seconds value");
            if (secondsPart[0] =='0')
                secondsPart = secondsPart[1].ToString();

            int seconds = int.Parse(secondsPart);
            if (seconds < minValueExpected)
                throw new Exception("Execution was to fast");
            if (seconds > maxValueExpected)
                throw new Exception("Execution was to slow");
        }
    }
}
