# Intelligent Engineering with AI

![LeanDog Logo](/Assets/LeanDog-logo.png)

## Gilded Rose Kata

Welcome to the Gilded Rose Kata, part of the **Intelligent Engineering with AI** course. This exercise will help you practice refactoring and applying Test Driven Development (TDD) principles.

### Overview

The Gilded Rose Kata is a classic code kata for practicing refactoring skills. It involves a small inn with a prime location in a prominent city run by a friendly innkeeper named Allison. The inn sells only the finest goods, but unfortunately, the goods degrade in quality as they approach their sell-by date. Your task is to add a new feature to this existing system.

### Gilded Rose Requirements Specification

[Detailed requirements can be found here](https://github.com/emilybache/GildedRose-Refactoring-Kata).

Hi and welcome to team Gilded Rose. As you know, we are a small inn with a prime location in a
prominent city ran by a friendly innkeeper named Allison. We also buy and sell only the finest goods.
Unfortunately, our goods are constantly degrading in quality as they approach their sell by date. We
have a system in place that updates our inventory for us. It was developed by a no-nonsense type named
Leeroy, who has moved on to new adventures. Your task is to add the new feature to our system so that
we can begin selling a new category of items. First an introduction to our system:

- All items have a SellIn value which denotes the number of days we have to sell the item
- All items have a Quality value which denotes how valuable the item is
- At the end of each day our system lowers both values for every item

Pretty simple, right? Well this is where it gets interesting:

- Once the sell by date has passed, Quality degrades twice as fast
- The Quality of an item is never negative
- "Aged Brie" actually increases in Quality the older it gets
- The Quality of an item is never more than 50
- "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
- "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
  - Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
  - Quality drops to 0 after the concert

We have recently signed a supplier of conjured items. This requires an update to our system:

- "Conjured" items degrade in Quality twice as fast as normal items

Feel free to make any changes to the UpdateQuality method and add any new code as long as everything
still works correctly. However, do not alter the Item class or Items property as those belong to the
goblin in the corner who will insta-rage and one-shot you as he doesn't believe in shared code
ownership (you can make the UpdateQuality method and Items property static if you like, we'll cover
for you).

Just for clarification, an item can never have its Quality increase above 50, however "Sulfuras" is a
legendary item and as such its Quality is 80 and it never alters.

### Running the Project

The project is created using the dotnet CLI. Use the following command to build and run the tests:

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

### Boy Scout Rule

Always leave the code base cleaner than you found it. This involves small, incremental improvements and fixes to improve code quality over time.

### Make the Change Easy, Then Make the Easy Change

Before making a significant change, refactor the code to make the upcoming change easier. This often involves improving the structure, readability, and test coverage of the existing code.

### Tips for Using GitHub Copilot in TDD

- **Generating Test Cases**: Start by writing the test cases. Use prompts to guide Copilot to generate these test cases for the Gilded Rose rules.
  ```csharp
  // Prompt Copilot to create test cases for Gilded Rose
  [Fact]
  public void AgedBrieIncreasesInQualityOverTime()
  {
      // Copilot will suggest code here
  }
  ```
- **Implementing Minimal Code**: After your test case is written and fails, use Copilot to suggest minimal code to make the test pass.
  ```csharp
  public void UpdateQuality()
  {
      // Copilot will suggest implementation
  }
  ```
- **Refactoring with Copilot**: Use Copilot to assist in refactoring the code to improve quality while keeping all tests green.

### Tips for Using GitHub Copilot Chat Plugin in Visual Studio Code

- **Asking for Explanations**: If you are unsure about a particular piece of code, ask Copilot Chat to explain it.
  ```csharp
  // What does this method do in the Gilded Rose code?
  ```
- **Generating Code Snippets**: Request specific code snippets or solutions.
  ```csharp
  // Can you generate a method to handle the quality increase for Aged Brie?
  ```
- **Debugging Help**: Use the chat to get help on debugging issues.
  ```csharp
  // Why is my test for Backstage passes failing?
  ```

#### Using GitHub Copilot Chat in Visual Studio Code

1. **Open your project** in Visual Studio Code.
2. **Enable GitHub Copilot Chat**: Make sure you have the GitHub Copilot extension installed and enabled.
3. **Start a new chat session**: Use the GitHub Copilot Chat panel to ask questions or request code snippets.

#### Example Copilot Chat Prompts

- "Explain how the `UpdateQuality` method works in the Gilded Rose Kata."
- "Generate a method to handle the quality degradation for Conjured items."
- "Why is my test for `Sulfuras` failing?"

### Potential Questions to Ask Tyler Morgan

- **Starting with TDD**: "How should I start TDD for the Gilded Rose Kata problem?"
- **Writing Initial Tests**: "What are some good initial test cases for the Gilded Rose Kata problem?"
- **Using AI Tools**: "How can I effectively use GitHub Copilot to assist with writing tests for the Gilded Rose Kata?"
- **Handling Edge Cases**: "What are some edge cases I should consider when writing tests for the Gilded Rose Kata?"
- **Refactoring Tips**: "How can I refactor my Gilded Rose Kata code to ensure it's clean and maintainable?"
