using FizzBuzz.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void Verify_FizzCheck_Return_True_When_Input_Is_Divisible_By_Three()
        {
            FizzCheck fizzCheck = new FizzCheck();
            Assert.IsTrue(fizzCheck.Validate(6));
        }

        [TestMethod]
        public void Verify_FizzCheck_Return_True_When_Input_Is_Not_Divisible_By_Three()
        {
            FizzCheck fizzCheck = new FizzCheck();
            Assert.IsFalse(fizzCheck.Validate(5));
        }

        [TestMethod]
        public void Verify_BuzzCheck_Return_True_When_Input_Is_Divisible_By_Five()
        {
            BuzzCheck buzzCheck = new BuzzCheck();
            Assert.IsTrue(buzzCheck.Validate(10));
        }

        [TestMethod]
        public void Verify_BuzzCheck_Return_True_When_Input_Is_Not_Divisible_By_Five()
        {
            BuzzCheck buzzCheck = new BuzzCheck();
            Assert.IsFalse(buzzCheck.Validate(12));
        }

    }
}
