// seminar primer 1
Console.WriteLine("Введите число: ");
int number=int.Parse(Console.ReadLine());
//matem put
int sqr=number*number;
Console.WriteLine($"Квадрат числа {number} равен = {sqr}");

//biblioteka
int sqrl=Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"Квадрат числа {number} равен = {sqrl}");
double number2 = 3.3;
double sqr2=(Math.Pow(number2, 2));
Console.WriteLine($"Квадрат числа {number} равен = {Math.Round(sqr2, 2)}");