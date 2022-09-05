Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7) Console.WriteLine("Выходной");
else Console.WriteLine("Будни");
