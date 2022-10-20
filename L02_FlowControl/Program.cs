
// read two numbers from the user. Print the maximum of them
void RunMaxOfTwoNumbers()
{
    var n1 = int.Parse(Console.ReadLine());
    var n2 = int.Parse(Console.ReadLine());
    if (n1 > n2)
        Console.WriteLine(n1);
    else
        Console.WriteLine(n2);
}

// read three numbers from the user. Print the maximum of them
void RunMaxOfThreeNumbers()
{
    var n1 = int.Parse(Console.ReadLine());
    var n2 = int.Parse(Console.ReadLine());
    var n3 = int.Parse(Console.ReadLine());
    
    // max(n1, n2)
    var max1 = n1 > n2 ? n1 : n2;
    
    // max(max(n1,n2), n3)
    var max = max1 > n3 ? max1 : n3;

    // var variable = condition ? true_value : false_value
    
    Console.WriteLine(max);
}

// read three numbers from the user
// Print them in sorted order ASC
// ex. 2 7 5 => 2 5 7
void RunSortThreeNumbers()
{
    var n1 = int.Parse(Console.ReadLine());
    var n2 = int.Parse(Console.ReadLine());
    var n3 = int.Parse(Console.ReadLine());
    
    if ((n1 <= n2) && (n1 <= n3))
    {   
        if (n2 < n3)
            Console.WriteLine($"{n1}, {n2}, {n3}");
        else
            Console.WriteLine("{0}{1}{2}",n1, n3, n2);
    }

    else if ((n2 <= n1) && (n2 <= n3))
    {
        if (n1 <= n3)
        {
            Console.WriteLine("{0} {1} {2}", n2, n1, n3);
        }
        else
        {
            Console.WriteLine("{0} {1} {2}", n2, n3, n1);
        }
    }

    else if ((n3 <= n1) && (n3 <= n2))
    {
        if (n1 <= n2)
        {
            Console.WriteLine("{0} {1} {2}", n3, n1, n2);
        }
        else
        {
            Console.WriteLine("{0} {1} {2}", n3, n2, n1);
        }
    }
}

// Print the numbers from 1 to 10, one per line
void RunPrintFromOneToTen()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }
}

// Ask the user to input 5 numbers. One at a time. Print the sum of them
void RunPrintSumOf5Numbers()
{
    var sum = 0;

    for (int i = 1; i <= 5; i++)
    {
        Console.Write($"Type number {i}: ");
        var n = int.Parse(Console.ReadLine());
        sum += n;
    }
    
    Console.WriteLine($"The sum is {sum}");
}

void RunReadUntilQuit()
{
    while (true)
    {
        var input = Console.ReadLine().Trim();
        
        if ("quit" == input)
            break;  // exit the loop immediately
        
        if("hello" == input)
            continue;   // restart the loop
        
        Console.WriteLine("Keep writing, you fool!");
    }
}

// Tell the user to guess a number
// if the number is the one you "thought", congratulate him
// otherwise let him to try again
void RunGuessNumber()
{
    var random = 6;

    while (true)
    {
        Console.Write("Guess a number, you freak: ");
        var number = int.Parse(Console.ReadLine());
        if (number == random)
            break;
    }
    
    Console.WriteLine("Congratulations. You've read my mind");
}
void RunGuessNumberDoWhile()
{
    var random = 6;
    var number = 0;
    
    do
    {
        Console.Write("Guess a number, you freak: ");
        number = int.Parse(Console.ReadLine());
    } while (number != random);
    
    Console.WriteLine("Congratulations. You've read my mind");
}

void RunMultiplicationTable()
{
    int foo = 12;
    for (int i = 1; i <= 9; i++)
    {
        Console.WriteLine($"Multiplication table for {i}");
        for (int j = 1; j <= 9; j++)
        {
            Console.WriteLine($"{i} * {j} = {i * j}");
        }
        
        Console.WriteLine();
    }
}

// In order to define a function:
// <return_type> <function_name> ( <param1_type> <param1_name>, <param2_type> <param2_name>, ... )
// {
//     // Function body
//     return value; // value must be of type <return_type>
// }
int Sum(int x, int y)
{
    return x + y;
}

// x and y are called "formal parameters"
int Max(int x, int y)
{
    var isXTheGreatest = x > y;     // isXTheGreatest is a "local variable" and can only be used
                                    // within the scope of the function Max
    return isXTheGreatest ? x : y;
}
// when a formal parameter is assigned (bound) in a function call, then it is called "argument". E.g in
// Max(2, 5);
// 2 is the first argument and 5 is the second.
// The expression Max(2, 5) is called "function call"

int Square(int x)
{
    return x * x;
}


bool IsEven(int x)
{
    return x % 2 == 0;
}
