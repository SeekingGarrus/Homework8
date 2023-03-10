// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int Prompt(string message)// функция ввода числа
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] Create2DArray(int row, int column) // функция создания двумерного массива int
{
    return new int[row, column];
}


void FillTwoArray(int[,] matr) // метод для заполнения двумерного массива рандомными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintTwoArray(int[,] matr) // Вывод на печать созданного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


void Summ(int[,] numbers) // метод находит строку с наименьшей суммой элементов
{
    int minSum = Int32.MaxValue;
    int indexLines = 0;

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            indexLines++;
        }
    }
    Console.WriteLine($"Cтрока {indexLines} с наименьшей суммой елементов равной: {minSum}");
}

int lines = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int[,] matrix = Create2DArray(lines, columns);
FillTwoArray(matrix);
PrintTwoArray(matrix);
Console.WriteLine();
Summ(matrix);