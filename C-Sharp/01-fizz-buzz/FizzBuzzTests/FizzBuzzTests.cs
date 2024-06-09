/*
# Three Laws of Test Driven Development
- You are not allowed to write any production code unless it is to make a failing unit test pass.
- You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures.
- You are not allowed to write any more production code than is sufficient to pass the one failing unit test.
*/

/*
PROBLEM REQUIREMENTS:
Write a program that returns a list of strings from 1 to n, where n is the upper bound.

- For multiples of three, return “Fizz” instead of the number
- For multiples of five, return “Buzz”
- For numbers which are multiples of both three and five, return “FizzBuzz“
- Otherwise, return the ordinal number (as a String)

**Upper bound**: 15
**Example output**: ['1', '2', 'Fizz', '4', 'Buzz', 'Fizz', '7', '8', 'Fizz', 'Buzz', '11', 'Fizz', '13', '14', 'FizzBuzz']
*/
using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Given0_ReturnsEmptyArray()
        {
            var result = FizzBuzz.GetResults(0);
            Assert.Empty(result);
        }

        [Fact]
        public void Given1_Returns1()
        {
            var result = FizzBuzz.GetResults(1);
            Assert.Equal(["1"], result);
        }

        [Fact]
        public void Given3_Returns1_2_Fizz()
        {
            var result = FizzBuzz.GetResults(3);
            Assert.Equal(["1", "2", "Fizz"], result);
        }

        [Fact]
        public void Given5_Returns1_2_Fizz_4_Buzz()
        {
            var result = FizzBuzz.GetResults(5);
            Assert.Equal(["1", "2", "Fizz", "4", "Buzz"], result);
        }

        [Fact]
        public void Given15_ReturnsFizzBuzzSequence()
        {
            var result = FizzBuzz.GetResults(15);
            Assert.Equal(
                [
                    "1",
                    "2",
                    "Fizz",
                    "4",
                    "Buzz",
                    "Fizz",
                    "7",
                    "8",
                    "Fizz",
                    "Buzz",
                    "11",
                    "Fizz",
                    "13",
                    "14",
                    "FizzBuzz"
                ],
                result
            );
        }

        [Fact]
        public void GivenNegative3_ReturnsEmpty()
        {
            var result = FizzBuzz.GetResults(-3);
            Assert.Equal([], result);
        }

        [Fact]
        public void Given100_ReturnsCorrectFizzBuzzSequence()
        {
            var result = FizzBuzz.GetResults(100);

            Assert.Equal(100, result.Count);
            Assert.Equal("Fizz", result[2]);
            Assert.Equal("Buzz", result[4]);
            Assert.Equal("FizzBuzz", result[14]);
            Assert.Equal("Buzz", result[99]);
        }
    }
}
