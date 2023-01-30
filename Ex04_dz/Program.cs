// Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число:  ");
int a =int.Parse(Console.ReadLine());
Console.Write("Введите второе число:  ");
int b=int.Parse(Console.ReadLine());
Console.Write("Введите третье число:  ");
int c=int.Parse(Console.ReadLine());

if (a>b && a>c) {Console.Write($"max= {a}");}
if (b>a && b>c) {Console.Write($"max= {b}");}
if (c>a && c>b) {Console.Write($"max= {c}");}