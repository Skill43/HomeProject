Console.Write("Введите чиcло: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе чиcло: ");
int b = Convert.ToInt32(Console.ReadLine());

int i= a>b ? a : b;
Console.WriteLine($"Число {i} максимальное!");