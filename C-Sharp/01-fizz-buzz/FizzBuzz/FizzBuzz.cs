namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static List<string> GetResults(int n)
        {
            if (n < 0)
            {
                return [];
            }

            return Enumerable
                .Range(1, n)
                .Select(i =>
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        return "FizzBuzz";
                    else if (i % 3 == 0)
                        return "Fizz";
                    else if (i % 5 == 0)
                        return "Buzz";
                    else
                        return i.ToString();
                })
                .ToList();
        }
    }
}
