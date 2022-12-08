
/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12  */
int m = ReadInt("Введите число строк: ");     //зарашиваем количество срок (rows)
int n = ReadInt("Введите число стоблбцов: ");

int[,] number = new int[m,n];   // создаем двумерный массив исходя из введенных данных
int sum = 0;
FillMatrixArrayRandomNumbers(number);
WriteMatrix(number);
for (int i = 0; i < number.GetLength(0); i++)  // проверка по строкам, что эл-т находит в нужном диапозоне
{
   
    {
      if (i < number.GetLength(1))
      sum += number[i,i];
    }
}
Console.WriteLine(sum);

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
