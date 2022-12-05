Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

string result = (num % 2 == 0) ? $"Число {num} четное!" : $"Число {num} нечетное!";
System.Console.WriteLine(result);