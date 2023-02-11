// Проверка правильности выполнения команды
try
{
int i = Convert.ToInt32(Console.ReadLine());
}
catch
{
System.Console.WriteLine("Error!");
}

try
{
int i = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
System.Console.WriteLine(ex.Message);
}
