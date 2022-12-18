using CodeGeneration.Language.Implementations;
using Common;
using NUnit.Framework;
using Shouldly;
using System.Linq;
using Tests.Common;

namespace Tests
{
    public class CShartTypeTests
    {

        [SetUp]
        public void Setup()
        {
            StaticSetup.Initialize();
        }

        [Test]
        public void TestOutputPath()
        {
            SimpleType st = new SimpleType("string");
            st.Name.ShouldBe("string");
            st.GenericParams.IsNullOrEmpty().ShouldBeTrue();
        }

        [Test]
        public void Generic_2()
        {
            SimpleType st = new SimpleType("type<int, int>");
            st.Name.ShouldBe("type");
            st.GenericParams.IsNullOrEmpty().ShouldBeFalse();
            st.GenericParams.Count().ShouldBe(2);
        }
        [Test]
        public void Generic_2_2()
        {
            SimpleType st = new SimpleType("type<int,int>");
            st.Name.ShouldBe("type");
            st.GenericParams.IsNullOrEmpty().ShouldBeFalse();
            st.GenericParams.Count().ShouldBe(2);
        }
        [Test]
        public void Generic_1()
        {
            SimpleType st = new SimpleType("type<int>");
            st.Name.ShouldBe("type");
            st.GenericParams.IsNullOrEmpty().ShouldBeFalse();
            st.GenericParams.Count().ShouldBe(1);
        }
        [Test]
        public void Generic_Nestes1()
        {
            SimpleType st = new SimpleType("type<IEnumerable<int>>");
            st.Name.ShouldBe("type");
            st.GenericParams.IsNullOrEmpty().ShouldBeFalse();
            st.GenericParams.Count().ShouldBe(1);
            st.GenericParams.First().GenericParams.Count().ShouldBe(1);
        }
        [Test]
        public void Generic_Tuple()
        {
            SimpleType st = new SimpleType("(type, type, type)");
            st.Name.ShouldBe("(type, type, type)");
            st.GenericParams.Count.ShouldBe(3);
        }
        [Test]
        public void Generic_Tuple_Generic()
        {
            SimpleType st = new SimpleType("(type<T>, type<T>)");
            st.Name.ShouldBe("(type<T>, type<T>)");
            st.GenericParams.Count.ShouldBe(2);
        }

    }
}
