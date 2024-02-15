## Chapter 4

Understanding ownership in rust. What is ownership in Rust?
It is a way to manage memory.

1. Garbage collection: Java, C# don't worry about memory management because of the garbage collector. Pros: error-free, and faster write time. Cons: no control over memory; slower (can't manually optimize our memory) and unpredictable (the garbage collection can choose to clean up at any point in time and it slows our program). Larger program size because garbage collection piece of code has to be included in the program.
2. Manual memory mgt: control over memory, faster run time and smaller program size. Cons: extremely error prone - many bugs and security issues due to incorrect memory mgt. slower write time - because memory takes time to write your program.
3. Ownership model: control over memory, faster runtime, error-free (compile-time checks), smaller program size. Cons: slower write time - slower than manual memory mgt. learning curve (fighting with the borrow checker - debugging run-time errors)

Rust - systems programming language, runtime and program size, memory-safe language

The stack has frames and variables fixed. Frames are assigned at compile time.
Heap grow at run time, data is dynamic in size, could be a large amount and we control the lifetime of the data.
Pushing in a stack is faster than a heap, it needs to find space in a heap to store. Accessing in stack is faster than heap due to pointers.

Ownership rules:

1. Each value in Rust has a variable that's called its owner.
2. There can only be one owner at a time.
3. When the owner goes out of scope, the value will be dropped.

Rules of references:

1. At any given time, you can have either one mutable reference or any number of immutable references.
2. References must always be valid.

Slices let you reference a continuum of elements within a collection rather than the entire collection. Slices don't take ownership of the underlying data. 