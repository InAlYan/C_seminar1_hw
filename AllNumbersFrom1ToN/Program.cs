// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число (N): ");
int number = int.Parse(Console.ReadLine());
int index = 2;
int numStart = index;

// Вариант 1
while (index <= number)
{
    if (index % 2 == 0)
    {
        if (index == numStart)
        {
            Console.Write(index);
        }
        else
        {
            Console.Write(", " + index);
        }
    }
    index = index + 1;
}

// Вариант 2
index = 2;
Console.WriteLine();

while (index <= number)
{
    if (index == numStart)
    {
        Console.Write(index);
    }
    else
    {
        Console.Write(", " + index);
    }
    index = index + 2;
}
