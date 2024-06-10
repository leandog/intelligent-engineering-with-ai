# Intelligent Engineering with AI

![LeanDog Logo](/Assets/LeanDog-logo.png)

## Roman Calculator Kata

### Problem Description

“As a Roman Bookkeeper, I want to add Roman numbers because doing it manually is too tedious.” Given the Roman numerals (I, V, X, L, C, D, M which represent one, five, ten, fifty, hundred, five hundred, and a thousand respectively), create two numbers and add them. As we are in Rome, there is no such thing as decimals or integers; we need to do this with strings. An example would be “XIV” + “LX” = “LXXIV”.

**Rules for Roman Numerals:**

- Numerals can be concatenated to form a larger numeral (“XX” + “II” = “XXII”).
- If a lesser numeral is put before a bigger one, it means subtraction of the lesser from the bigger (“IV” means four, “CM” means nine hundred).
- If the numeral is I, X, or C, you can’t have more than three in a row (“IIII” is invalid).
- If the numeral is V, L, or D, you can’t have more than one in a row (“VV” is invalid).

**Clues**

String grouping and concatenation is key to solving this kata. But remember the rule that lesser numerals can precede bigger ones.

### Suggested Test Cases

Here are some test cases to consider:

- `I + I = II`
- `X + V = XV`
- `IX + II = XI`
- `XL + XL = LXXX`
- `C + D = D`

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

### Fake it till you make it

Start with the simplest solution that could possibly work, even if it is just hardcoding the answer. Gradually replace hardcoded parts with real logic as more tests are added and pass.

### ZOMBIES

Use the ZOMBIES acronym to guide your test cases:

- **Z: Zero** - What happens if there are zero of a thing?
- **O: One** - What happens when there is exactly one of a thing?
- **M: Many** - What happens when there are more than one thing?
- **B: Boundaries** - Are there special boundary values for the thing?
- **I: Interfaces** - Are there common interfaces with expectations?
- **E: Exceptions/Errors** - What cases cause errors? Exactly what should they do?

### SOLID Principles

Follow the SOLID principles to create maintainable and scalable code:

- **S: Single Responsibility Principle** - A class should have one and only one reason to change.
- **O: Open/Closed Principle** - Software entities should be open for extension, but closed for modification.
- **L: Liskov Substitution Principle** - Objects of a superclass should be replaceable with objects of its subclasses without breaking the application.
- **I: Interface Segregation Principle** - No client should be forced to depend on methods it does not use.
- **D: Dependency Inversion Principle** - High-level modules should not depend on low-level modules. Both should depend on abstractions.

### DRY - Don't Repeat Yourself

Avoid duplication. Each piece of knowledge must have a single, unambiguous, authoritative representation within a system.

### YAGNI - You Ain't Gonna Need It

Implement only what is necessary. Don’t add functionality until it is deemed necessary.

### Tips for Using GitHub Copilot in TDD

- **Generating Test Cases**: Start by writing the test cases. Use prompts to guide Copilot to generate these test cases.
  ```csharp
  // Prompt Copilot to create test cases
  [Fact]
  public void ShouldReturnCorrectSumForRomanNumerals()
  {
      // Copilot will suggest code here
  }
  ```
- **Implementing Minimal Code**: After your test case is written and fails, use Copilot to suggest minimal code to make the test pass.
  ```csharp
  public string AddRomanNumerals(string numeral1, string numeral2)
  {
      // Copilot will suggest implementation
  }
  ```
- **Refactoring with Copilot**: Use Copilot to assist in refactoring the code to improve quality while keeping all tests green.

### Tips for Using GitHub Copilot Chat Plugin in Visual Studio Code

- **Asking for Explanations**: If you are unsure about a particular piece of code, ask Copilot Chat to explain it.
  ```csharp
  // What does this method do?
  ```
- **Generating Code Snippets**: Request specific code snippets or solutions.
  ```csharp
  // Can you generate a method to add two Roman numerals?
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

- "Explain how this code adds two Roman numerals."
- "Generate a method to handle subtraction rules in Roman numerals."
- "Why am I getting an incorrect sum for my Roman numeral addition?"

### Potential Questions to Ask Tyler Morgan

- **Starting with TDD**: "How should I start TDD for the Roman Calculator problem?"
- **Writing Initial Tests**: "What are some good initial test cases for the Roman Calculator problem?"
- **Using AI Tools**: "How can I effectively use GitHub Copilot to assist with writing tests for the Roman Calculator?"
- **Handling Edge Cases**: "What are some edge cases I should consider when writing tests for the Roman Calculator?"
- **Refactoring Tips**: "How can I refactor my Roman Calculator code to ensure it's clean and maintainable?"
