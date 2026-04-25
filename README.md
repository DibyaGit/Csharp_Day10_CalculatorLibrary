# Calculator Library and Unit Testing Suite

## Project Overview
The objective of this project is to develop a robust .NET class library that performs fundamental arithmetic operations while ensuring code reliability through comprehensive unit testing. The solution is organized into two distinct projects: a class library for core logic and a test project utilizing the NUnit framework.

---

## Implementation Details
The Calculator class implements four primary arithmetic operations using double-precision floating-point numbers:

* Addition: Calculates the sum of two numbers.
* Subtraction: Calculates the difference between two numbers.
* Multiplication: Calculates the product of two numbers.
* Division: Calculates the quotient and includes logic to handle invalid operations.

### Exception Handling
As per the assignment requirements, the division method includes a guard clause to handle division by zero. If the divisor is zero, the system throws a DivideByZeroException.

---

## Unit Testing Strategy
The testing suite verifies that the calculator methods function correctly under various conditions using the NUnit framework.

### Test Coverage
The following scenarios are validated using assertions:
* Valid Inputs: Verifies correct mathematical results for standard operations.
* Edge Cases: Validates results for specific cases, such as adding or subtracting zero.
* Exception Validation: Confirms that the system correctly identifies and handles division by zero.

---

## Execution Instructions
1. Open Solution: Load the project solution in Visual Studio.
2. Build: Build the solution to ensure all dependencies and project references are resolved.
3. Test Explorer: Open the Test Explorer from the Visual Studio menu.
4. Run Tests: Select Run All to execute the validation suite.
5. Review: Ensure all tests pass with a green status indicator.
