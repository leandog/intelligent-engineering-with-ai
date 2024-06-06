namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic Output
            Console.WriteLine("Hello, World!");

            // Types

            // Value Types
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            bool isActive = true;
            byte byteValue = 255;
            char charValue = 'A';
            decimal decimalValue = 10.5m;
            double doubleValue = 10.5;
            float floatValue = 10.5f;
            int intValue = 10;
            long longValue = 100000L;
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            // Reference Types
#pragma warning disable IDE0090 // Use 'new(...)'
            object obj = new object();
#pragma warning restore IDE0090 // Use 'new(...)'
            object objSimple = new();
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            string str = "Hello";
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            dynamic dyn = "Dynamic typing";

            // Implicit vs Explicit typing
            var i = 10; // Implicitly typed.
            int x = 10; // Explicitly typed.
            Console.WriteLine($"i={i}, x={x}");

            // Conditionals (if)
            var isTrue = false;
            if (isTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            // Arrays, Lists, & Dictionaries
#pragma warning disable IDE0300 // Simplify collection initialization
            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
#pragma warning restore IDE0300 // Simplify collection initialization
            string[] weekDaysSimple = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

            var optionList = new List<string> { "Option1", "Option2" };

            var cities = new Dictionary<string, string>
            {
                { "UK", "London, Manchester, Birmingham" },
                { "USA", "Chicago, New York, Washington" },
                { "India", "Mumbai, New Delhi, Pune" }
            };

            // Loops
            foreach (var kvp in cities)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Declarations & Classes
            var helloWorld = new HelloWorld { Name = "Grogu" };
            Console.WriteLine(helloWorld.Greeting());

            // Structs
            var point = new Point { X = 10, Y = 20 };
            Console.WriteLine($"Point: {point.X}, {point.Y}");

            // Enums
            var today = DaysOfWeek.Monday;
            Console.WriteLine($"Today is: {today}");

            // LINQ (Language Integrated Query)
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Functional Programming Examples
            // Filter: Using Where to filter even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}");

            // Find: Using FirstOrDefault to find the first even number
            var firstEven = numbers.FirstOrDefault(n => n % 2 == 0);
            Console.WriteLine($"First even number: {firstEven}");

            // Map: Using Select to square each number
            var squaredNumbers = numbers.Select(n => n * n).ToList();
            Console.WriteLine($"Squared numbers: {string.Join(", ", squaredNumbers)}");

            // Reduce: Using Aggregate to sum the numbers
            var sumOfNumbers = numbers.Aggregate((acc, n) => acc + n);
            Console.WriteLine($"Sum of numbers: {sumOfNumbers}");

            // Exception Handling
            try
            {
                int zero = 0;
                int result = 10 / zero;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }

            // Asynchronous Programming
            AsyncDemo().Wait();

            // Null-Coalescing Operator
            string? name = null;
            string greeting = name ?? "Hello, World!";
            Console.WriteLine(greeting);

            // Null-Conditional Operators
            Console.WriteLine(name?.Length);

            // Expression-bodied Members
            var person = new Person { FirstName = "John", LastName = "Doe" };
            Console.WriteLine(person.FullName);

            // Pattern Matching
            object obj1 = 42;
            if (obj1 is int number)
            {
                Console.WriteLine($"The number is {number}");
            }
        }

        class HelloWorld
        {
            private readonly string _message = "Hello, World!";

            // Auto-Implemented Properties
            public required string Name { get; set; }

            // Expression-bodied Member
            public string Greeting() => $"{Name}\n{_message}";
        }

        // Struct Example
        struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        // Enum Example
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        // Asynchronous Programming Example
        static async Task AsyncDemo()
        {
            await Task.Delay(1000);
            Console.WriteLine("Asynchronous Task Completed");
        }

        // Auto-Implemented Properties and Expression-bodied Member
        class Person
        {
            public required string FirstName { get; set; }
            public required string LastName { get; set; }
            public string FullName => $"{FirstName} {LastName}";
        }
    }
}
