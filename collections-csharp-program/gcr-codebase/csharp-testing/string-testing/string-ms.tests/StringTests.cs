using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringTesting;

namespace StringMS.Tests
{
    [TestClass]
    public class StringTests
    {
        StringUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new StringUtils();
        }

        [TestMethod]
        public void Reverse_NormalString()
        {
            string result = utils.Reverse("abc");
            Assert.AreEqual("cba", result);
        }

        [TestMethod]
        public void Reverse_NullString()
        {
            string result = utils.Reverse(null);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Palindrome_ValidPalindrome()
        {
            bool result = utils.IsPalindrome("madam");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Palindrome_NotPalindrome()
        {
            bool result = utils.IsPalindrome("hello");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Palindrome_NullString()
        {
            bool result = utils.IsPalindrome(null);
            Assert.IsFalse(result);
        }

        // ---------- Upper Case ----------

        [TestMethod]
        public void UpperCase_LowerCaseString()
        {
            string result = utils.ToUpperCase("hello");
            Assert.AreEqual("HELLO", result);
        }

        [TestMethod]
        public void UpperCase_NullString()
        {
            string result = utils.ToUpperCase(null);
            Assert.IsNull(result);
        }
    }
}
