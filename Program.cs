// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] table = new int[3, 4]; 
// FillArrayRandom(table); 
// PrintArray(table); 
// SortToLower(table); 
// Console.WriteLine(); 
// PrintArray(table); 

// void FillArrayRandom(int[,] array) 
// { 
//     for    (int i=0;   i<array.GetLength(0); i++) 
//     { 
//         for    (int j=0;   j<array.GetLength(1); j++) 
//         { 
//             array [i, j] = new Random ().Next (1, 10); 
//         } 
//     } 
// } 

// void SortToLower(int[,] array) 
// { 
//     for    (int i=0;   i<array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             for (int k = 0; k < array.GetLength(1) - 1; k++) 
//             { 
//                 if (array[i, k] < array[i, k + 1]) 
//                 { 
//                     int temp = array[i, k + 1]; 
//                     array[i, k + 1] = array[i, k]; 
//                     array[i, k] = temp; 
//                 } 
//             } 
//         } 
//     } 
// } 

// void PrintArray(int[,] array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             Console.Write($"{array[i, j]} "); 
//         } 
//         Console.WriteLine(); 
//     } 
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] FillArrayRandomNumbers(int m, int n, int left, int right) 
// { 
//     int[,] arr = new int[m,n]; 
//     Random rand = new Random(); 
//     for (int i = 0; i < m; i++) 
//     { 
//         for (int j = 0; j < n; j++) 
//         { 
//             arr[i,j] = rand.Next(left,right+1); 
//         } 
//     } 
//     return arr; 
// } 
// void Print(int[,] arr)  
// { 
//     for (int i = 0; i < arr.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < arr.GetLength(1); j++) 
//         { 
//             Console.Write(arr[i,j]+"\t"); 
//         } 
//         Console.WriteLine(); 
//     } 
// } 
// int Sum(int[] arr) 
// { 
//     int sum = 0; 
//     for (int i = 0; i < arr.Length; i++) 
//     { 
//         sum = sum + arr[i]; 
//     } 
//     return sum; 
// } 
 
// void minimum(int[] arr) 
// { 
//     int min = arr[0]; 
//     int num = 0; 
//     for (int i = 0; i < arr.Length; i++) 
//     { 
//      if (min > arr[i]) 
//      { 
//         min = arr[i]; 
//         num = i; 
//      }    
//     } 
//     Console.WriteLine($"Номер строки: {num+1}, минимальная сумма:{min}"); 
// } 
 
// int[] test(int[,] arr) 
// { 
//     int[] min = new int[arr.GetLength(0)]; 
//     for (int i = 0; i < arr.GetLength(0); i++) 
//     { 
//         int[] stroka = new int[arr.GetLength(1)]; 
//         for (int j = 0; j < arr.GetLength(1); j++) 
//         { 
//             stroka[j] = arr[i,j]; 
//         } 
//         int sum = Sum(stroka); 
//         min[i] = sum; 
 
//     } 
//     return min; 
// } 

// Console.WriteLine("Введите m и n"); 
// int m =  Convert.ToInt32(Console.ReadLine()); 
// int n =  Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите левую границу случайного числа массива"); 
// int left = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите правую границу случайного числа массива"); 
// int right = Convert.ToInt32(Console.ReadLine()); 
// int[,] array = FillArrayRandomNumbers(m, n, left, right); 
// int[] Min = test(array); 
 
// Print(array); 
// Console.WriteLine(); 
// minimum(Min);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] matrix1 = new int[,] {{2, 4}, {3, 2}};
// int[,] matrix2 = new int[,] {{3, 4}, {3, 3}};

// int rows1 = matrix1.GetLength(0);
// int cols1 = matrix1.GetLength(1);
// int rows2 = matrix2.GetLength(0);
// int cols2 = matrix2.GetLength(1);


// int[,] result = new int[rows1, cols1];

// for (int i = 0; i < rows1; i++) 
// {
//     for (int j = 0; j < cols2; j++) 
//     {
//         result[i, j] = matrix1[i, j] * matrix2[i, j];
//     }
// }

// for (int i = 0; i < result.GetLength(0); i++) 
// {
//     for (int j = 0; j < result.GetLength(1); j++) 
//     {
//         Console.Write(result[i, j] + " ");
//     }
//     Console.WriteLine();
// }
 

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[] random(int[] arr) 
// { 
//     Random rand = new Random(); 
//     int check = 0; 
//     while (check != arr.Length) 
//     { 
//         int a = rand.Next(10,100); 
//         if (Array.IndexOf(arr, a) == -1) 
//         { 
//             arr[check] = a; 
//             check++; 
//         } 
//     } 
//     return arr; 
// } 
 
// int[,,] FillArrayRandomNumbers(int m, int n, int z) 
// { 
//     int[,,] arr = new int[m,n,z]; 
//     int[] array = new int[m*n*z]; 
//     array = random(array); 
//     int count = 0; 
//     for (int i = 0; i < m; i++) 
//     { 
//         for (int j = 0; j < n; j++) 
//         { 
//             for (int h = 0; h < z; h++) 
//             { 
//                 arr[i,j,h] = array[count]; 
//                 count++;     
//             } 
//         } 
//     } 
//     return arr; 
// } 
 
// void Print(int[,,] arr) 
// { 
//     for (int i = 0; i < arr.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < arr.GetLength(1); j++) 
//         { 
//             Console.WriteLine(); 
//             for (int h = 0; h < arr.GetLength(2); h++) 
//             { 
//                 Console.Write($"{arr[i, j, h]}({i},{j},{h}) "); 
//             } 
//         } 
//     } 
// } 
// Console.WriteLine("Введите m,n,z"); 
// int m =  Convert.ToInt32(Console.ReadLine()); 
// int n =  Convert.ToInt32(Console.ReadLine()); 
// int z = Convert.ToInt32(Console.ReadLine()); 
// int[,,] array = FillArrayRandomNumbers(m, n, z); 
// Print(array);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4;
int[,] matrix = new int[n, n];
int num = 1;
int maxRow = n - 1;
int maxCol = n - 1;
int minRow = 0;
int minCol = 0;

while (num <= n * n)
{
    for (int i = minCol; i <= maxCol; i++)
    {
        matrix[minRow, i] = num;
        num++;
    }
    minRow++;

    for (int i = minRow; i <= maxRow; i++)
    {
        matrix[i, maxCol] = num;
        num++;
    }
    maxCol--;

    for (int i = maxCol; i >= minCol; i--)
    {
        matrix[maxRow, i] = num;
        num++;
    }
    maxRow--;

    for (int i = maxRow; i >= minRow; i--)
    {
        matrix[i, minCol] = num;
        num++;
    }
    minCol++;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}