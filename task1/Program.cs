//Console.WriteLine("Введите 3-х значное число");
//string Arr = Console.ReadLine();
//Console.WriteLine($"Вторая цифра {Arr[1]}");

Console.WriteLine("Введите 3-х значное число");
int number = Convert.ToInt32(Console.ReadLine());
int first = number/10;
number=first%10;

Console.WriteLine(number);