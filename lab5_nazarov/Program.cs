Console.Write("Введите целое число от 1 до 365: ");
int data = int.Parse(Console.ReadLine());

int a = (data % 7);
if (data > 365 || data < 1) Console.WriteLine("Вы ввели неверное число, пожалуйста введите число от 1 до 365");

if (a == 1) Console.WriteLine("Понедельник");
if (a == 2) Console.WriteLine("Вторник");
if (a == 3) Console.WriteLine("Среда");
if (a == 4) Console.WriteLine("Четверг");
if (a == 5) Console.WriteLine("Пятница");
if (a == 6) Console.WriteLine("Суббота");
if (a == 7) Console.WriteLine("Воскресенье");