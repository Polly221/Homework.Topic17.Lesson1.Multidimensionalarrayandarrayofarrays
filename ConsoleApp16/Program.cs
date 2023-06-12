int[][] mas = new int[3][];
mas[0] = new int[5] { 1, 3, 6, 5, 4 };
mas[1] = new int[3] { 3, 4, 7 };
mas[2] = new int[4] { 2, 5, 6, 8 };
Console.WriteLine("Введите номер строки: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 0; i < mas.Length; i++)
{
    for (int j = 0; j < mas[i].Length; j++)
    {
            mas[n-1][k-1] = m;
        Console.Write(mas[i][j] + " ");
    }
    Console.WriteLine();
}
