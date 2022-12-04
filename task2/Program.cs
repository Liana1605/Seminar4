int SayNum(int num1, int num2)
{
    if (num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}

int x = SayNum(2,3);
Console.WriteLine(x);

Console.WriteLine(SayNum(7, 5));

int x1 = 10;
int x2 = 17;
int x3 = SayNum(x1, x2);
Console.WriteLine(x3);
