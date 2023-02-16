/* 45. Задать массив, заполнить случайными положительными трёхзначными числами. 
Показать количество нечетных\четных чисел */
System.Console.WriteLine("Привет! Данная программа создает рандомный массив из трехзначных чисел и считает кол-во четных и нечетных чисел");
Random random = new Random();
int Value = random.Next(1,101);
System.Console.WriteLine($"Сгенерирован размер массива (из диапазона 1...100): {Value}");
int [] Array = ArrayInit(Value);
System.Console.WriteLine($"Сгенерированные значения для массива");
PrintArray(Array);
System.Console.WriteLine();
System.Console.WriteLine($"Четных чисел в массиве: {CounterOfEvenInArray(Array)}");
System.Console.WriteLine($"Нечетных чисел в массиве: {CounterOfOddInArray(Array)}");


int [] ArrayInit (int val)
{
  int [] array = new int [val];
  for (int i = 0; i<array.Length; i++)
  {
    array[i]=random.Next(100,1000);
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

int CounterOfEvenInArray (int [] a)
{
  int counter=0;
  for (int i =0; i<a.Length; i++)
  {
    if (a[i]%2==0)
    {
      counter++;
    }
  }
  return counter;
}

int CounterOfOddInArray (int [] a)
{
  int counter=0;
  for (int i =0; i<a.Length; i++)
  {
    if (a[i]%2!=0)
    {
      counter++;
    }
  }
  return counter;
}