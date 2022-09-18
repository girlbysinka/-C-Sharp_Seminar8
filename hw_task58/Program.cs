/* Задача 58: Задайте две матрицы.
Напишите программу, которая будет 
находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();

int [,] matrix1 = new int [2,2];
GetRandomMatrix (matrix1);

Console.WriteLine();

int [,] matrix2 = new int [2,2];
GetRandomMatrix (matrix2);

Console.WriteLine();

MatrixMultiplication();

void MatrixMultiplication ()
    {
        for (int i = 0; i < matrix1.GetLength(1); i++)
            {
                int sum1 = 0;
                int sum2 = 0;

                for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        sum1 = sum1 + matrix1[i,j] * matrix2[j,i];
                        int c = -i;
                        sum2 = sum2 + matrix1[i,j] * matrix2[j,c+1];
                    }
                
                if (i == 0)
                    {
                        Console.WriteLine($"{sum1} {sum2}");
                    }
            
                else if (i == 1)
                    {
                    Console.WriteLine($"{sum2} {sum1}");
                    }
            }        
    }





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