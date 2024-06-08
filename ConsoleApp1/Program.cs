// See https://aka.ms/new-console-template for more information

int x; //declaration
x = 123; //initialisation

int y = 321; //declaration + initialisation

int z = x + y;
int j = z - y;

int age = 21; //whole number
double height = 300.5;
char symbol = '@';
String name = "Lynda";

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.WriteLine(j);
Console.WriteLine(z+j);
Console.WriteLine("your age is " + age);

Console.WriteLine("Your height is " + height + "cm");
Console.WriteLine("Your symbol is: " + symbol);

String userName = symbol + name;

Console.WriteLine("Your username is: " + userName);
Console.Beep();