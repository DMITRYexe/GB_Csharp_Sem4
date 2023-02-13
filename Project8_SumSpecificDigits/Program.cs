//47. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int [] a = new int [3];
Random random = new Random();
for ( int i = 0; i<a.Length; i++)
{
  a[i]=random.Next(0,10);
  System.Console.Write($"{a[i]} ");
}
int sum1=0;
for ( int i =0 ; i<a.Length; i++)
{
  if (i%2==0) // потому что индекс идет с 0, а счет с 1
  {
    sum1=sum1+a[i];
  }
}
System.Console.WriteLine();
System.Console.WriteLine(sum1);
