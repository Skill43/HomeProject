Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int result = b > a ? b :a;
result = result > c ? result : c;
System.Console.WriteLine("Максимальное число: "+""+ result);
int res = b < a ? b :a;
res = res < c ? res : c;
System.Console.WriteLine("Минимальное число: "+""+ res);