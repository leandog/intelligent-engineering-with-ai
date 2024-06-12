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
Z - Zero
O - One
M - Many
B - Boundary Behavior
I - Interface Definition
E - Exercise Exception Behavior
S - Simple
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
Boy Scout Rule - leave the code better than you found it
*/

/*
Make the Change Easy, Then Make the Easy Change
*/
using Xunit;

namespace GildedRose
{
    public class GildedRoseTests
    {
        [Fact]
        public void TestGildedRose()
        {
            var Items = new List<Item>
            {
                new()
                {
                    Name = "foo",
                    SellIn = 0,
                    Quality = 0
                }
            };
            GildedRose app = new(Items);
            app.UpdateQuality();
            Assert.Equal("fixme", Items[0].Name);
        }
    }
}
