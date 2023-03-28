// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
//Отсортировать элементы по возрастанию слева направо и сверху вниз.


Console.Write("Введите количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colCount = Convert.ToInt32(Console.ReadLine());

int[,] Array = GenerateArray(rowCount, colCount);
Console.WriteLine();
Console.WriteLine("Массив: ");
PrintArray(Array);

void Insert(bool isRow, int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
            dest[dim, k] = source[k];
        else
            dest[k, dim] = source[k];
    }
}

Console.WriteLine("Сортировка по строкам: ");
int[] row = new int[colCount];
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < colCount; j++)
        row[j] = Array[i, j];
    Sort(row);
    Insert(true, i, row, Array);
}
PrintArray(Array);

Console.WriteLine("Сортировка по столбцам: ");
int[] col = new int[rowCount];
for (int i = 0; i < colCount; i++)
{
    for (int j = 0; j < rowCount; j++)
        col[j] = Array[j, i];
    Sort(col);
    Insert(false, i, col, Array);
}
PrintArray(Array);

int[,] GenerateArray(int t, int i)
{
    int[,] table = new int[t, i];
    Random random = new Random();
    for (int a = 0; a < t; a++)
    {
        for (int b = 0; b < i; b++)
        {
            table[a, b] = random.Next(0, 10);
        }
    }
    return table;
}

void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a, b] + " ");
        }
        Console.WriteLine();
    }
}

void Sort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
}

Console.WriteLine();