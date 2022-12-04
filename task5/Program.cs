// Написать программу, которая принимает на вход число N 
// и выдает произведение чисел от 1 до N
// 4->24

int Count(int N)
{
    int prz = 1;
    int i = 1;
    while(i <= N)
    {
        prz = prz * i;
        i++;
    }
    return prz;
}
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int answer = Count(x);
Console.WriteLine(answer);
