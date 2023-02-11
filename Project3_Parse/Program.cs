// Знакомство с оператором Parse.
int a;
bool f;
do
{
f= int.TryParse( Console.ReadLine(), out a);
if (f == false)
{
  System.Console.WriteLine("Error");
}
else
{
  System.Console.WriteLine($"{a}");
}
} while (f == false);
