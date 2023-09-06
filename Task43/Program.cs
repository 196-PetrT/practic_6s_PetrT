// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, 
// b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int SetNumber(string message = " ") // добавим метод для получения чисел вводом с консоли
{
  System.Console.Write($"Enter number {message} : ");
  return Convert.ToInt32(Console.ReadLine());
}

int factorB1 = SetNumber("b1");
int factorK1 = SetNumber("k1");
int factorB2 = SetNumber("b2");
int factorK2 = SetNumber("k2");

Console.WriteLine($"{(factorK1 == factorK2 ? "прямые параллельны или совпадают" : "прямые пересекаются в точке :")}");

if (factorK1 < factorK2 || factorK1 > factorK2) 
{
double x = (factorB2 - factorB1) / (factorK1 - factorK2);
double y = factorK1 * x + factorB1;
Console.Write($"{x}, {y}");
}


