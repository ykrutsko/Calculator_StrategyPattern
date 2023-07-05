# Simple Calculator in C# with Strategy Pattern

This is a simple calculator application implemented in C#, capable of performing four basic arithmetic operations: addition (+), subtraction (-), multiplication (*), and division (/). The calculator is designed using the Strategy pattern, which allows for easy extensibility and swapping of different arithmetic strategies.

## Features
- Addition: Performs the addition of two numbers.
- Subtraction: Subtracts one number from another.
- Multiplication: Multiplies two numbers.
- Division: Divides one number by another.

## How to Use
1. Clone the repository or download the source code files.
2. Open the solution in an appropriate C# IDE (Integrated Development Environment) such as Visual Studio.
3. Build the solution to ensure all dependencies are resolved.
4. Run the application.
5. Enter two numbers.
6. Enter the desired arithmetic operation.
7. The result will be displayed in the output field.

## Implementation Details
The calculator employs the Strategy pattern, which encapsulates each arithmetic operation as a separate strategy. This approach allows for easy addition of new strategies or modification of existing ones without affecting the core calculator functionality. The strategies are dynamically selected based on the user's choice, enabling flexible and extensible calculations.

The code structure follows object-oriented principles and utilizes classes and interfaces to achieve modularity, readability, and maintainability.

## Requirements
- .NET Framework or .NET Core (depending on the specific version used).
- C# IDE or compiler (e.g., Visual Studio, Visual Studio Code with .NET Core SDK, or MonoDevelop).

## Credits
This calculator application was developed by Yurii Krutsko. Feel free to contribute to the project by submitting bug reports, feature requests, or pull requests.

## License
This project is licensed under the MIT License.