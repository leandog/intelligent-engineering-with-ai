using System.Text;

namespace RomanNumeralCalculator
{
    public class RomanNumeralCalculator
    {
        private static readonly Dictionary<int, string> NumbersToRoman =
            new()
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };

        private static readonly Dictionary<char, int> RomanMap =
            new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

        public static string Add(string numeral1, string numeral2)
        {
            if (AnyNullOrEmpty(numeral1, numeral2))
                return numeral1 + numeral2;

            if (!AreValidRomanNumerals(numeral1, numeral2))
                return "Invalid Input";

            int sum = RomanToInteger(numeral1) + RomanToInteger(numeral2);
            return IntegerToRoman(sum);
        }

        private static bool AnyNullOrEmpty(string numeral1, string numeral2)
        {
            return string.IsNullOrEmpty(numeral1) || string.IsNullOrEmpty(numeral2);
        }

        private static bool AreValidRomanNumerals(params string[] numerals)
        {
            return numerals.All(IsValidRoman);
        }

        private static bool IsValidRoman(string numeral)
        {
            return numeral.All(c => RomanMap.ContainsKey(c));
        }

        private static int RomanToInteger(string numeral)
        {
            return numeral
                .Aggregate(
                    new { Total = 0, PrevValue = 0 },
                    (acc, c) =>
                    {
                        int value = RomanMap[c];
                        int newTotal = acc.Total + value;

                        if (value > acc.PrevValue)
                        {
                            newTotal -= 2 * acc.PrevValue;
                        }

                        return new { Total = newTotal, PrevValue = value };
                    }
                )
                .Total;
        }

        private static string IntegerToRoman(int number)
        {
            return NumbersToRoman
                .Aggregate(
                    new { Result = new StringBuilder(), Number = number },
                    (acc, pair) =>
                    {
                        while (acc.Number >= pair.Key)
                        {
                            acc.Result.Append(pair.Value);
                            acc = new { Result = acc.Result, Number = acc.Number - pair.Key };
                        }
                        return acc;
                    }
                )
                .Result.ToString();
        }
    }
}
