/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой 
строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.Clear();

int [,] matrix = new int [3,4];

GetRandomMatrix (matrix);

Console.WriteLine();

int i = 0;
int j = 0;
int max = matrix[0, 0];
int count = 0;

for (i = 0; i < matrix.GetLength(0); i++)
{
    Console.WriteLine();

    for (count = 0; count < matrix.GetLength(1); count++)
        {      

        for (j = 0; j < matrix.GetLength(1)-1; j++)
            {
                    if (matrix[i, j] < matrix[i, j+1])
                        {
                            int x = matrix[i, j];
                            matrix[i, j] = matrix[i, j+1];
                            matrix[i, j+1] = x;
                        }       
                            
                    if (matrix[i, j] > matrix[i, j+1])
                        {
                            max = matrix[i, j];
                            matrix[i, j] = matrix[i, j+1];
                            matrix[i, j+1] = max;
                        }
            }
                    
        matrix[i, j] = -100;
        Console.Write($"{max} ");
        }
}

void GetRandomMatrix (int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                    {
                    matr[i, j] = new Random().Next(-10,10);
                    Console.Write($"{matr[i, j]} ");
                    }
                Console.WriteLine();
            }
    }