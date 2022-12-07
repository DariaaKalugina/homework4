Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int d = a;
for (int i = 1; i < b; i++)
{
    d = d * a;
}
Console.WriteLine ($"А в степени В: {d} ");
