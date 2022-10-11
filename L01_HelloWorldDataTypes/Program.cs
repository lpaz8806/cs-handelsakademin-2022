// IDE : Integrated development environment
using System.Diagnostics;
using System.Threading.Channels;

/*
var sw = new Stopwatch();
Console.Write("Skriv ditt namn, yo: ");
sw.Start();
var name = Console.ReadLine();
sw.Stop();
Console.WriteLine(
    $"Hej, {name}! You took {sw.ElapsedMilliseconds} ms");
*/


sbyte b = -10;
byte ub = 10;

short sh = -10;
ushort ush = 10;

int x = 10;
uint ux = 10u;

long y = 10L;
ulong uy = 10UL;

// Floating point numbers (approximate)
float f = 1.0f;  // 32 bits precision
double d = 1.0d; // 64 bits precision
decimal dm = 1.0m; // 128 bits precision
// Boolean
bool q = true;
bool p = false;
var xor = p ^ q;
var or = p || q;
var and = p && q;
// 
char c = 'Ö';  // Ascii art
string s = "This is a string";

// Arithmetic operators

var i = 99;
var j = 5;
// Console.WriteLine($"{i} + {j} = {i+j}");
var format = $"{{{0}}}{1} + {1 + 1}foo = {2}";
Console.WriteLine(format, i, j, i+j);
