# Detailed Course Outline: Intelligent Engineering with AI

![LeanDog Logo](Assets/LeanDog-logo.png)

## Module 1: Traditional Test Driven Development (TDD) with AI Integration

### Day 1: Morning Session

This detailed morning session ensures participants are introduced to TDD in a practical, hands-on manner while also learning to leverage AI tools effectively and understanding crucial software craftsmanship principles, extreme programming practices, and innovative problem-solving techniques like ZOMBIE testing.

**Welcome and Introductions (30 minutes)**

1. **Brief Introduction by the Instructor**

   - Overview of the course and its objectives.
   - Emphasize the importance of TDD, AI integration, and software craftsmanship.

2. **Participant Introductions**
   - Participants share their backgrounds, experience with TDD, and familiarity with AI tools like GitHub Copilot and ChatGPT.
   - Discuss previous experimentation with AI in coding.

**Introducing Tyler Morgan, the Intelligent Engineering Course Assistant (10 minutes)**

1. **Overview of Tyler Morgan’s Role**

   - Assisting with course material and providing expert advice on software engineering and agile practices.
   - Leveraging AI tools like ChatGPT to enhance learning and productivity.

2. **Demonstration of Tyler’s Assistance Capabilities**
   - Providing explanations and suggestions.
   - Answering questions related to TDD, software craftsmanship, and AI integration.

**Course Objectives and Structure (10 minutes)**

1. **Overview of Course Modules and Learning Outcomes**

   - Introduction to TDD and AI tools.
   - Emphasis on practical exercises and hands-on learning.
   - Continuous integration of AI tools into the development workflow.

2. **Explanation of the Role of AI in Modern Software Engineering**
   - How AI tools can assist in coding, testing, and documentation.
   - Benefits of integrating AI into traditional software engineering practices.

**Introduction to TDD with Fizz Buzz Kata (10 minutes)**

1. **Overview of the Fizz Buzz Problem**

   - Write a program that prints numbers from 1 to 100.
   - For multiples of three, print "Fizz" instead of the number.
   - For multiples of five, print "Buzz".
   - For numbers which are multiples of both three and five, print "FizzBuzz".

2. **Introduction to the TDD Cycle: Red, Green, Refactor**

   - Red: Write a failing test.
   - Green: Make the test pass.
   - Refactor: Improve the code while ensuring all tests still pass.

3. **Explanation of How AI Tools like GitHub Copilot Can Assist in the Process**
   - Generating initial test cases.
   - Writing minimal code to pass tests.
   - Assisting in refactoring for better code quality.

**Practical Exercise: Fizz Buzz Kata (String Parse Time) with TDD and AI Tools (1 hour 30 minutes)**

1. **Step-by-Step Guide:**

   **Step 1: Write the First Test (Red)**

   - **Instructor Demonstration (15 minutes):**
     - Use GitHub Copilot to generate an initial test case for the Fizz Buzz problem.
     - Example Test Case: Ensure the number 1 prints "1".
     - Discuss how to verify the generated code and ensure it aligns with TDD principles.

   **Step 2: Make the Test Pass (Green)**

   - **Instructor Demonstration (10 minutes):**
     - Use Copilot to generate the minimal code needed to pass the test.
     - Discuss the manual verification of the code's correctness.

   **Step 3: Refactor**

   - **Instructor Demonstration (10 minutes):**
     - Refactor the code with the assistance of Copilot to improve readability and maintainability.
     - Ensure the test still passes after refactoring.

   **Step 4: Repeat the Cycle**

   - **Instructor Demonstration (10 minutes):**
     - Add additional test cases and iterate through the TDD cycle.
     - Example Test Cases: Ensure numbers divisible by 3 print "Fizz", numbers divisible by 5 print "Buzz", and numbers divisible by both print "FizzBuzz".

2. **Using ChatGPT as an Assistant (15 minutes)**

   - **Instructor Demonstration:**
     - Show how ChatGPT can provide explanations and suggestions during the TDD process.
     - Example: Ask ChatGPT to explain the difference between Mocks and Stubs or suggest ways to refactor code.

