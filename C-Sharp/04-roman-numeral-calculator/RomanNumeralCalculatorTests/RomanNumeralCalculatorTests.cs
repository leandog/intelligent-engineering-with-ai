using Xunit;

namespace RomanNumeralCalculator
{
    public class RomanNumeralCalculatorTests
    {
        private readonly RomanNumeralCalculator calculator;

        public RomanNumeralCalculatorTests()
        {
            calculator = new RomanNumeralCalculator();
        }

        [Fact]
        public void AddsTwoSingleRomanNumerals()
        {
            var result = RomanNumeralCalculator.Add("I", "I");
            Assert.Equal("II", result);
        }

        [Fact]
        public void AddsRomanNumeralsWithSubtraction()
        {
            var result = RomanNumeralCalculator.Add("IV", "I");
            Assert.Equal("V", result);
        }

        [Fact]
        public void AddsComplexRomanNumerals()
        {
            var result = RomanNumeralCalculator.Add("IX", "II");
            Assert.Equal("XI", result);
        }

        [Fact]
        public void AddsLargeAndSmallRomanNumerals()
        {
            var result = RomanNumeralCalculator.Add("M", "I");
            Assert.Equal("MI", result);
        }

        [Fact]
        public void AddsNonSubtractiveRomanNumerals()
        {
            var result = RomanNumeralCalculator.Add("X", "V");
            Assert.Equal("XV", result);
        }

        [Fact]
        public void AddsRomanNumeralsToComplexResult()
        {
            var result = RomanNumeralCalculator.Add("XL", "X");
            Assert.Equal("L", result);
        }

        [Fact]
        public void AddsMultipleRomanNumerals()
        {
            var result = RomanNumeralCalculator.Add("X", "X");
            result = RomanNumeralCalculator.Add(result, "X");
            Assert.Equal("XXX", result);
        }

        [Fact]
        public void HandlesEmptyStrings()
        {
            var result = RomanNumeralCalculator.Add("", "I");
            Assert.Equal("I", result);
        }

        [Fact]
        public void HandlesInvalidCharacters()
        {
            var result = RomanNumeralCalculator.Add("A", "I");
            Assert.Equal("Invalid Input", result);
        }

        [Fact]
        public void AddsThatResultsInSubtractionNumeral()
        {
            var result = RomanNumeralCalculator.Add("X", "IV");
            Assert.Equal("XIV", result);
        }

        [Fact]
        public void AddsMoreThanTwoNumerals()
        {
            var result = RomanNumeralCalculator.Add("I", "II");
            result = RomanNumeralCalculator.Add(result, "III");
            Assert.Equal("VI", result);
        }

        [Fact]
        public void AddsLargeNumerals()
        {
            var result = RomanNumeralCalculator.Add("D", "D");
            Assert.Equal("M", result);
        }
    }
}
