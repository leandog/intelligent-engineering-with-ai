using System;
using Xunit;

namespace Bowling
{
    public class BowlingGameTests
    {
        [Fact]
        public void GutterGameScoresZero()
        {
            var game = new BowlingGame();
            var score = game.GetScore("-- -- -- -- -- -- -- -- -- --");
            Assert.Equal(0, score);
        }

        [Fact]
        public void AllNinesScoresNinety()
        {
            var game = new BowlingGame();
            var score = game.GetScore("9- 9- 9- 9- 9- 9- 9- 9- 9- 9-");
            Assert.Equal(90, score);
        }

        [Fact]
        public void AllOnesScoresTwenty()
        {
            var game = new BowlingGame();
            var score = game.GetScore("11 11 11 11 11 11 11 11 11 11");
            Assert.Equal(20, score);
        }

        [Fact]
        public void SingleSpareFollowedByThreeScoresSixteen()
        {
            var game = new BowlingGame();
            int score = game.GetScore("5/ 3- -- -- -- -- -- -- -- --");
            Assert.Equal(16, score);
        }

        [Fact]
        public void SingleStrikeFollowedByThreeAndFourScoresTwentyFour()
        {
            var game = new BowlingGame();
            int score = game.GetScore("X 34 -- -- -- -- -- -- -- --");
            Assert.Equal(24, score);
        }

        [Fact]
        public void ThreeStrikesInARowScoresSixty()
        {
            var game = new BowlingGame();
            int score = game.GetScore("X X X -- -- -- -- -- -- --");
            Assert.Equal(60, score);
        }

        [Fact]
        public void StrikeSpareStrikeThreeAndMissScoresSixtyThree()
        {
            var game = new BowlingGame();
            int score = game.GetScore("X 5/ X 3- -- -- -- -- -- --");
            Assert.Equal(56, score);
        }

        [Fact]
        public void TwoStrikesSpareFiveThreeScoresEightyOne()
        {
            var game = new BowlingGame();
            int score = game.GetScore("X X 5/ 53 -- -- -- -- -- --");

            Assert.Equal(68, score);
        }

        [Fact]
        public void AllSparesWithZeroScoresOneFortyFiz()
        {
            var game = new BowlingGame();
            int score = game.GetScore("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/0");
            Assert.Equal(145, score);
        }

        [Fact]
        public void AllSparesWithFiveScoresOneHundredFifty()
        {
            var game = new BowlingGame();
            int score = game.GetScore("5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5");
            Assert.Equal(150, score);
        }

        [Fact]
        public void PerfectGameScoresThreeHundred()
        {
            var game = new BowlingGame();
            int score = game.GetScore("X X X X X X X X X X X X");
            Assert.Equal(300, score);
        }

        [Fact]
        public void InvalidRollCharacterThrowsException()
        {
            var game = new BowlingGame();
            Assert.Throws<ArgumentException>(() => game.GetScore("X X X X X X X X X X X Y"));
        }
    }
}
