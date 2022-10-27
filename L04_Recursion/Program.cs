// Välkommen tillbaka till förskolan

#region Wishful thinking

// Hanoi towers

#endregion

#region Divide and Conquer
/*
Write a procedure that ask the user to guess
a number between 1 and maxNumber you have
previously computed.
when the user guesses a number:
If correct, a message "Congrats! You got it in {attempts} guesses" is
shown and the game ends.
Otherwise, if the user has attempts left,
a message "That's too small, try again" or
"That's too big, try again" is shown according to the
case. The attempts get reduced by one.
If the user has no attempt left the message will be: 
"You've run out of attempts :(" and the game ends
*/
using L04_Recursion;

void PlayGuessGame(int maxNumber, int maxAttempts = int.MaxValue)
{
    var number = Environment.TickCount % maxNumber + 1;
    var attempts = 1;

    Console.WriteLine($"Guess a number between 1 and {maxNumber}");
    
    while (attempts < maxAttempts)
    {
        Console.Write("Guess a number: ");
        var guess = int.Parse(Console.ReadLine());
        if (guess == number)
        {
            Console.WriteLine($"Congrats, you got it in {attempts} attempts");
            return;
        }

        var msg = guess < number ? "small" : "big";
        Console.WriteLine($"That's too {msg}, try again");
        attempts++;
    }
}
//PlayGuessGame(100, 7);

#region Question 1
// Is there a way to always win?
// YES! by cutting in half
#endregion

#region Question 2
// Can we always win in 7 attempts at most?
// PlayGuessGame(100, 7);
#endregion

#region Question 3
// What is the minimum amount of attempts (k)
// we should give to the player such that,
// for a given maximum number n,
// if he plays wisely, can always win?
#endregion

#endregion

#region Stack Overflow

// There's a hole in the bucket
// https://www.youtube.com/watch?v=ijc1eJVR9Qw

/*
- There's a hole in the bucket, dear Liza.
- Then fix it, dear Henry.

- With what should I fix it, dear Liza?
- With the straw, dear Henry.

- But the straw is too long, dear Liza.
- Then cut it, dear Henry.

- With what shall I cut it, dear Liza? 
- With an ax, dear Henry.

- But the ax is too dull, dear Liza.
- Then sharpen it, dear Henry.

- With what should I sharpen it, dear Liza?
- With a stone, dear Henry.

- But the stone is too dry, dear Liza.
- Then wet it, dear Henry.

- With what should I wet it, dear Liza?
- With water, dear Henry.

- But how shall I get it, dear Liza? 
- In the bucket, dear Henry.

- But there's a hole in the bucket, dear Liza.

THE END
*/

#region Alternative ending (if Liza were skånska)
// - Kissa på den jä*** stenen då!
#endregion

#region Alternative story (if Liza were bullshit-intolerant)
// After "But the straw is too long, dear Liza"
// - Nämen sluta nu! Jag ska fixa det själv!
#endregion

#region The moral of the story
/*
    
*/
#endregion

#endregion

#region Exercise

/*
Suppose that there is a pile of sixteen coins on a table,
one of which is a counterfeit weighing slightly less than
the others. You also have a two-pan balance which allows
you to weigh one set of coins against another.

1- Using the divide-and-conquer strategy, how could you
determine the counterfeit coin in four weightings?


2- Can you come up with a procedure to find the counterfeit
coin in just three weightings?
HINT: The strategy is much the same, but the problem must be
subdivided in a different way.

3- Can you generalize this approach so that it works for any
set of N coins?

*/

#endregion



bool[,] map =
{
    { true, false, false, true },
    { true, false, false, false },
    { false, true, false, false },
    { false, false, false, false },
    { true, false, false, false },
    { false, false, false, false },
    { false, false, true, true },
    { false, false, false, false },
    { true, true, true, true }
};
var count = Examples.CountIslands(map);
Console.WriteLine(count);