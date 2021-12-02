using NFluent;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class Tests
    {
        [Test]
        public void Should_return_1_when_input_is_1()
        {
            var output = Game.Answer(1);
            Check.That(output).IsEqualTo("1");
        }
        
        [Test]
        public void Should_return_2_when_input_is_2()
        {
            var output = Game.Answer(2);
            Check.That(output).IsEqualTo("2");
        }

        [Test]
        public void Should_return_Fizz_when_input_is_3()
        {
            var output = Game.Answer(3);
            Check.That(output).IsEqualTo("Fizz");
        }
        
        [Test]
        public void Should_return_4_when_input_is_4()
        {
            var output = Game.Answer(4);
            Check.That(output).IsEqualTo("4");
        }
        
        [Test]
        public void Should_return_Buzz_when_input_is_5()
        {
            var output = Game.Answer(5);
            Check.That(output).IsEqualTo("Buzz");
        }

        [Test]
        public void Should_return_Buzz_when_input_is_10()
        {
            var output = Game.Answer(10);
            Check.That(output).IsEqualTo("Buzz");
        }

        [Test]
        public void Should_return_Fizz_when_input_is_6()
        {
            var output = Game.Answer(6);
            Check.That(output).IsEqualTo("Fizz");
        }

        [Test]
        public void Should_return_FizzBuzz_when_input_is_15()
        {
            var output = Game.Answer(15);
            Check.That(output).IsEqualTo("FizzBuzz");
        }

        [Test]
        public void Should_return_FizzBuzz_when_input_is_45()
        {
            var output = Game.Answer(45);
            Check.That(output).IsEqualTo("FizzBuzz");
        }

    }

    public class Game
    {
        public static string Answer(int input)
        {
            if (IsDivisibleBy(3, input) && IsDivisibleBy(5, input))
            {
                return "FizzBuzz";
            }
            
            if (IsDivisibleBy(3, input))
            {
                return "Fizz";
            }

            if (IsDivisibleBy(5, input))
            {
                return "Buzz";
            }
            return input.ToString();
        }

        private static bool IsDivisibleBy(int divider, int input)
        {
            return input % divider == 0;
        }
    }
}