/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке
 и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Clear();

int [,] matrix = new int [4,4];

GetRandomMatrix (matrix);

Console.WriteLine();

int sum = 0;
int min = 40;
int stringWithMinSum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
    {    
        for (int j = 0; j < matrix.GetLength(0); j++)
            {
                sum = sum + matrix[i,j];
            }
                        
        if (sum < min)
        {
            min = sum;
            stringWithMinSum = i+1;
        }
                
        sum = 0;
    }

Console.WriteLine();
Console.Write($"Номер строки с наименьшей суммой элементов равной {min}: {stringWithMinSum} строка");

void GetRandomMatrix (int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                    {
                    matr[i, j] = new Random().Next(0,10);
                    Console.Write($"{matr[i, j]} ");
                    }
                Console.WriteLine();
            }
    }
