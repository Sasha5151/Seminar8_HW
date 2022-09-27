// Урок 8. Как не нужно писать код. Часть 2

// В задачах 1,2,3 необходимы разработка и использование своих функций.
//  Без выполнения этого условия оценка будет снижаться.

// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Номер строки с наименьшей суммой элементов: 1 строка
// (допускается указывать индекс строки в массиве, в данном примере - 0)

// int strCount = 4;
// int colCount = 4;
// int [,] arr = new int [strCount,colCount];

// Random rnd = new Random();
// for (int i = 0; i < strCount; i++)
// {
//     for (int j = 0; j < colCount; j++)
//     {
//        arr[i,j] = rnd.Next(1,10); 
//         System.Console.Write(arr[i,j] + " ");
//     }  
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();

// int [] strSummArr = new int [strCount];
// strSummArr[0]=0;
// for (int i = 0; i < strCount; i++)
// {
//     for (int j = 0; j < colCount; j++)
//     {
//        strSummArr[i] +=arr[i,j];
//     }  
//     System.Console.Write(strSummArr[i] + " ");
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();
// int MinstrSummArr = strSummArr[0];
// int NomerStr = 1;
// for (int i = 1; i < strSummArr.Length; i++)
// {
//     if (MinstrSummArr > strSummArr[i])
//     {
//         MinstrSummArr = strSummArr[i];
//         NomerStr = i+1;
//     }
// }
// System.Console.Write(NomerStr + " строка ");



// Задача 2: Задайте две квадратные матрицы одного размера. 
//Напишите программу, которая будет находить произведение двух матриц.
// Произведением двух матриц А и В называется матрица С,
// элемент которой, находящийся на пересечении i -й строки и j -го столбца,
// равен сумме произведений элементов i -й строки матрицы А на 
// соответствующие (по порядку) элементы j -го столбца матрицы В.
// Из этого определения следует формула элемента матрицы C: 
// Произведение матрицы А на матрицу В обозначается АВ.
// Например, даны 2 матрицы:

// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int N = 2;
int strCount = N;
int colCount = N;
int [,] arrA = new int [strCount,colCount];

Random rnd = new Random();
for (int i = 0; i < strCount; i++)
{
    for (int j = 0; j < colCount; j++)
    {
        arrA[i,j] = rnd.Next(1,6); 
        System.Console.Write(arrA[i,j] + " ");
    }  
    System.Console.WriteLine();
}
System.Console.WriteLine();

int [,] arrB = new int [strCount,colCount];

for (int i = 0; i < strCount; i++)
{
    for (int j = 0; j < colCount; j++)
    {
        arrB[i,j] = rnd.Next(1,6); 
        System.Console.Write(arrB[i,j] + " ");
    }  
    System.Console.WriteLine();
}
System.Console.WriteLine();

int [,] arrC = new int [strCount,colCount];

for (int i = 0; i < strCount; i++)
{
    for (int j = 0; j < colCount; j++)
    {
        arrC[i,j]=0;
        for (int k = 0; k < N; k++)
        {
            arrC[i,j] += arrA[i,k]*arrB[k,j];           
        }
         System.Console.Write(arrC[i,j] + " ");
    }  
    System.Console.WriteLine();
}





// Задача 3. Сформируйте двухмерный массив из неповторяющихся случайных
//  двузначных чисел (размер массива не более 50 элементов). 
//  Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве 
// (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34
