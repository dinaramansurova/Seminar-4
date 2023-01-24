// Function(void)


void f(ref int n)
{
    n = n + 5;
}

int n = 10;
f(ref n);
Console.WriteLine(n);

// Передача значений по ссылке



// Function(void)


void f(int[] n)
{
    n[0] = n[0] + 5;
}

int[] n = {1, 2, 3, 4, 5};
f(n);
Console.WriteLine(string.Join(" ", n));