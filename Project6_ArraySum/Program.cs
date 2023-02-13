//42. Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
// Найти сумму положительных/отрицательных элементов массива
int[] a = new int[12];
Random random = new Random();
for (int i = 0; i < a.Length; i++)
{
  a[i] = random.Next(-9, 10);
}
for (int i = 0; i < a.Length; i++)
{
  Console.Write($"{a[i]} ");
}
int sumPlus = 0;
int sumMinus = 0;
for (int i = 0; i < a.Length; i++)
{
  if (a[i]>=0)
  {
  sumPlus = sumPlus + a[i];
  }
  else sumMinus = sumMinus + a[i];
}
System.Console.WriteLine();
System.Console.WriteLine(sumPlus);
System.Console.WriteLine(sumMinus);

