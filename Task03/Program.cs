// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента. Массив размером 2 x 2 x 2

int GetNumber(string text) // функция для ввода числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[,,] Create3DArray(int row, int column, int height) // функция создания двумерного массива int
{
    return new int[row, column, height];
}

void Fill3DArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(1, 101);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintThreeArray(int[,,] matr) // Вывод на печать созданного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for(int k = 0; k < matr.GetLength(2); k++) Console.WriteLine($"{matr[i, j, k]} ({i},{j},{k})");;
        }
        Console.WriteLine();
    }Console.WriteLine();
}


int x = GetNumber("Введите размер 1: ");
int y = GetNumber("Введите размер 2: ");
int z = GetNumber("Введите размер 3: ");

int[,,] array3D = Create3DArray(x, y, z);
Fill3DArray(array3D);
PrintThreeArray(array3D);