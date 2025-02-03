# Integer Overflow Bug in C#
This repository demonstrates a common integer overflow bug in C# and its solution.

The `bug.cs` file contains the buggy code that can lead to an integer overflow when adding two large integers. The `bugSolution.cs` file demonstrates how to mitigate this problem.

## Bug Description
When adding two integers in C#, if the result exceeds the maximum value of an integer (int.MaxValue), an integer overflow occurs.  This can lead to incorrect results or unexpected exceptions. 

## Solution
The solution involves using checked arithmetic to explicitly handle potential overflows or using larger integer types (like long) to accommodate larger values.