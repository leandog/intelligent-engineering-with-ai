/*
# Three Laws of Test Driven Development
- You are not allowed to write any production code unless it is to make a failing unit test pass.
- You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures.
- You are not allowed to write any more production code than is sufficient to pass the one failing unit test.
*/

/*
PROBLEM REQUIREMENTS:
Execution times for a program are outputted in a non-standard parseable time format.

The format is such:

- `f'{amount} {duration type}'`
- amount is a positive integer value
- duration type is an enumeration of weighted values
  - ms : .001
  - sec : 1
  - min : 60
  - hr : 3600
- different duration types are joined together with a space character
- invalid input values equal zero

Create a program, which, given a valid time format, calculates the time in seconds.
*/
using Xunit;

namespace DurationConverter
{
    public class DurationConverterTests
    {
        [Fact]
        public void TestDurationConverter()
        {
            // var DurationConverter = new DurationConverter();
            Assert.True(false, "Turn the checked value to true to pass this test");
        }
    }
}
