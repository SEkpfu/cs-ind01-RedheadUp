class Program
{
  static void Main()
  {
    Console.Write("Введите число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    double minMultiple = Math.Pow(10, 9);
    int NegativesIndex = 100;
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
      for (int j = 0; j < m; j++)
      {
        Console.Write($"Введите число #{i + 1}#{j + 1}: ");
        array[i, j] = Convert.ToInt32(Console.ReadLine());
      }
    }

    for (int i = 0; i < n; i++)
    {
      double multiple = 1;
      bool check = true;
      for (int j = 0; j < m; j++)
      {
        multiple *= array[i, j];

        if (array[i, j] >= 0)
        {
          check = false;
          break;
        }
      }
      if (minMultiple > multiple) minMultiple = multiple;
      if (check)
      {
        NegativesIndex = i;
        break;
      }

    }

    Console.WriteLine($"Строка, в которой все элементы отрицательны: строка #{NegativesIndex + 1}");
    Console.WriteLine($"Минимальное произведение в строке: {minMultiple}");
  }
}