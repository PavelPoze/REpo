

/*  Денис: Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */
int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);

int[] revertNumbers = new int[size];
for (int i = 0; i < revertNumbers.Length; i++)
{
    revertNumbers[i] = numbers[numbers.Length - 1 - i];
}
WriteArray(revertNumbers);

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("[" + String.Join(" -> ", numbers) + "] -> " + sum);
Console.WriteLine($"[{String.Join(" -> ", numbers)}] -> {sum}");




Console.WriteLine($"Задача 41. Cколько чисел больше 0 ввёл пользователь \n");
Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");