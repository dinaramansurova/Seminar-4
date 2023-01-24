// Напишите программу, которая принимает два числа и выводит наибольшее

int f(int a, int b)
{
    if (a > b)
        return a;
    return b;
}


int a = 10, b = 7;
Console.WriteLine(f(a, b));

// или

int f(int a, int b)
{
    if (a > b)
        return a;
    return b;
}


int a = 10, b = 7;
int result = f(a, b);
Console.WriteLine(result);