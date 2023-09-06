// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы(через пробел): ");
int[] result = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int GetSumMoreZerro()
{
  int count = 0;
  for (int i = 0; i < result.Length; i++)
  {
    if (result[i] > 0) count++;
  }
  return count;
}

Console.WriteLine($"Количество чисел больше 0: {GetSumMoreZerro()}");