3. **Hands-On Practice: Pair Programming Exercise (30 minutes)**
   - Participants work in pairs to implement the Fizz Buzz kata using TDD and GitHub Copilot.
   - Instructors provide guidance and support, ensuring adherence to TDD practices.
   - Encourage participants to use ChatGPT to clarify doubts and get suggestions.

**Additional Topics: Software Craftsmanship and Extreme Programming (1 hour)**

1. **Introduction to Software Craftsmanship (15 minutes)**

   - Overview of software craftsmanship principles.
   - Importance of clean code and continuous improvement.
   - Introduction to the SOLID principles:
     - **Single Responsibility Principle**
     - **Open/Closed Principle**
     - **Liskov Substitution Principle**
     - **Interface Segregation Principle**
     - **Dependency Inversion Principle**.

2. **Extreme Programming (XP) Overview (15 minutes)**

   - Values of Extreme Programming: Communication, Simplicity, Feedback, Courage, Respect.
   - Core practices: Pair programming, continuous integration, small releases, simple design, and system metaphor.

3. **ZOMBIE Testing Technique (15 minutes)**

   - **Introduction to ZOMBIE Testing:**
     - **Z**: Zero - What happens if there are zero of a thing?
     - **O**: One - What happens when there is exactly one of a thing?
     - **M**: Many - What happens when there are more than one thing?
     - **B**: Boundaries - Are there special boundary values for the thing?
     - **I**: Interfaces - Are there common interfaces with expectations?
     - **E**: Exceptions/Errors - What cases cause errors? Exactly what should they do?
   - **Practical Exercise:**
     - Apply the ZOMBIE testing technique to a simple problem, discussing how to use this approach to identify edge cases and potential issues.

4. **Fake it till you make it**

Start with the simplest solution that could possibly work, even if it is just hardcoding the answer. Gradually replace hardcoded parts with real logic as more tests are added and pass.

5. **DRY - Don't Repeat Yourself**

Avoid duplication. Each piece of knowledge must have a single, unambiguous, authoritative representation within a system.

6. **YAGNI**

Implement only what is necessary. Don’t add functionality until it is deemed necessary.

7. **Fake it till you make it**

**Wrap-Up and Q&A (15 minutes)**

1. **Summarize Key Takeaways from the Morning Session**

   - Emphasize the importance of TDD, AI tools, and software craftsmanship principles.
   - Encourage continuous practice and improvement.

2. **Open Floor for Questions and Discussions**

   - Address any challenges faced by participants.
   - Provide solutions and additional resources as needed.

3. **Preview of the Afternoon Session**
   - Focus on the Roman Numeral Calculator kata.
   - Introduction to refactoring techniques and the Bowling kata.

### Day 1: Afternoon Session

This detailed afternoon session ensures participants build on their TDD skills while integrating AI tools effectively, practicing refactoring techniques, and tackling more complex problems like the Bowling Kata and Roman Numeral Calculator. This session includes an introduction to clean code concepts, ensuring participants learn to write clean, maintainable code while practicing TDD and integrating AI tools.

**Overview of AI Tools and Current Capabilities (30 minutes)**

1. **Introduction to AI Tools (15 minutes)**

   - Overview of GitHub Copilot and ChatGPT.
   - Discuss how these tools can assist in coding, testing, and documentation.
   - Provide a GitHub Copilot cheat sheet with common commands and tips.

2. **Current Capabilities and Limitations (15 minutes)**
   - Strengths of AI tools in accelerating development and enhancing productivity.
   - Limitations and potential pitfalls to be aware of.
   - Best practices for integrating AI tools into the development workflow.

**Introduction to the Bowling Kata (10 minutes)**

1. **Overview of the Problem**

   - Problem statement: Calculate the score of a bowling game considering strikes and spares.
   - Importance of the problem for practicing TDD and AI integration.

2. **TDD Approach for the Bowling Kata**
   - Applying the TDD cycle: Red, Green, Refactor.
   - Example scenarios and edge cases to consider.

**Practical Exercise: Bowling Kata with TDD and AI Tools (1 hour)**

