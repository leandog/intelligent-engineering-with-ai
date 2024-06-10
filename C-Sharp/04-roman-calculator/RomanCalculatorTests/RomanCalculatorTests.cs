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
Create a program, which, given a valid sequence of rolls for one line of American Ten-Pin RomanCalculator,
produces the total score for the game. Here are some things that the program will not do:

- We will not check for valid rolls.
- We will not check for correct number of rolls and frames.
- We will not provide scores for intermediate frames.

Depending on the application, this might or might not be a valid way to define a complete story,
but we do it here for purposes of keeping the kata light. I think you’ll see that improvements like
those above would go in readily if they were needed for real.

We can briefly summarize the scoring for this form of RomanCalculator:

- Each game, or “line” of RomanCalculator, includes ten turns, or “frames” for the bowler.
- In each frame, the bowler gets up to two tries to knock down all the pins.
- If in two tries, he fails to knock them all down, his score for that frame is the total number
    of pins knocked down in his two tries.
- If in two tries he knocks them all down, this is called a “spare” and his score for the frame
    is ten plus the number of pins knocked down on his next throw (in his next turn).
- If on his first try in the frame he knocks down all the pins, this is called a “strike”. His
    turn is over, and his score for the frame is ten plus the simple total of the pins knocked down
    in his next two rolls.
- If he gets a spare or strike in the last (tenth) frame, the bowler gets to throw one or two more
    bonus balls, respectively. These bonus throws are taken as part of the same turn. If the bonus throws
    knock down all the pins, the process does not repeat: the bonus throws are only used to calculate the
    score of the final frame.
- The game score is the total of all frame scores.
*/

using Xunit;

namespace RomanCalculator
{
    public class RomanCalculatorTests
    {
        [Fact]
        public void TestRomanCalculator()
        {
            // var RomanCalculator = new RomanCalculator();
            Assert.True(false, "Turn the checked value to true to pass this test");
        }
    }
}
