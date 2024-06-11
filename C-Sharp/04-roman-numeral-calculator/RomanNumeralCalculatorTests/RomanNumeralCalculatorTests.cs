/*
# Three Laws of Test Driven Development
- You are not allowed to write any production code unless it is to make a failing unit test pass.
- You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures.
- You are not allowed to write any more production code than is sufficient to pass the one failing unit test.
*/

/*
Fake it till you make it
*/

/*
# ZOMBIES
- Z: Zero - What happens if there are zero of a thing?
- O: One - What happens when there is exactly one of a thing?
- M: Many - What happens when there are more than one thing?
- B: Boundaries - Are there special boundary values for the thing?
- I: Interfaces - Are there common interfaces with expectations?
- E: Exceptions/Errors - What cases cause errors? Exactly what should they do?
*/

/*
S - Single Responsibility Principle
O - Open / Closed => Open for extension, closed for modification
L - Liskov Substitution => shape.area :: rectangle.area : square.area : circle.area
I - Interface Segregation
D - Dependency Inversion
*/

/*
D - Don't
R - Repeat
Y - Yourself
*/

/*
Y - You
A - Ain't
G - Gonna
N - Need
I - It
*/

/*
PROBLEM REQUIREMENTS:

“As a Roman Bookkeeper, I want to add Roman numbers because doing it manually is too tedious.” Given the Roman numerals (I, V, X, L, C, D, M which represent one, five, ten, fifty, hundred, five hundred, and a thousand respectively), create two numbers and add them. As we are in Rome, there is no such thing as decimals or integers; we need to do this with strings. An example would be “XIV” + “LX” = “LXXIV”.

**Rules for Roman Numerals:**

- Numerals can be concatenated to form a larger numeral (“XX” + “II” = “XXII”).
- If a lesser numeral is put before a bigger one, it means subtraction of the lesser from the bigger (“IV” means four, “CM” means nine hundred).
- If the numeral is I, X, or C, you can’t have more than three in a row (“IIII” is invalid).
- If the numeral is V, L, or D, you can’t have more than one in a row (“VV” is invalid).
*/

using Xunit;

namespace RomanNumeralCalculator
{
    public class RomanNumeralCalculatorTests
    {
        [Fact]
        public void TestRomanNumeralCalculator()
        {
            // var RomanNumeralCalculator = new RomanNumeralCalculator();
            Assert.True(false, "Turn the checked value to true to pass this test");
        }
    }
}
