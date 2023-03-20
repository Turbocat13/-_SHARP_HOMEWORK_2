// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n % 100;
int n2 = m / 10;

Console.WriteLine(n2);

// напишите программу, кот. выводит случайное трёхзначное число и удаляет вторую цифру этого числа
//int n = new Random().Next(100, 1000); 
//Console.WriteLine($"Случайно сгенированное число {n}");
//int n1 = n / 100;
//int n3 = n % 10;
//Console.WriteLine(n1 * 10 + n3);