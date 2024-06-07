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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void TestFizzBuzz()
        {
            // var fizzBuzz = new FizzBuzz();
            Assert.IsTrue(false, "Turn the checked value to true to pass this test");
        }
    }
}
