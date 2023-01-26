//Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine ("Введите номер четверти ");
int number1 = int.Parse (Console.ReadLine());
while (number1 < 1 || number1 > 4)
{
    Console.WriteLine ("Ведите числа от 1 до 4 ");
    number1 = int.Parse (Console.ReadLine());
}
if (number1 == 1) Console.WriteLine ("x={0;∞}, y={0;∞}");
if (number1 == 2) Console.WriteLine ("x={0;-∞}, y={0;∞}");
if (number1 == 3) Console.WriteLine ("x={0;-∞}, y={0;-∞}");
if (number1 == 4) Console.WriteLine ("x={0;∞}, y={0;-∞}");