3. **Step-by-Step Guide:**

   **Step 1: Write the First Test (Red)**

   - **Instructor Demonstration (10 minutes):**
     - Use GitHub Copilot to generate initial test cases for the Bowling Kata problem.
     - Discuss how to verify the generated code and ensure it aligns with TDD principles.

   **Step 2: Make the Test Pass (Green)**

   - **Instructor Demonstration (10 minutes):**
     - Use Copilot to generate the minimal code needed to pass the test.
     - Discuss the manual verification of the code's correctness.

   **Step 3: Refactor**

   - **Instructor Demonstration (10 minutes):**
     - Refactor the code with the assistance of Copilot to improve readability and maintainability.
     - Ensure the test still passes after refactoring.

   **Step 4: Repeat the Cycle**

   - **Instructor Demonstration (10 minutes):**
     - Add additional test cases and iterate through the TDD cycle.
     - Example Test Cases: Ensure various bowling game scenarios produce correct results.

4. **Using ChatGPT as an Assistant (10 minutes)**

   - **Instructor Demonstration:**
     - Show how ChatGPT can provide explanations and suggestions during the TDD process.
     - Example: Ask ChatGPT to suggest additional test cases or help debug issues.

5. **Hands-On Practice: Pair Programming Exercise (15 minutes)**
   - Participants work in pairs to implement the Bowling Kata using TDD and GitHub Copilot.
   - Instructors provide guidance and support, ensuring adherence to TDD practices.
   - Encourage participants to use ChatGPT to clarify doubts and get suggestions.

**Introduction to the Roman Numeral Calculator Kata (10 minutes)**

1. **Overview of the Problem**

   - Problem statement: Write a program that converts Roman numerals to integers and vice versa.
   - Importance of the problem for practicing TDD and AI integration.

2. **TDD Approach for the Roman Numeral Calculator**
   - Applying the TDD cycle: Red, Green, Refactor.
   - Example scenarios and edge cases to consider.

**Practical Exercise: Roman Numeral Calculator Kata with TDD and AI Tools (1 hour)**

3. **Step-by-Step Guide:**

   **Step 1: Analyze Existing Code (10 minutes)**

   - **Instructor Demonstration:**
     - Review any existing code for the Roman Numeral Calculator.
     - Identify areas for improvement and potential refactoring opportunities.

   **Step 2: Write the First Test (Red)**

   - **Instructor Demonstration (15 minutes):**
     - Use GitHub Copilot to generate initial test cases for converting Roman numerals to integers.
     - Discuss how to verify the generated code and ensure it aligns with TDD principles.

   **Step 3: Make the Test Pass (Green)**

   - **Instructor Demonstration (10 minutes):**
     - Use Copilot to generate the minimal code needed to pass the test.
     - Discuss the manual verification of the code's correctness.

   **Step 4: Refactor**

   - **Instructor Demonstration (10 minutes):**
     - Refactor the code with the assistance of Copilot to improve readability and maintainability.
     - Ensure the test still passes after refactoring.

   **Step 5: Add New Features and Tests**

   - **Instructor Demonstration (15 minutes):**
     - Add new features to the Roman Numeral Calculator while ensuring all tests pass.
     - Use the TDD cycle: Red, Green, Refactor for each new feature.

4. **Using ChatGPT as an Assistant (10 minutes)**

   - **Instructor Demonstration:**
     - Show how ChatGPT can provide explanations and suggestions during the TDD process.
     - Example: Ask ChatGPT to suggest additional test cases or help debug issues.

5. **Hands-On Practice: Pair Programming Exercise (15 minutes)**
   - Participants work in pairs to implement the Roman Numeral Calculator kata using TDD and GitHub Copilot.
   - Instructors provide guidance and support, ensuring adherence to TDD practices.
   - Encourage participants to use ChatGPT to clarify doubts and get suggestions.

**Refactoring Techniques and Clean Code Concepts (1 hour)**

6. **Introduction to Refactoring and Clean Code (15 minutes)**
   - Overview of refactoring principles and techniques.
   - Introduction to clean code principles:
     - Meaningful names.
     - Small functions.
     - Avoiding duplication.
     - Writing code that expresses intent.

