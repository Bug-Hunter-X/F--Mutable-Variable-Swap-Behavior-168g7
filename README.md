# F# Mutable Variable Swap Behavior

This example demonstrates a subtle difference in how mutable variables behave in F# when passed to functions.  Specifically, it highlights the distinction between passing mutable variables by reference (in essence) and swapping values using tuple manipulation.

The file `bug.fs` shows the unexpected behavior.  The solution file `bugSolution.fs` offers a corrected approach.

## Problem

When using mutable variables directly, we expect changes made within the function to persist outside the function scope. However, when we use tuples to swap, the swapped values do not persist.