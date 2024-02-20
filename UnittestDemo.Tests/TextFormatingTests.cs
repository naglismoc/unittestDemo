using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnittestDemo.Tests
{
    [TestClass]
    public class TextFormatingTests
    {
        [TestMethod]
        public void nameCasePositiveTest()
        {
            string expected = "Naglis";
            string actual = TextFormating.nameCase("nAGLiS");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void nameCaseTrimTest()
        {
            Assert.AreEqual("Naglis", TextFormating.nameCase("   nAGLiS   "));
        }

        [TestMethod]
        public void nameCaseTwoNamesTest()
        {
            Assert.AreEqual("Naglis Jonas", TextFormating.nameCase("naglis jonas"));
        }
        [TestMethod]
        public void nameCaseEmptyNameTest()
        {
            Assert.AreEqual("", TextFormating.nameCase(""));
        }
    }
}
