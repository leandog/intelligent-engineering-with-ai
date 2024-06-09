# Intelligent Engineering with AI

![LeanDog Logo](/Assets/LeanDog-logo.png)

## String Parse Time Kata

## Problem Description

Execution times for a program are outputted in a non-standard parseable time format.

The format is such:

- `f'{amount} {duration type}'`
- amount is a positive integer value
- duration type is an enumeration of weighted values
  - ms : .001
  - sec : 1
  - min : 60
  - hr : 3600
- different duration types are joined together with a space character
- invalid input values equal zero

Create a program, which, given a valid time format, calculates the time in seconds.

**Examples:**

| Input Value               | Expected Result |
| ------------------------- | --------------- |
| '1 ms'                    | .001            |
| '1 sec'                   | 1               |
| '1 min'                   | 60              |
| '1 hr'                    | 3600            |
| '5 sec 421 ms'            | 5.421           |
| '9 min 57 sec'            | 597             |
| '1 hr 33 min'             | 5580            |
| '1 hr 1 min 1 sec 111 ms' | 3661.111        |
| ''                        | 0               |

## Run

Project created using dotnet CLI.

### In the terminal, build and run the project

```bash
dotnet test
```

## TDD Cycle

1. **Red**: Write a failing test case that defines a function or feature.
2. **Green**: Write just enough code to make the test pass.
3. **Refactor**: Clean up the code, ensuring that all tests still pass.

## Tips for Using GitHub Copilot in TDD

- **Generating Test Cases**: Start by writing the test cases. Use prompts to guide Copilot to generate these test cases.
  ```csharp
  // Prompt Copilot to create test cases
  [Fact]
  public void ShouldReturnMillisecondsFor1Ms()
  {
      // Copilot will suggest code here
  }
  ```
- **Implementing Minimal Code**: After your test case is written and fails, use Copilot to suggest minimal code to make the test pass.
  ```csharp
  public double ParseTime(string time)
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
  // Can you generate a method to parse different time formats?
  ```
- **Debugging Help**: Use the chat to get help on debugging issues.
  ```csharp
  // Why is my test failing?
  ```

### Using GitHub Copilot Chat in Visual Studio Code:

1. **Open your project** in Visual Studio Code.
2. **Enable GitHub Copilot Chat**: Make sure you have the GitHub Copilot extension installed and enabled.
3. **Start a new chat session**: Use the GitHub Copilot Chat panel to ask questions or request code snippets.

### Example Copilot Chat Prompts:

- "Explain how this code parses time strings."
- "Generate a method to convert '1 hr 33 min' into seconds."
- "Why am I getting a format exception in my test?"

## Potential Questions to Ask Tyler Morgan

- **Starting with TDD**: "How should I start TDD for the String Parse Time problem?"
- **Writing Initial Tests**: "What are some good initial test cases for the String Parse Time problem?"
- **Using AI Tools**: "How can I effectively use GitHub Copilot to assist with writing tests for String Parse Time?"
- **Handling Edge Cases**: "What are some edge cases I should consider when writing tests for String Parse Time?"
- **Refactoring Tips**: "How can I refactor my String Parse Time code to ensure it's clean and maintainable?"