**Practical Exercise: Refactoring with AI Tools (45 minutes)**

7. **Step-by-Step Guide:**

   **Step 1: Identify Code Smells (10 minutes)**

   - **Instructor Demonstration:**
     - Use AI tools to identify code smells in the Roman Numeral Calculator codebase.
     - Discuss the significance of each identified issue.

   **Step 2: Refactor the Code (15 minutes)**

   - **Instructor Demonstration:**
     - Use AI tools to assist in refactoring the code.
     - Manually verify and improve the AI-suggested refactorings.

   **Step 3: Apply Clean Code Principles (20 minutes)**

   - **Instructor Demonstration:**
     - Refactor the codebase to adhere to clean code principles.
     - Examples of renaming variables, breaking down large functions, and removing duplication.

8. **Hands-On Practice: Pair Programming Exercise (15 minutes)**
   - Participants work in pairs to refactor a provided codebase using AI tools and clean code principles.
   - Instructors provide guidance and support, ensuring best practices are followed.

**Wrap-Up and Q&A (15 minutes)**

1. **Summarize Key Takeaways from the Afternoon Session**

   - Emphasize the importance of TDD, AI tools, refactoring, and clean code principles.
   - Encourage continuous practice and improvement.

2. **Open Floor for Questions and Discussions**

   - Address any challenges faced by participants.
   - Provide solutions and additional resources as needed.

3. **Preview of Day 2**
   - Focus on advanced TDD techniques and continuous integration.
   - Introduction to the Gilded Rose Kata and building an API application.

## Module 2: Advanced TDD and Software Craftsmanship with AI Integration

### Day 2: Morning Session

This detailed morning session ensures participants build upon their knowledge from Day 1 while introducing new concepts like the Gilded Rose kata, code smells, and design patterns.

**Recap and Introduction (30 minutes)**

1. **Recap of Day 1 (15 minutes)**

   - Brief overview of key concepts covered:
     - TDD cycle: Red, Green, Refactor
     - Fizz Buzz Kata, Roman Numeral Calculator Kata, Bowling Kata
     - Refactoring techniques, clean code principles, and design patterns
     - Integration of AI tools like GitHub Copilot and ChatGPT
   - Discuss key takeaways and address any questions from Day 1.

2. **Overview of Day 2 Objectives (15 minutes)**
   - Outline the focus areas for the morning session:
     - Gilded Rose Kata as the main hands-on exercise
     - Identifying and addressing code smells
     - Applying design patterns
     - Using AI tools effectively

**The Boy Scout Rule and "Make the Change Easy, Then Make the Easy Change" (15 minutes)**

3. **Introduction to the Boy Scout Rule (7 minutes)**

   - **Objective**: Emphasize the importance of continuous improvement in code quality.
   - **Concept**:
     - The Boy Scout Rule: "Always leave the code cleaner than you found it."
     - Importance of small, incremental improvements to prevent code decay.
   - **Discussion**:
     - Examples of applying the Boy Scout Rule in daily coding practices.
     - Benefits of consistent, small refactorings over time.

4. **Introduction to "Make the Change Easy, Then Make the Easy Change" (8 minutes)**
   - **Objective**: Understand the two-step approach to effective refactoring and feature addition.
   - **Concept**:
     - "Make the Change Easy": Refactor the code to make it easier to implement changes.
     - "Then Make the Easy Change": Implement the actual change after preparing the code.
   - **Discussion**:
     - Examples of breaking down complex changes into manageable steps.
     - How this approach minimizes risks and improves code maintainability.

**Gilded Rose Kata with TDD and AI Tools (2 hours)**

5. **Introduction to the Gilded Rose Kata (15 minutes)**
   - Overview of the Gilded Rose problem:
     - Maintain and refactor a piece of legacy code while adding new features.
     - Emphasis on understanding and improving existing code without breaking it.
   - Importance of this kata for practicing TDD and refactoring techniques.

**Practical Exercise: Gilded Rose Kata with TDD and AI Tools**

