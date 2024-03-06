using System.Diagnostics.Contracts;

class Program
{
  static void Main()
  {
    Console.Write("Введите число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[] x_array = new double[n];
    double[] y_array = new double[n];
    for (int i = 0; i < n; i++)
    {
      Console.WriteLine($"Введите число #{i + 1}: ");
      x_array[i] = Convert.ToDouble(Console.ReadLine());
      y_array[i] = f(x_array[i]);
    }
    for (int i = 0; i < n; i++)
    {
      Console.WriteLine($"#{i + 1} x = {x_array[i]}\t y = {y_array[i]}");
    }
    int TruePointCounter = 0;
    double max_difference = 0;
    int indexOf_farthest = -1;
    for (int i = 0; i < n; i++)
    {
      double x = x_array[i];
      double y = y_array[i];
      if (IsInArea(x, y))
      {
        TruePointCounter++;
      }
      else
      {
        Console.WriteLine($"Точка с координатами ({x}, {y}) не принадлежит заштрихованной области. ");
        Console.WriteLine($"Расстояние от точки ({x}, {y}) до (0, 0): {Math.Sqrt(x * x + y * y)}");
        if (x <= 0 && y >= 0)
        {
          if (Math.Abs(0 - y) > max_difference)
          {
            max_difference = Math.Abs(0 - y);
            indexOf_farthest = i;
          }
        }
      }
    }
    Console.WriteLine($"Количество точек, принадлежащих заштрихованной области: {TruePointCounter}");
    if (indexOf_farthest != -1)
    {
      Console.WriteLine($"Точка с координатами ({x_array[indexOf_farthest]}, {y_array[indexOf_farthest]}) лежит во II четверти и дальше всех от оси OX.");
    }
    else
    {
      Console.WriteLine("Точек, лежащих во II четверти нет.");
    }

  }
  static double f(double x)
  {
    if (x < -3)
    {
      return (((1 + Math.Pow(x, 3)) / (2 * x)) * ((x + 4) / (Math.Pow(x, 2) - (1 / x))));
    }
    else if (x >= -3 && x < 2 * Math.PI)
    {
      return ((Math.Pow(x, 2) - 3) * Math.Sin(2 * x));
    }
    else
    {
      return 2.0 + (1.0 /3.0);
    }
  }
  static bool IsInArea(double x, double y)
  {
    if (y >= 0 && x <= 0)
    {
      if (y <= x + 10) return true;
    }
    else if (y < 0)
    {
      if (x <= 0)
      {
        if (x * x + y * y <= 10 * 10) return true;
      }
      else
      {
        if (y <= -5)
        {
          if (x * x + y * y <= 10 * 10) return true;
        }
      }
    }
    return false;
  }
}