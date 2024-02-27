using System.Formats.Asn1;

class Program
{
  static void Main()
  {
    const int n = 3;
    double sum = 0;
    double biggest = 0;
    double nearest = Math.Pow(10, 10);
    for (int i = 0; i < n; i++)
    {
      Console.WriteLine($"Труегольник #{i + 1} ");
      double height, side;
      EnterTriangle(out height, out side);
      Console.WriteLine($"side = {side} , height = {height}, area = {GetTriangleArea(height, side)}");
      double area = GetTriangleArea(height, side);
      sum += area;
      if (area > biggest) biggest = area;
      if (Math.Abs(37 - nearest) > Math.Abs(37 - area)) nearest = area;
    }
    Console.WriteLine($"Наибольшая площадь: {biggest}");
    Console.WriteLine($"Сумма всех площадей: {sum}");
    Console.WriteLine($"Площадь, ближайшая к числу 37: {nearest}");

  }
  static void EnterTriangle(out double height, out double side)
  {
    Console.Write("Введите высоту треугольника: ");
    height = Convert.ToDouble(Console.ReadLine());
    while (height <= 0)
    {
      Console.Write("Данные неверны. Введите высоту треугольника: ");
      height = Convert.ToDouble(Console.ReadLine());
    }

    Console.Write("Введите сторону треугольника: ");
    side = Convert.ToDouble(Console.ReadLine());
    while (side <= 0)
    {
      Console.Write("Данные неверны. Введите сторону треугольника: ");
      side = Convert.ToDouble(Console.ReadLine());
    }
  }
  static double GetTriangleArea(double height, double side)
  {
    return ((1.0 / 2.0) * height * side);
  }
}