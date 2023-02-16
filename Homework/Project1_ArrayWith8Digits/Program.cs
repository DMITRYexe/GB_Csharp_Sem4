//41. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.WriteLine("Привет! Данная программа выводит массив из 8 элементов");
int [] array = new int [8];
ArrayIniciallization(array);
PrintArray(array);

int [] ArrayIniciallization (int [] a)
{
for (int i = 0; i<array.Length-1; i++)
{
  if (i%2==0) array[i]=1;
  else array[i]=0;
}
return a;
}

void PrintArray (int [] a)
{
for (int i = 0; i<array.Length; i++)
{
System.Console.Write($"{array[i]} ");
}
}