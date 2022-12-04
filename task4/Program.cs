// Напишите программу, которая принимает на вход число
//  и выдает количество цифр в числе
// 456 ->3

int Count(int A)
{
    int i = 0;
    while(i < A)
    {
        A = A / 10;
        i++;
    }
    return i;
}
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int answer = Count(x);
Console.WriteLine(answer);