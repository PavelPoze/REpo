// создание двумерного массива
/*
int rows = ReadInt("Введите число строк: ");     //зарашиваем количество срок (rows)
int columns = ReadInt("Введите число стоблбцов: ");   /// запрашиваем количество столбцов (columns)
int[,] number = new int[rows, columns];
FillMatrixArrayRandomNumbers(number);
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


/*
Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
int m = ReadInt("Введите число строк: ");     //зарашиваем количество срок (rows)
int n = ReadInt("Введите число стоблбцов: ");
int[,] number = new int[m,n];
for (int i = 0; i < number.GetLength(0); i++)
{
    for (int j = 0; j < number.GetLength(1); j++)
    {
        number[i,j] = i + j;
    }
}
WriteMatrix(number);


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
