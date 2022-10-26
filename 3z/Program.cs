// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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

double[] SumStolb(int[,] array)
{

    double[] summ = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        summ[i] = sum / array.GetLength(0);
    }
    return summ;
}

void printSum(double[] array)
{
    foreach (double el in array)
    {
        Console.Write(el + " ");
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
double[] srednArifm = SumStolb(array);
printSum(srednArifm);