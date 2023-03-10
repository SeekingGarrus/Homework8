// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// (от большего к меньшему)

int SizeMassiv2D(string message) // задает размер матрицы
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteMassiv2D(int[,] matr) // Заполнение матрицы вручную
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
            matr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}


void PrintTwoArray(int[,] matr) // метод для вывода двумерного массива
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


void SelectionSort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) // метод сортировки массива от min к max
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k];
                    arr[i, k] = arr[i, k + 1];
                    arr[i, k + 1] = temp;
                }
            }
        }
    }
}


int lines = SizeMassiv2D("Введите кол-во строчек массива: ");
int columns = SizeMassiv2D("Введите кол-во столбцов массива: ");

int[,] matrix2D = new int[lines, columns];
WriteMassiv2D(matrix2D);
PrintTwoArray(matrix2D);
SelectionSort(matrix2D);
Console.WriteLine();
PrintTwoArray(matrix2D);