6. **Step-by-Step Guide:**

   **Step 1: Analyze Existing Code (15 minutes)**

   - **Instructor Demonstration**:
     - Review the current state of the Gilded Rose codebase.
     - Identify areas that need improvement and potential refactoring opportunities.
   - **Discussion**:
     - Highlight the importance of understanding legacy code before making changes.

   **Step 2: Write the First Test (Red)**

   - **Instructor Demonstration (20 minutes)**:
     - Use GitHub Copilot to generate initial test cases for the existing functionality.
     - Discuss how to verify the generated code and ensure it aligns with TDD principles.

   **Step 3: Make the Test Pass (Green)**

   - **Instructor Demonstration (15 minutes)**:
     - Use Copilot to generate the minimal code needed to pass the test.
     - Discuss the manual verification of the code's correctness.

   **Step 4: Refactor**

   - **Instructor Demonstration (15 minutes)**:
     - Refactor the code with the assistance of Copilot to improve readability and maintainability.
     - Ensure the test still passes after refactoring.

   **Step 5: Add New Features and Tests**

   - **Instructor Demonstration (20 minutes)**:
     - Add new features to the Gilded Rose application while ensuring all tests pass.
     - Use the TDD cycle: Red, Green, Refactor for each new feature.

7. **Using ChatGPT as an Assistant (15 minutes)**

   - **Instructor Demonstration**:
     - Show how ChatGPT can provide explanations and suggestions during the TDD process.
     - Example: Ask ChatGPT to suggest additional test cases or help debug issues.

8. **Hands-On Practice: Pair Programming Exercise (1 hour)**
   - Participants work in pairs to implement the Gilded Rose kata using TDD and GitHub Copilot.
   - Instructors provide guidance and support, ensuring adherence to TDD practices.
   - Encourage participants to use ChatGPT to clarify doubts and get suggestions.

**Code Smells and Design Patterns (1 hour 30 minutes)**

9. **Introduction to Code Smells (15 minutes)**
   - Overview of common code smells:
     - Long methods, large classes, duplicated code, etc.
   - Importance of identifying and addressing code smells for maintainable code.

**Practical Exercise: Identifying Code Smells (15 minutes)**

10. **Step-by-Step Guide:**

    **Step 1: Identify Code Smells in Gilded Rose (15 minutes)**

- **Instructor Demonstration**:
  - Review the Gilded Rose codebase to identify code smells.
  - Discuss each identified issue and its implications.

11. **Introduction to Design Patterns (15 minutes)**

- Overview of common design patterns:
  - Singleton, Factory, Strategy, Observer, etc.
- Importance of using design patterns for scalable and maintainable code.

**Practical Exercise: Applying Design Patterns (15 minutes)**

12. **Step-by-Step Guide:**

    **Step 1: Refactor Gilded Rose using Design Patterns (15 minutes)**

    - **Instructor Demonstration**:
      - Refactor parts of the Gilded Rose codebase using appropriate design patterns.
      - Discuss the benefits and challenges of each pattern.

13. **Hands-On Practice: Pair Programming Exercise (30 minutes)**
    - Participants work in pairs to identify code smells and apply design patterns in the Gilded Rose kata.
    - Instructors provide guidance and support, ensuring best practices are followed.

**Wrap-Up and Q&A (15 minutes)**

1. **Summarize Key Takeaways from the Morning Session**

   - Emphasize the importance of TDD, AI tools, and software craftsmanship principles.
   - Encourage continuous practice and improvement.

2. **Open Floor for Questions and Discussions**

   - Address any challenges faced by participants.
   - Provide solutions and additional resources as needed.

3. **Preview of the Afternoon Session**
   - Focus on prompt engineering, building an API application, and deploying using GitHub Actions and a free cloud provider.

### Day 2: Afternoon Session

This detailed afternoon session ensures participants gain practical experience in prompt engineering, building a simple API application, and deploying it using GitHub Actions and a free cloud provider. It also covers the important concepts of stubs, mocks, fakes, and test doubles, integrating them into the to-do task application.

**Introduction to Prompt Engineering (30 minutes)**

1. **Overview of Prompt Engineering (15 minutes)**

   - Explain the concept of prompt engineering.
   - Importance of crafting effective prompts for AI tools.
   - Examples of effective prompts for different scenarios, including code generation, debugging, and documentation.

