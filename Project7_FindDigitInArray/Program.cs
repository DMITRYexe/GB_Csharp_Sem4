// 44. Определить, присутствует ли в заданном массиве, некоторое число
// Будет использовать линейный поиск. Есть еще бинарный, но он потруднее (позже).
int [] a = new int [10];
Random random = new Random (); // инициализация переменной "random"
for (int i = 0; i < a.Length; i++)
{
  a[i]=random.Next(0,10);
  Console.Write(a[i]);
}
System.Console.WriteLine();

int find = 5; //ищем это число
int j = 0;
while (j<a.Length && a[j]!=find) j++;
if ( j == a.Length)
System.Console.WriteLine("Числа нет");
else 
System.Console.WriteLine($"Индекс искомого числа: {j}");