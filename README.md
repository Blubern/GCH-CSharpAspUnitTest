# **GCH-CSharpAspUnitTest**

- [**GCH-CSharpAspUnitTest introduction**](#GCH-CSharpAspUnitTest-introduction)
- [**General prerequisites**](#General-prerequisites)
- [**How to Use GitHub Copilot**](#How-to-Use-GitHub-Copilot)
- [**Create a new Blazor Web App**](#Create-a-new-Blazor-Web-App)
- [**Challenge 0 - Check if your Copilot is running and play with him**](#Challenge-0---Check-if-your-Copilot-is-running-and-play-with-him)
- [**Challenge 1 - Create a new Page with a Todo List**](#Challenge-1---Create-a-new-Page-with-a-Todo-List)
- [**Challenge 2 - Add legacy code / fix it / add more data**](#Challenge-2---Add-legacy-code-/-fix-it-/-add-more-data)
- [**Challenge 3 - Add some UnitTests / Refactoring**](#Challenge-3---Add-some-UnitTests-/-Refactoring)
- [**Challenge 4 - Convert Phyton code into C# Code**](#Challenge-4---Convert-Phyton-code-into-C#-Code)
- [**Finish**](#Finish)
- [**Solutions / Inspiration - Spoiler-warning**](#-Solutions-/-Inspiration---Spoiler-warning)

### GCH-CSharpAspUnitTest introduction

Welcome to our GitHub Copilot repository for the Business Hackathon with .NET Web Technologies (C# ASP.NET / Blazor and Unittests)! This repository is dedicated to helping participants get familiar with GitHub Copilot by leveraging its capabilities as an assistant or even a pair programmer.

### General prerequisites

To get started, you need:

- Visual Studio 2022 version 17.8 or later
- Active subscription to GitHub Copilot for Business
- GitHub Copilot in Visual Studio [Documentation](https://learn.microsoft.com/en-us/visualstudio/ide/visual-studio-github-copilot-install-and-states?view=vs-2022)
- GitHub Copilot Chat in Visual Studio [Documentation](https://learn.microsoft.com/en-us/visualstudio/ide/visual-studio-github-copilot-install-and-states?view=vs-2022)
- Sign in to Visual Studio with the GitHub account that has an active GitHub Copilot subscription

### How to Use GitHub Copilot

GitHub Copilot is not just a tool! It's your coding companion throughout this hackathon. Treat Copilot as your virtual pair programmer, ready to assist you in completing tasks efficiently and creatively.

#### Guidelines for Effective Usage
1. Think Like a Team: Consider Copilot as your team member. The more context you provide in your prompts, the better Copilot can assist you.
2. Clear and Concise Prompts: When interacting with Copilot, be clear and concise in your prompts. Clearly articulate what you want to achieve, and Copilot will help you achieve it.
3. Be Creative: Don't hesitate to be creative with your prompts. The key is to explore the capabilities of Copilot and learn how to leverage them effectively.
4. Iterate and Improve: As you work with Copilot, iterate on your prompts and interactions. Learn from each experience and refine your approach for better results.

### More Information about Github Copilot, Github Copilot Chat and VS2022
- Use GitHub Copilot Completions [Documentation](https://learn.microsoft.com/en-us/visualstudio/ide/visual-studio-github-copilot-extension?view=vs-2022)
- Use GitHub Copilot Chat [Documentation](https://learn.microsoft.com/en-us/visualstudio/ide/visual-studio-github-copilot-chat?view=vs-2022)
- Tips to improve Copilot Chat Results [Documentation](https://learn.microsoft.com/en-us/visualstudio/ide/copilot-chat-context?view=vs-2022)
- Debug with GitHub Copilot [Documentation](https://learn.microsoft.com/en-us/visualstudio/debugger/debug-with-copilot?view=vs-2022)
- Intro to GitHub Copiulot in Visual Studio [Video](https://www.youtube.com/watch?v=z1ycDvspv8U)

### Create a new Blazor Web App
Our Challenges we will create and solve in a Blazor Web App.
To create this app please follow the following steps:

1. Start Visual Studio 2022 and select Create a new project (Get started).
2. In the Create a new project window, type Blazor on the search box and hit Enter.
3. Select the Blazor Web App template and select Next.
4. In the Configure your new project window, enter BlazorAppGitHubCopilot as the project name and select Next.
5. In the Additional information window, select the following Options

    - .NET 8
    - Authentication type: None
    - Check => configure for https
    - Interactive render mode: Server
    - Interactivity location: Global
    - Check => Add Samples
    - Uncheck => Do not use top level Statements

6. After setting the options select create
7. When the project is created start the project with F5

Now you should see your Playground, the Blazor App with some samples for the Challenges.

## Challenge 0 - Check if your Copilot is running and play with him
Try out: 
- write prompts in code comments
- open the inline chat (Alt+/)
- try out the commands e.g. /help
- open the github chat window and have a conversation with Copilot
- In case you don't know that much about Blazor try to find a way that Copilot will explain your code / files

## Challenge 1 - Create a new Page with a Todo List

Here we want to create a new Blazor with a Todo list and the Page should be reachable from the Navigation menu.

### The requirements for the todo list are:
- Users can add new Tasks to the Todo List
- The List should be displayed on the page
- Users can mark tasks in the list as completed
- Users can delete tasks from the list
- Users can clear the complete list

### Actions

* Find a way to create a todo list with the copilot
* Be precise in your prompts and creative
* Improve your prompts iterative

### Success criteria

* Your Todo List is running and fulfills all requirements

## Challenge 2 - Add legacy code / fix it / add more data

Here we want to add some legacy code to our project.
Add the files from the Folder Challenge2 from this Repo into your Project.
```
Student.cs => Project root folder
StudentsProvider.cs => Project root folder
Students.razor => Pages Folder in your Project
```

### Actions

* Add the Students page to your navigation menu - in case you don't know how ask Copilot
* Start your Project and open the Students Page - you will see an error ask copilot how you can fix it.
* Fill out the Add Student Formula and press the add button. You will see that an Exception is thrown. Ask Copuilot in the Exception Thrown dialog for Help and fix with him the error.
* The Edit Student function is not working correctly. Ask Copilot if he can help you to find the problem.
* Try to generate more Students in the StudentsProvider with the help of Copilot

### Success criteria

* All errors are fixed
* You have more sample students
* The Edit Formula is working

## Challenge 3 - Add some UnitTests / Refactoring
Here we want to add UnitTests to our Project.
To create a UnitTest Project follow the following Steps:
1. Right-click on the Solution and select the new Add => New project Menu Item
2. In the Create a new project window, type 'nunit c#' on the search box and hit Enter.
3. Select the Nunit Test C# template and select Next.
4. In the Configure your new project window, enter BlazorAppGithubCopilot.Tests as the project name and select Next.
5. In the Additional information window, select the following Options
    - .NET 8
6. After setting the options select create
7. When the project is created start the Tests. Right-click on the Test Project and select Run Tests.
8. You should see that two Tests were successfully running.

### Actions
- Add the PricingCalculator.cs File into your Project into the root folder of the Project.
- Try to understand what the CalculateTotalPrice method does
- Ask Copilot to help you understand the CalculateTotalPrice method
- Ask Copilot to write you some unit tests for the CalculateTotalPrice method
- Think about the quality of the Tests. Maybe extend the tests with Copilot. Make all Tests green.
- Refactor the CalculateTotalPrice Method and keep the Tests green
- Ask Copilot what the RegEx is doing

### Success criteria

* Your Tests are Green and the Code is much better readable and understandable

## Challenge 4 - Convert Phyton code into C# Code
In this challenge, we want to convert phyton code into c# for our project.

### Actions
- Open the FinancialCalculator.py file and ask copilot if he can help you to migrate it to c#
- Take care that the user input and the console output are removed and converted into parameter and function results.
- When you have your C# Class of the Phyton code create a Blazor Page that the user can execute the Financial Calculation

### Success criteria

* The Phyton Code is converted to C# and the user can Navigate to a Blazor Page and execute the financial Calculation

# Solutions / Inspiration - Spoiler warning
> [!WARNING]
> Read this chapter only when you are finished or you get stuck in a Challenge

## Challenge 0 - Tipps
- Take a look in the: [More Information about Github Copilot, Github Copilot Chat and VS2022](#More-Information-about-Github-Copilot,-Github-Copilot-Chat-and-VS2022) section.
- Check these commands:
  ```
  /help
  /fix
  @Workspace
  #file
  /explain
  ```

## Challenge 1 - Tipps
Try this prompt for Copilot chat:
```
I want to create in my Blazor App a new Page. On this Page, i want to create a Todo List. The Todo List has Tasks.
- Users can add new Tasks to the Todo List - this should be possible via a text box and a button
- The List should be displayed on the page
- Users can mark tasks in the list as completed - with a checkbox
- Users can delete tasks from the list - this should be possible with a button on the task
- Users can clear the complete list - this should be possible with a button
Can you create the todo list?
Please also take about the code to make the Todo List available in the Navigation Menu
```

## Challenge 2 - Tipps
- Copy the Exception from the Browser in Github Copilot and ask for help.
- Ask the inline Copilot why the edit Function is not working
- Ask the inline Copilot to generate 10 more sample students

## Challenge 3 - Tipps
- Ask Copilot what the function is doing
- Use the /test command
- Make the Tests working - think about the test coverage
- Ask Copilot to help you refactor the Code
- Ask Copilot if he can explain to you the long regex

## Challenge 4 - Tipps
- Paste the Phyton code into Github Copilot chat and ask for: "Can you convert me the phyton code into a c# Class. convert the user input into parameters. and the output into a result class"
- Ask Copilot to generate a Blazor Page for the Calculation. Don't forget the Navigation Menu

# Finish

Congratulations on completing the GitHub Copilot Business Hackathon! We hope you had the opportunity to explore and learn more about your new pair programmer, GitHub Copilot.

Now, it's time to open your solutions and projects and start playing with Copilot. Consider where Copilot can streamline your daily work and make your life easier. Experiment with Copilot's capabilities and discover how it can enhance your productivity and creativity.

Thank you for investing your time and effort into this event. We look forward to seeing you again next time!
Happy coding, and enjoy exploring the possibilities with GitHub Copilot!