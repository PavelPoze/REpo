/*
Задача 48: Задайте двумерный массив.
 найти эл-ты у которых нечетные индексы и заментить эти эл-ты на их квадраты
*/
int m = ReadInt("Введите число строк: ");     //зарашиваем количество срок (rows)
int n = ReadInt("Введите число стоблбцов: ");
int[,] number = new int[m,n];   // создаем двумерный массив исходя из введенных данных
for (int i = 0; i < number.GetLength(0); i++)  // проверка по строкам, что эл-т находит в нужном диапозоне
{
    for (int j = 0; j < number.GetLength(1); j++)   // проверка по столбцам
    {
        number[i,j] = i + j;
        if (i%2 != 0 && j%2 != 0)// если индекс эл-та не четный,(/2 без остатка) то он будет умножен на себя
            number[i,j] *= number[i,j]; // перемножение искомых эл-тов 
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
