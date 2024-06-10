# Intelligent Engineering with AI

![LeanDog Logo](/Assets/LeanDog-logo.png)

## Bowling Kata

### Problem Description

Create a program, which, given a valid sequence of rolls for one line of American Ten-Pin Bowling, produces the total score for the game. Here are some things that the program will not do:

- We will not check for valid rolls.
- We will not check for the correct number of rolls and frames.
- We will not provide scores for intermediate frames.

Depending on the application, this might or might not be a valid way to define a complete story, but we do it here for the purposes of keeping the kata light. I think you’ll see that improvements like those above would go in readily if they were needed for real.

We can briefly summarize the scoring for this form of bowling:

- Each game, or “line” of bowling, includes ten turns, or “frames” for the bowler.
- In each frame, the bowler gets up to two tries to knock down all the pins.
- If in two tries, they fail to knock them all down, the score for that frame is the total number of pins knocked down in their two tries.
- If in two tries they knock them all down, this is called a “spare” and the score for the frame is ten plus the number of pins knocked down on their next throw (in their next turn).
- If on the first try in the frame they knock down all the pins, this is called a “strike”. Their turn is over, and the score for the frame is ten plus the simple total of the pins knocked down in their next two rolls.
- If they get a spare or strike in the last (tenth) frame, the bowler gets to throw one or two more bonus balls, respectively. These bonus throws are taken as part of the same turn. If the bonus throws knock down all the pins, the process does not repeat: the bonus throws are only used to calculate the score of the final frame.
- The game score is the total of all frame scores.

More info on the rules at: [How to Score for Bowling](https://www.topendsports.com/sport/tenpin/scoring.htm)

### Clues

What makes this game interesting to score is the lookahead in the scoring for strikes and spares. At the time we throw a strike or spare, we cannot calculate the frame score: we have to wait one or two frames to find out what the bonus is.

### Suggested Test Cases

_(When scoring, “X” indicates a strike, “/” indicates a spare, “-” indicates a miss)_

- `X X X X X X X X X X X X` (12 rolls: 12 strikes) = 10 frames \* 30 points = 300
- `9- 9- 9- 9- 9- 9- 9- 9- 9- 9-` (20 rolls: 10 pairs of 9 and miss) = 10 frames \* 9 points = 90
- `5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5` (21 rolls: 10 pairs of 5 and spare, with a final 5) = 10 frames \* 15 points = 150

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
  public void ShouldReturnPerfectScoreForAllStrikes()
  {
      // Copilot will suggest code here
  }
  ```
- **Implementing Minimal Code**: After your test case is written and fails, use Copilot to suggest minimal code to make the test pass.
  ```csharp
  public int CalculateScore(string rolls)
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
  // Can you generate a method to calculate the score for a sequence of rolls?
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

- "Explain how this code calculates the score for a bowling game."
- "Generate a method to handle spares in a bowling game."
- "Why am I getting an incorrect score for my bowling game?"

### Potential Questions to Ask Tyler Morgan

- **Starting with TDD**: "How should I start TDD for the Bowling Kata problem?"
- **Writing Initial Tests**: "What are some good initial test cases for the Bowling Kata problem?"
- **Using AI Tools**: "How can I effectively use GitHub Copilot to assist with writing tests for the Bowling Kata?"
- **Handling Edge Cases**: "What are some edge cases I should consider when writing tests for the Bowling Kata?"
- **Refactoring Tips**: "How can I refactor my Bowling Kata code to ensure it's clean and maintainable?"
