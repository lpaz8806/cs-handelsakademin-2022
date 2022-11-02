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

var myAcc = new BankAccount("Luis", 25000);
var fooAcc = new BankAccount("Foo Foosson", 2_500_000_000);
fooAcc.Transfer(myAcc, 100_000);
Console.WriteLine($"The new saldo is {myAcc.Saldo}");

