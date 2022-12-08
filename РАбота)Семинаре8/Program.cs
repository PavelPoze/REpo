// задача 53 Задайте двуметный массив. Напишите программу, который поменяет местами
// первую и последнюю  сторку.
/*
int rows = ReadInt("Введите число строк: ");     //зарашиваем количество срок (rows)
int columns = ReadInt("Введите число стоблбцов: ");   /// запрашиваем количество столбцов (columns)
int[,] number = new int[rows, columns];
int firstRowsToChange = 0;
int anotherRowsToChange = number.GetLength(0)-1;
FillMatrixArrayRandomNumbers(number);
WriteMatrix(number);
for (int j = 0; j < number.GetLength(1); j++)
{                                   // индекс J т.к. нужны столбцы
    int temp = number[anotherRowsToChange,j];
    number[anotherRowsToChange,j] = number[firstRowsToChange,j];
    number[firstRowsToChange,j] = temp;
}
WriteMatrix(number);
void FillMatrixArrayRandomNumbers(int[,] array)     //заполнение двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)   // цикл для заполнения строк
    {
        for (int j = 0; j < array.GetLength(1); j++)   // цикл для заполнения стодбцов
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)    // вывод двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)   // цикл для заполнения строк
    {
        for (int j = 0; j <array.GetLength(1); j++)   // цикл для заполнения стодбцов
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/


// Задача 55 Задайте массив Напишите программу которая заменяет строки на столбцы
// в случае если это не возможно, программа должна вывести  сообщение для пользователя


int rows = ReadInt("Введите число строк: ");     //зарашиваем количество срок (rows)
int columns = ReadInt("Введите число стоблбцов: ");   /// запрашиваем количество столбцов (columns)
int[,] number = new int[rows, columns];
FillMatrixArrayRandomNumbers(number);
WriteMatrix(number);
if (rows == columns) // проверка на возможность замены строк на столбцы
{
    for (int i = 0; i < number.GetLength(0); i++)
    {  
         for (int j = 0; j < number.GetLength(1); j++) 
         {   
            if ( i == j) // условия для остановки действия
                break;
            else
            {                                // индекс J т.к. нужны столбцы
            int temp = number[i, j]; //меняем местами элементы массива строки на столбцы
            number[i, j] = number[j, i];
            number[j, i] = temp;
            }
         }    
    }
    WriteMatrix(number);
}
else
    Console.WriteLine(" Матрица не квадрат, решения нет ");



void FillMatrixArrayRandomNumbers(int[,] array)     //заполнение двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)   // цикл для заполнения строк
    {
        for (int j = 0; j < array.GetLength(1); j++)   // цикл для заполнения стодбцов
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)    // вывод двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)   // цикл для заполнения строк
    {
        for (int j = 0; j <array.GetLength(1); j++)   // цикл для заполнения стодбцов
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
