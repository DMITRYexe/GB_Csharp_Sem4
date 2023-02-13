//49. В указанном массиве целых чисел найдите разницу между максимальным и минимальным элементом
int [] a = new int [3];
Random random = new Random();
for ( int i = 0; i<a.Length; i++)
{
  a[i]=random.Next(0,10);
  System.Console.Write($"{a[i]} ");
}
int min=a[0], max=a[0];
for ( int i = 1; i<a.Length; i++)
{
  if (a[i]<min)
  {
    min=a[i];
  }
    if (a[i]>max)
  {
    max=a[i];
  }
}
System.Console.WriteLine();
System.Console.WriteLine($"Минимальное: {min}, максимальное: {max}");

int dif = max - min;
System.Console.WriteLine($"Разница: {dif}");