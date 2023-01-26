//По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine ("Введите число1 ");
int number1 = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите число2 ");
int number2 = int.Parse (Console.ReadLine());
if (number1 * number1 == number2) Console.WriteLine ("Число1 являетя квадратом Числа2");
if (number2 * number2 == number1) Console.WriteLine ("Число2 являетя квадратом Числа1");
if (number1 * number1 != number2 && number2 * number2 != number1) Console.WriteLine ("Числа не являются квадратами друг друга");