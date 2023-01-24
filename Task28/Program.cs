// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 1;

for (int i = 2; i <= n; i++)
{
    sum = sum * i;
}
Console.WriteLine($"{sum}");