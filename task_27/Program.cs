Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToString(n).Length;
int s = 0;
for (int i = 0; i < c; i++)
 {
    int num = n % 10;
    n = n/10;
    s = s + num;
 }
 Console.WriteLine($"Сумма цифр в числе: {s} " );
