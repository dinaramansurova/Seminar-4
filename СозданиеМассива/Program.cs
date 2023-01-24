// Array

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-10, 11); // [-10, 10]     i + 1 это если хотим не случайные значения в массиве

Console.WriteLine($"Результат: [{string.Join(", ", array)}]"); // функция string.Join делает из массива строку