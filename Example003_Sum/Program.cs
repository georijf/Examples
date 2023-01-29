int numberA = new Random().Next(1, 10);
Console.WriteLine($"Первое рандомное число в диапозоне от 1 до 10 это: {numberA}");
int numberB = new Random().Next(1, 10);
Console.WriteLine($"Второе рандомное число в диапозоне от 1 до 10 это: {numberB}");
int result = numberA + numberB;
Console.WriteLine($"Сумма рандомных чисел: {result}");