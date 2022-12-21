//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] array = new int[5, 5];

Random random = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("-----------------------");

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int g = 0; g < array.GetLength(1) - 1 - j; g++)
        {
            if (array[i, g] < array[i, g + 1])
            {
                int temp = array[i, g + 1];
                array[i, g + 1] = array[i, g];
                array[i, g] = temp;
            }
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}