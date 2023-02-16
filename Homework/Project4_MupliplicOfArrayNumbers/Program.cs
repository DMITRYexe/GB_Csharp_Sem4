/*48. Задан массив a из N элементов. 
Заполнить массив случайными числами от 1 до 10. 
Создайте массив, который является произведением пар чисел в одномерном массиве a. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
*/
Console.WriteLine("Привет! Данная программа перемножает пары чисел из массива (первое с последним и т.д.)");
System.Console.WriteLine("Задайте размер массива (целое число больше нуля): ");
int N = InputN();
int[] Array = new int[N];
Random rndm = new Random();
InitArray(Array);
System.Console.WriteLine("Сгенерированный массив: ");
OutputArray(Array);
System.Console.WriteLine();
System.Console.WriteLine("Результат перемножения: ");
MultiplyingPairsOfDigitsFronArray(Array);








int InputN()
{
  int x = 0;
Start:
  try
  {
    x = Convert.ToInt32(Console.ReadLine());
  }
  catch
  {
    System.Console.WriteLine("Ошибка! Введите целое число больше 0");
  }
  if (x < 1)
  {
    System.Console.WriteLine("Ошибка! Введите целое число больше 0");
    goto Start;
  }
  return x;
}

int[] InitArray(int[] a)
{
  for (int i = 0; i < a.Length; i++)
  {
    a[i] = rndm.Next(0, 11);
  }
  return a;
}

void OutputArray(int[] a)
{
  for (int i = 0; i < a.Length; i++)
  {
    Console.Write($"{a[i]} ");
  }
}

void MultiplyingPairsOfDigitsFronArray(int[] a)
{
    if (a.Length % 2 == 0)
    {
    for (int i = 0; i < a.Length / 2; i++)
      {
        int a1 = a[i];
        int a2 = a[a.Length - i - 1];
        System.Console.Write($"{a1 * a2}; ");
      }
    }
    else
    {
    for (int i = 0; i < a.Length / 2; i++)
      {
        int a1 = a[i];
        int a2 = a[a.Length - i - 1];
        System.Console.Write($"{a1 * a2}; ");
      }
      System.Console.Write($"{a[a.Length-(a.Length/2)-1]}.");
    }
}