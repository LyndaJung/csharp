// See https://aka.ms/new-console-template for more information

int x; //declaration
x = 123; //initialisation

int y = 321; //declaration + initialisation

int z = x + y;

int age = 21; //whole number
double height = 300.5;
char symbol = '@';
String name = "Lynda";

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

Console.WriteLine("your age is " + age);

Console.WriteLine("Your height is " + height + "cm");
Console.WriteLine("Your symbol is: " + symbol);

String userName = symbol + name;

Console.WriteLine("Your username is: " + userName);

// type casting = Converting a value to a different data type
//                Useful when we accept user input (string)
//                Different data types can do different things

double a = 3.14;
int b = Convert.ToInt32(a);

int c = 123;
double d = Convert.ToDouble(c);

int e = 321;
String f = Convert.ToString(e);

String g = "$";
char h = Convert.ToChar(g);

String i = "true";
bool j = Convert.ToBoolean(i);

Console.WriteLine(b.GetType());
Console.WriteLine(d.GetType());
Console.WriteLine(f.GetType());
Console.WriteLine(h.GetType());
Console.WriteLine(j.GetType());

Console.Beep();