2. **Hands-On Exercise: Writing Effective Prompts (15 minutes)**
   - Participants practice writing prompts for various tasks.
   - Use ChatGPT to generate code snippets, debug code, and provide documentation suggestions.
   - Share and discuss results as a group.

**Building a Simple API Application (1 hour 45 minutes)**

1. **Overview of the Application (15 minutes)**

   - Explain the structure and components of an API application.
   - Introduce the to-do task application as the example project.
   - Discuss the use of an in-memory database (SQLite) for simplicity and quick setup.

2. **Setting Up the Project (30 minutes)**

   - **Instructor Demonstration:**
     - Create a new API project.
     - Set up SQLite as the in-memory database.
     - Configure the necessary dependencies and packages.
   - **Hands-On Practice:**
     - Participants follow along to set up their projects.
     - Instructors provide guidance and support.

3. **Developing the To-Do Task Application (45 minutes)**
   - **Instructor Demonstration:**
     - Implement the basic features of the to-do task application:
       - Create, Read, Update, and Delete (CRUD) operations for tasks.
     - Integrate GitHub Copilot to assist in writing code.
   - **Hands-On Practice:**
     - Participants work in pairs to implement the application.
     - Instructors provide guidance and support, ensuring best practices are followed.
     - Encourage participants to use ChatGPT for additional help and suggestions.

**Stubs, Mocks, Fakes, and Doubles (1 hour 30 minutes)**

6. **Introduction to Stubs, Mocks, Fakes, and Doubles (15 minutes)**
   - Explain the differences between stubs, mocks, fakes, and test doubles.
   - Importance of these techniques in TDD and unit testing.

**Practical Exercise: Implementing Stubs, Mocks, Fakes, and Doubles (45 minutes)**

7. **Step-by-Step Guide:**

   **Step 1: Setting Up the Testing Environment (15 minutes)**

   - **Instructor Demonstration:**
     - Configure the project for unit testing.
     - Introduce a testing framework like NUnit or xUnit.
     - Explain how to set up and use mocking frameworks like Moq.

   **Step 2: Creating and Using Stubs and Mocks (15 minutes)**

   - **Instructor Demonstration:**
     - Implement stubs and mocks for the to-do task application.
     - Discuss scenarios where stubs and mocks are beneficial.

   **Step 3: Applying Fakes and Doubles (15 minutes)**

   - **Instructor Demonstration:**
     - Implement fakes and test doubles for specific components.
     - Explain how fakes and doubles can simplify testing in certain situations.

8. **Hands-On Practice: Pair Programming Exercise (30 minutes)**
   - Participants work in pairs to implement stubs, mocks, fakes, and test doubles in their to-do task application.
   - Instructors provide guidance and support, ensuring best practices are followed.
   - Encourage participants to use ChatGPT to clarify doubts and get suggestions.

**Deploying the Application using GitHub Actions and a Free Cloud Provider (30 minutes)**

9. **Introduction to GitHub Actions and Deployment (10 minutes)**

   - Overview of continuous integration with GitHub Actions.
   - Introduction to free cloud providers like Heroku, Vercel, or Netlify.

10. **Hands-On Exercise: Deploying the To-Do Task Application (20 minutes)**
    - **Instructor Demonstration:**
      - Set up GitHub Actions for continuous integration.
      - Configure deployment to a free cloud provider.
    - **Hands-On Practice:**
      - Participants follow along to deploy their applications.
      - Instructors provide guidance and support.

**Wrap-Up and Q&A (15 minutes)**

11. **Summarize Key Takeaways from the Afternoon Session**

    - Emphasize the importance of prompt engineering, continuous integration, and deployment.
    - Encourage participants to continue experimenting with AI tools and deployment practices.

12. **Open Floor for Questions and Discussions**

    - Address any challenges faced by participants.
    - Provide solutions and additional resources as needed.

13. **Conclusion of the Course**
    - Recap key concepts learned over the two days.
    - Encourage participants to apply these concepts in their future projects.
    - Provide additional resources and contact information for further support.
