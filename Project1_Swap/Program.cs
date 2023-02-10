// Свап чисел местами
int a = 4, b = 8;
Console.WriteLine($"{a} и {b}");
void Swap(int one, int two) // передача по значению (value) (a и b не меняются. меняются только one и ецщ)
{
  int t;
  t = one;
  one = two;
  two = t;
}
Swap(a,b);
Console.WriteLine($"{a} и {b}");
void Swap2(ref int one, ref int two) // передача по ссылке ( references )
{
  int t;
  t = one;
  one = two;
  two = t;
}
Swap2(ref a, ref b);
Console.WriteLine($"{a} и {b}");
// если мы не хотим исп. 3юю перменную:
a = a + b;
b = a - b;
a = a - b;
Console.WriteLine($"{a} и {b}");