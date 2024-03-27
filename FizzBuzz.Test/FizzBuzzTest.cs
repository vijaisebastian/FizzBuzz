using FizzBuzz.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
        public void Verify_FizzCheck_Return_False_When_Input_Is_Not_Divisible_By_Three()
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
        public void Verify_BuzzCheck_Return_False_When_Input_Is_Not_Divisible_By_Five()
        {
            BuzzCheck buzzCheck = new BuzzCheck();
            Assert.IsFalse(buzzCheck.Validate(12));
        }

        [TestMethod]
        public void Verify_FizzBuzzCheck_Return_True_When_Input_Is_Divisible_By_Three_And_Five()
        { 
            FizzBuzzCheck fizzBuzzCheck=new FizzBuzzCheck();
            Assert.IsTrue(fizzBuzzCheck.Validate(15));
        }

        [TestMethod]
        public void Verify_FizzBuzzCheck_Return_False_When_Input_Is_Not_Divisible_By_Three_And_Five()
        {
            FizzBuzzCheck fizzBuzzCheck = new FizzBuzzCheck();
            Assert.IsFalse(fizzBuzzCheck.Validate(29));
        }

        [TestMethod]
        public void Verify_PlayFizzBuzz_Return_Fizz_When_Input_Is_Divisible_By_Three()
        {
            var conditions = new List<ICheck>
            {
                new FizzCheck(),
                new BuzzCheck(),
                new FizzBuzzCheck(),
            };
            
            Game game = new Game(conditions);
            Assert.AreEqual(game.PlayFizzBuzz(36), "Fizz");
        }

        [TestMethod]
        public void Verify_PlayFizzBuzz_Return_Buzz_When_Input_Is_Divisible_By_Five()
        {
            var conditions = new List<ICheck>
            {
                new FizzCheck(),
                new BuzzCheck(),
                new FizzBuzzCheck(),
            };

            Game game = new Game(conditions);
            Assert.AreEqual(game.PlayFizzBuzz(70), "Buzz");
        }

        [TestMethod]
        public void Verify_PlayFizzBuzz_Return_FizzBuzz_When_Input_Is_Divisible_By_Three_And_Five()
        {
            var conditions = new List<ICheck>
            {
                new FizzCheck(),
                new BuzzCheck(),
                new FizzBuzzCheck(),
            };

            Game game = new Game(conditions);
            Assert.AreEqual(game.PlayFizzBuzz(45), "FizzBuzz");
        }

        [TestMethod]
        public void Verify_PlayFizzBuzz_Return_Number_When_Input_Is_Not_Divisible_By_Three_And_Five()
        {
            var conditions = new List<ICheck>
            {
                new FizzCheck(),
                new BuzzCheck(),
                new FizzBuzzCheck(),
            };

            Game game = new Game(conditions);
            int expected = 41;
            Assert.AreEqual(game.PlayFizzBuzz(41), expected.ToString());
        }
    }
}
