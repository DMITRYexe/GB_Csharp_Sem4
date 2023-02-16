/*Создать массив из 123 элементов. Заполнить случайными положительными числами от 0 до 1000.
Найти количество элементов которые принадлежат отрезку [10,99]. */
Console.WriteLine("Привет! Эта программа создает массив из 123 числе и заполняет его числами от 0 до 1000.");
System.Console.WriteLine("Затем она находит сколько чисел принадлежат отрезку [10,99]");
int [] Array123 = new int [123];
Random rndm = new Random();
ArrayInit(Array123);
PrintArray(Array123);
System.Console.WriteLine();
System.Console.WriteLine($"Количество чисел из диапазона [10;99]: {CounterDigitsAt10To99(Array123)}");


int [] ArrayInit (int [] array)
{
  for (int i = 0; i<array.Length; i++)
  {
    array[i]=rndm.Next(0,1001);
  }
  return array;
}

void PrintArray (int [] array)
{
  for (int i=0; i < array.Length; i ++)
  {
    System.Console.Write($"{array[i]} ");
  }
}

int CounterDigitsAt10To99 (int [] array)
{
  int counter = 0;
    for (int i = 0; i<array.Length; i++)
  {
    if (array[i]>=10 && array[i]<=99)
    {
      counter++;
    }
  }
  return counter;
}