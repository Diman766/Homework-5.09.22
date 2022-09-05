Console.WriteLine("Введите 3-х значное число");
string Arr   = Console.ReadLine();
int size = Convert.ToInt32(Arr.Length);
if (size>=3) Console.WriteLine(Arr[2]);
else Console.WriteLine("Число меньше 3-х символов !!!");

