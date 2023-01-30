Console.Clear();
Console.Write("Введите число:  ");
int number =int.Parse(Console.ReadLine());

if (number<99 || number>999) {Console.Write("Вы вели неверное число. Введите трехзначное число  ");
   number =int.Parse(Console.ReadLine());
}

int i=number % 10;
Console.Write($"Последняя цифра числа {number} это цифра {i}");
