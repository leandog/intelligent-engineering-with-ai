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
        public void Converts_1_Sec_To_1_Second()
        {
            string input = "1 sec";
            double expected = 1.0;

            double result = DurationConverter.ConvertToSeconds(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Converts_Empty_String_To_Zero()
        {
            string input = "";
            double expected = 0.0;

            double result = DurationConverter.ConvertToSeconds(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Converts_1_Ms_To_0_001_Seconds()
        {
            string input = "1 ms";
            double expected = 0.001;

            double result = DurationConverter.ConvertToSeconds(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Converts_1_Min_To_60_Seconds()
        {
            string input = "1 min";
            double expected = 60.0;

            double result = DurationConverter.ConvertToSeconds(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Converts_1_Hr_To_3600_Seconds()
        {
            string input = "1 hr";
            double expected = 3600.0;

            double result = DurationConverter.ConvertToSeconds(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Converts_5_Sec_421_Ms_To_5_421_Seconds()
        {
            string input = "5 sec 421 ms";
            double expected = 5.421;

            double result = DurationConverter.ConvertToSeconds(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Converts_9_Min_57_Sec_To_597_Seconds()
        {
            string input = "9 min 57 sec";
            double expected = 597.0;

            double result = DurationConverter.ConvertToSeconds(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Converts_1_Hr_33_Min_To_5580_Seconds()
        {
            string input = "1 hr 33 min";
            double expected = 5580.0;

            double result = DurationConverter.ConvertToSeconds(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Converts_1_Hr_1_Min_1_Sec_111_Ms_To_3661_111_Seconds()
        {
            string input = "1 hr 1 min 1 sec 111 ms";
            double expected = 3661.111;

            double result = DurationConverter.ConvertToSeconds(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Converts_0_Sec_To_Zero()
        {
            string input = "0 sec";
            double expected = 0.0;

            double result = DurationConverter.ConvertToSeconds(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Converts_Invalid_Input_To_Zero()
        {
            string input = "invalid input";
            double expected = 0.0;

            double result = DurationConverter.ConvertToSeconds(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Converts_Mixed_Valid_And_Invalid_Input_To_Zero()
        {
            string input = "1 hr 99 minutes";
            double expected = 3600.0;

            double result = DurationConverter.ConvertToSeconds(input);

            Assert.Equal(expected, result);
        }
    }
}
