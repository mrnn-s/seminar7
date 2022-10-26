// Написать программу, которая обменивает элементы первой строки и последней строки
// Написать программу, которая обменивает элементы первой строки и последней строки
void FillMassiv(int[,] massiv)
{
    Random number = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = number.Next(-9, 10);
        }
    }
}

void PrintMass(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Change_Strok(int[,] array)
{
        for (int j = 0; j < array.GetLength(1); j++)
        {
        int terminal = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = array[0,j];
        array[0,j] = terminal;     
        }
}

Console.Write("Введите число (строк) m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число (столбцов) n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m, n];
FillMassiv(array);
PrintMass(array);
Console.WriteLine();
Change_Strok(array);
PrintMass(array);