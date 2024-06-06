# Intelligent Engineering with AI

![LeanDog Logo](/Assets/LeanDog-logo.png)

## C# - Hello World

This project demonstrates the basic syntax and features of the C# programming language. The `Hello, World!` example is extended to include various types, conditionals, loops, collections, LINQ, exception handling, asynchronous programming, and syntax sugar features.

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Running the Project

This project is created using the dotnet CLI. Follow the steps below to build and run the C# file in your terminal:

```bash
~ cd HelloWorld
~ dotnet run
```

### Code Overview

Below is a detailed explanation of the features and syntax used in the `Program.cs` file:

#### Basic Output

The `Console.WriteLine` method is used to print text to the console.

```csharp
Console.WriteLine("Hello, World!");
```

#### Value Types

C# has several primitive value types, including `bool`, `byte`, `char`, `decimal`, `double`, `float`, `int`, and `long`.

```csharp
bool isActive = true;
byte byteValue = 255;
char charValue = 'A';
decimal decimalValue = 10.5m;
double doubleValue = 10.5;
float floatValue = 10.5f;
int intValue = 10;
long longValue = 100000L;
```

#### Reference Types

C# also supports reference types such as `object`, `string`, and `dynamic`.

```csharp
object obj = new object();
string str = "Hello";
dynamic dyn = "Dynamic typing";
```

#### Implicit vs Explicit Typing

You can declare variables using implicit (`var`) or explicit types.

```csharp
var i = 10; // Implicitly typed.
int x = 10; // Explicitly typed.
Console.WriteLine($"i={i}, x={x}");
```

#### Conditionals

Conditional statements in C# use `if`, `else if`, and `else`.

```csharp
var isTrue = false;
if (isTrue)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}
```

#### Collections: Arrays, Lists, and Dictionaries

C# supports various collection types, such as arrays, lists, and dictionaries.

```csharp
string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
var optionList = new List<string> { "Option1", "Option2" };
var cities = new Dictionary<string, string>
{
    { "UK", "London, Manchester, Birmingham" },
    { "USA", "Chicago, New York, Washington" },
    { "India", "Mumbai, New Delhi, Pune" }
};
```

#### Loops

You can iterate over collections using loops like `foreach`.

```csharp
foreach (var kvp in cities)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}
```

#### Classes and Objects

Classes in C# are used to create objects with properties and methods.

```csharp
var helloWorld = new HelloWorld { Name = "Grogu" };
Console.WriteLine(helloWorld.Greeting());
```
