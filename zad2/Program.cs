int a = 2;
int b = 3;
int c = 7;
Console.WriteLine ("первое число " + a);
Console.WriteLine ("второе число " + b);
Console.WriteLine ("третье число " + c);
if (a>b & a>c)
{
    Console.WriteLine ("max - первое число");
}
else if (b>a & b>c)
{
    Console.WriteLine ("max - второе число");
}
else if (c>a & c>b)
{
    Console.WriteLine ("max - третье число");
}

