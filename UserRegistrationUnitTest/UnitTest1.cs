using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexUserRegistration;

namespace UserRegistrationUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void when_all_Details_in_correct_format_should_return_Valid()
        {
            Patterns pattern = new Patterns();
            string firstNameTest = pattern.ValidateName("Ramesh");
            string lastNameTest = pattern.ValidateName("Verma");
            string mobileTest = pattern.ValidateMobile("91 7342043811");
            string emailTest = pattern.ValidateEmail("mihir2233@gmail.com");
            string passTest = pattern.ValidatePassword("ABcde@123");
            Assert.AreEqual("Valid", firstNameTest);
            Assert.AreEqual("Valid", lastNameTest);
            Assert.AreEqual("Valid", mobileTest);
            Assert.AreEqual("Valid", emailTest);
            Assert.AreEqual("Valid", passTest);
        }
        [TestMethod]
        public void when_all_Details_are_not_in_correct_format_should_return_Invalid()
        {
            Patterns pattern = new Patterns();
            string firstNameTest = pattern.ValidateName("Ra");
            string lastNameTest = pattern.ValidateName("V");
            string mobileTest = pattern.ValidateMobile("91 7342811");
            string emailTest = pattern.ValidateEmail("mihir@gmail");
            string passTest = pattern.ValidatePassword("abcde");
            Assert.AreEqual("Invalid", firstNameTest);
            Assert.AreEqual("Invalid", lastNameTest);
            Assert.AreEqual("Invalid", mobileTest);
            Assert.AreEqual("Invalid", emailTest);
            Assert.AreEqual("Invalid", passTest);
        }
    }
}
