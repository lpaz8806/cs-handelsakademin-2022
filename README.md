# C# Grund

## Lesson 1: Data types

### Integers

### Floating point (approximate)



## Lesson 2: Flow Control


## Lesson 3: Arrays

### Declaration

Specify the size
``var words = new string[5];``

Explicit delaration/creation
`int[] oneToFive = { 1, 2, 3, 4, 5 };`

// attempt to access an index outside the array
// will throw an Exception
// Console.WriteLine(oneToFive[6]);
### Creation

### Data access

### Memory structure

### Common methods for array
int[] oneToFive = { 1, 2, 3, 4, 5 };
Console.WriteLine(string.Join(", ", oneToFive));
Array.Clear(oneToFive);
Console.WriteLine(string.Join(", ", oneToFive));
Array.Fill(oneToFive, 5);
Console.WriteLine(string.Join(", ", oneToFive));
Array.Resize(ref oneToFive, 10);
Console.WriteLine(string.Join(", ", oneToFive));
### Generics

### params

### Flerdimensionella arrayer

## Lesson 4: Recursion

### Wishful thinking

"Wishful Thinking" is a general technique for abstract thinking:
Accepting that a component (class, module, ...) works without having seen
its implementation, maybe even without having an implementation.

This is concept is heavily taught in
"Structure and Interpretation of Computer Programs", an MIT course

When seeing a recursive call, you should not think about the code being
executed on each sub call. Instead, just imagine that the sub call does 
its job correctly. Thus, you prove the correctness of the function by
assuming that it is correct (on simpler input). This is some positive
kind of self-fulfilling prophecy. Of course you still have to check for
trivial cases and need to assure that the recursive call handles a simpler
case of your problem. But those are minor issues. The hardest part is to
understand the recursive calls.

https://wiki.c2.com/?WishfulThinking

## Resources

- https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginners/

- https://www.codecademy.com/learn/learn-c-sharp

- https://www.tutorialsteacher.com/csharp/

- https://www.progsharp.se/
