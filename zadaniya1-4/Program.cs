///////1

int a = 5;
int b = 7;
Console.WriteLine ("первое число " + a);
Console.WriteLine ("второе число " + b);
if (a>b)
{
    Console.WriteLine ("первое число больше второго ");
    Console.WriteLine ("второе число меньше первого ");
}
else
{
    Console.WriteLine ("второе число больше первого ");
    Console.WriteLine ("первое число меньше второго ");
}

//////////2
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

/////////3

int a = 59;
Console.WriteLine ("число " + a);
if (a % 2 == 1)
{
    Console.WriteLine ("число является нечетным");
}
else 
{
    Console.WriteLine ("число является четным");
}

///////// 4
int N = 10;
int i = 2;
while (i <= N) 
{
Console.Write(i+ " ");
i= i + 2;
}
