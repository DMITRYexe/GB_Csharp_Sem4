// Работа с массивами данных
// Создадим масштабируемый массив, в который мы можем сами вводить данные:

double [] temperature = new double [3]; // инициаллизируем массив и задаем ему размер
for (int i = 0; i < temperature.Length; i++) // цикл для ввода данных
{
 temperature[i]=int.Parse(System.Console.ReadLine());
}
double sum=0;
for (int i = 0; i < temperature.Length; i++) // цикл для подсечта суммы чисел массива
{
 sum = sum + temperature[i];
}
System.Console.WriteLine($"{sum/temperature.Length}"); // находим и выводим ср. арифметическое
