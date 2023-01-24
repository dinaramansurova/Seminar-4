// Напишите программу, которая принимает на ввод число и выдает количество цифр в этом числе.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
while (n > 0)
{
    n = n / 10;
    count++; // count = count + 1
}
Console.WriteLine(count);