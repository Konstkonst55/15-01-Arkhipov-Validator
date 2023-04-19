using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _15_01_ArkhipovValidator.Utils;

namespace ValidatorUnitTests
{
    [TestClass]
    public class ValidatorUnit
    {
        [TestMethod]
        public void TestValidateName()
        {
            string name = "1234";
            int min = 3, max = 25;

            Assert.IsTrue(name.ValidateMinMaxSymbols(min, max));
        }

        [TestMethod]
        public void TestValidateLastName()
        {
            string lastName = "1234";
            string wrongLastName = "1";

            int min = 2, max = 30;

            Assert.IsTrue(lastName.ValidateMinMaxSymbols(min, max));
            Assert.IsFalse(wrongLastName.ValidateMinMaxSymbols(min, max));
        }

        [TestMethod]
        public void TestValidateEmail()
        {
            string email = "konstkonst55@mail.ru";
            string wrongEmail = "konst.ru";

            Assert.IsTrue(email.ValidateEmail());
            Assert.IsFalse(wrongEmail.ValidateEmail());
        }
    }
}
