# Word Wrap Kata in C#


## Problem Description
You write a class called Wrapper, that has a single static function named wrap that takes two arguments, a string, and a column number. The function returns the string, but with line breaks inserted at just the right places to make sure that no line is longer than the column number. You try to break lines at word boundaries.

Like a word processor, break the line by replacing the last space in a line with a newline.

For example, here is a sample test case (in C#):

```csharp
Wrapper.wrap("word word", 5).Should().Be("word\nword");
```

## Technologies used
This boilerplate include:

- ➕ [.NET 7.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7) as language version
- 🧪 [xUnit](https://xunit.net/) as testing framework
- ✅ [FluentAssertions](https://fluentassertions.com/) as assertion library
- 🐋 [Docker](https://www.docker.com/) as containerization platform

## How to use run the tests

### JetBrains Rider

1. Install [JetBrains Rider](https://www.jetbrains.com/rider/)
2. Open the repository in JetBrains Rider
3. Run the tests with the Test Explorer
4. The tests should run and pass

### Visual Studio Code

1. Install [Visual Studio Code](https://code.visualstudio.com/)
2. Install the [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
3. Open the repository in Visual Studio Code
4. Run the tests with the Test Explorer
5. The tests should run and pass
6. You can also run the tests with the command `dotnet test` in the root directory of the repository