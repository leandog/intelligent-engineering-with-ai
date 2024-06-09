# Intelligent Engineering with AI

![LeanDog Logo](/Assets/LeanDog-logo.png)

## Fizz Buzz Kata

[Fizz Buzz: Coding Dojo](http://codingdojo.org/kata/FizzBuzz)

### Problem Description

Write a program that returns a list of numbers and strings from 1 to n, where n is the upper bound.

- For multiples of three, return “Fizz” instead of the number
- For multiples of five, return “Buzz”
- For numbers which are multiples of both three and five, return “FizzBuzz“
- Otherwise, return the ordinal number

**Upper bound**: 15  
**Example output**: ['1', '2', 'Fizz', '4', 'Buzz', 'Fizz', '7', '8', 'Fizz', 'Buzz', '11', 'Fizz', '13', '14', 'FizzBuzz']

### Run

Project created using dotnet CLI.

### In the terminal, build and run the project

```bash
dotnet test
```

### TDD Cycle

1. **Red**: Write a failing test case that defines a function or feature.
2. **Green**: Write just enough code to make the test pass.
3. **Refactor**: Clean up the code, ensuring that all tests still pass.

### Tips for Using GitHub Copilot in TDD

- **Generating Test Cases**: Start by writing the test cases. Use prompts to guide Copilot to generate these test cases.
  ```csharp
  // Prompt Copilot to create test cases
  [Fact]
  public void ShouldReturnFizzForMultiplesOf3()
  {
      // Copilot will suggest code here
  }
  ```
- **Implementing Minimal Code**: After your test case is written and fails, use Copilot to suggest minimal code to make the test pass.
  ```csharp
  public string FizzBuzz(int number)
  {
      // Copilot will suggest implementation
  }
  ```
- **Refactoring with Copilot**: Use Copilot to assist in refactoring the code to improve quality while keeping all tests green.

## Tips for Using GitHub Copilot Chat Plugin in Visual Studio Code

- **Asking for Explanations**: If you are unsure about a particular piece of code, ask Copilot Chat to explain it.
  ```csharp
  // What does this method do?
  ```
- **Generating Code Snippets**: Request specific code snippets or solutions.
  ```csharp
  // Can you generate a method to check for multiples of 3 and 5?
  ```
- **Debugging Help**: Use the chat to get help on debugging issues.
  ```csharp
  // Why is my test failing?
  ```

#### Using GitHub Copilot Chat in Visual Studio Code:

1. **Open your project** in Visual Studio Code.
2. **Enable GitHub Copilot Chat**: Make sure you have the GitHub Copilot extension installed and enabled.
3. **Start a new chat session**: Use the GitHub Copilot Chat panel to ask questions or request code snippets.

#### Example Copilot Chat Prompts:

- "Explain how this code handles multiples of 3 and 5."
- "Generate a method to convert numbers into FizzBuzz format."
- "Why is my test for multiples of 3 failing?"

### Potential Questions to Ask Tyler Morgan

- **Starting with TDD**: "How should I start TDD for the FizzBuzz problem?"
- **Writing Initial Tests**: "What are some good initial test cases for the FizzBuzz problem?"
- **Using AI Tools**: "How can I effectively use GitHub Copilot to assist with writing tests for FizzBuzz?"
- **Handling Edge Cases**: "What are some edge cases I should consider when writing tests for FizzBuzz?"
- **Refactoring Tips**: "How can I refactor my FizzBuzz code to ensure it's clean and maintainable?"
