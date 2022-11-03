using L05_Classes;

// Entry point

#if false 
var c = new Chronometer();

Thread.Sleep(2000);
Console.WriteLine(c.ElapsedMilliseconds);

Thread.Sleep(1000);
Console.WriteLine(c.ElapsedMilliseconds);
#endif

#if false
var str = "hello";
Console.WriteLine(str.Length);
// str.Length = 100; // corrupted state
str += " world!";
Console.WriteLine(str.Length);
#endif

#if false
var luis = new Person("Luis", 34);
Console.WriteLine(luis.Name);
luis.Name = "Ludwig";
Console.WriteLine(luis.Name);
#endif

#if false
var myAcc = new BankAccount("Luis", 25000);
var fooAcc = new BankAccount("Foo Foosson", 2_500_000_000);
fooAcc.Transfer(myAcc, 100_000);
Console.WriteLine($"The new saldo is {myAcc.Saldo}");
#endif


#region Example Application

var phoneBook = new PhoneBook(10);
while (true)
{
    var input = Console.ReadLine().Split(' ', StringSplitOptions.TrimEntries);
    switch (input[0].ToLower())
    {
        case "add":
            phoneBook.Add(input[1], input[2]);
            break;
    
        case "edit":
            phoneBook.Edit(input[1], input[2]);
            break;
    
        case "remove":
            phoneBook.Remove(input[1]);
            break;
    
        case "search":
            var number = phoneBook.Search(input[1]);
            if(string.IsNullOrEmpty(number))
                Console.WriteLine("Not found");
            else
                Console.WriteLine(number);
            break;
    
        case "quit":
            return;
    }
}

#endregion
