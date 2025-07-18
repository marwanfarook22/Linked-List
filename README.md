#  Custom Linked List 📋

A flexible and generic C# implementation of a singly-linked list, built for the Ultimate C# Masterclass! 🚀

![Build Status](https://img.shields.io/badge/build-passing-brightgreen)
![License](https://img.shields.io/badge/license-MIT-blue)

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Technologies](#technologies)
- [Installation](#installation)
- [Usage](#usage)
- [Implemented Operations](#implemented-operations)
- [Contributing](#contributing)
- [License](#license)

## Introduction
The **Custom Linked List** is a C# project developed as part of the *Ultimate C# Masterclass* assignment. This project implements a generic singly-linked list that can store items of any type, including null values. It adheres to the `ILinkedList<T>` interface, extending `ICollection<T>`, and provides a robust set of operations for managing a linked list. Perfect for learning about data structures and generics in C#! ✨

 
## Features
- 📋 Generic implementation to store items of any type (including null)
- 🔗 Singly-linked list structure for efficient insertions and deletions
- ✅ Supports all required operations from `ILinkedList<T>` and `ICollection<T>`
- 🔍 Iterable with `foreach` loops via generic and non-generic enumerators
- 🛠️ Handles edge cases with appropriate exception handling

## Technologies
This project showcases the following C# technologies:
- **Generics**: Enables the linked list to work with any data type (`T`).
- **Interfaces**: Implements `ILinkedList<T>` and `ICollection<T>` for standardized collection operations.
- **Singly-Linked List**: Efficiently manages nodes with a single pointer to the next node.
- **Exception Handling**: Robust validation for operations like `CopyTo`.

## Installation
To get started with the Custom Linked List, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/username/custom-linked-list.git
   ```
2. **Navigate to the project directory**:
   ```bash
   cd custom-linked-list
   ```
3. **Restore dependencies**: Ensure you have the .NET SDK installed, then run:
   ```bash
   dotnet restore
   ```
4. **Build the project**:
   ```bash
   dotnet build
   ```

**Prerequisites**:
- .NET SDK (version 6.0 or higher)
- A C# IDE (e.g., Visual Studio, VS Code, or Rider)

## Usage
Run the application to test the linked list implementation:
```bash
dotnet run
```

Example usage:
```csharp
var list = new CustomLinkedList<string>();
list.AddToFront("Tatooine");
list.AddToEnd("Alderaan");
Console.WriteLine($"Count: {list.Count}"); // Output: Count: 2
Console.WriteLine($"Contains Alderaan: {list.Contains("Alderaan")}"); // Output: Contains Alderaan: true

foreach (var planet in list)
{
    Console.WriteLine(planet);
}
```

For detailed code examples, check the `src/` directory.

## Implemented Operations
The `CustomLinkedList<T>` implements the `ILinkedList<T>` interface, extending `ICollection<T>`, with the following operations:

- **`AddToFront(T? item)`**: Adds an item to the front of the list.
- **`AddToEnd(T? item)`**: Adds an item to the end of the list (same as `Add(T? item)`).
- **`Count`**: Gets the number of items in the list.
- **`IsReadOnly`**: Returns `false` as the list is mutable.
- **`Contains(T? item)`**: Checks if the list contains the specified item.
- **`CopyTo(T?[] array, int arrayIndex)`**: Copies the list’s items to an array starting at the given index, with validation for invalid arrays or indices.
- **`Remove(T? item)`**: Removes the first occurrence of the specified item, returning `true` if successful.
- **`GetEnumerator()`**: Provides generic and non-generic enumerators for `foreach` iteration.

### Example Code
```csharp
public class CustomLinkedList<T> : ILinkedList<T>
{
    public void AddToFront(T? item)
    {
        // Implementation to add item to the front
    }

    public void AddToEnd(T? item)
    {
        // Implementation to add item to the end
    }

    // Other methods as per ILinkedList<T> and ICollection<T>
}
```

Check the `src/CustomLinkedList.cs` file for the full implementation.

## Contributing
We welcome contributions to enhance this linked list implementation! 🌟 To contribute:
1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Make your changes and commit (`git commit -m "Add your feature"`).
4. Push to your branch (`git push origin feature/your-feature`).
5. Open a pull request.

Please read our [Contributing Guide](CONTRIBUTING.md) for more details.

Have questions or suggestions? Open an [issue](https://github.com/username/custom-linked-list/issues) or reach out on [X](https://x.com/yourusername).

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.ME (4).markdown…]()
