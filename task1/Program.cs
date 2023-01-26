/*Дано число обозначающее день недели. Выяснить является номер дня недели выходным
По двум заданным числам проверять является ли одно квадратом другого
Задать номер четверти, показать диапазоны для возможных координат
Найти расстояние между точками в пространстве 2D/3D
int number = 6;
if (number == 1) Console.WriteLine ("не выходной");
if (number == 2) Console.WriteLine ("не выходной");
if (number == 3) Console.WriteLine ("не выходной");
if (number == 4) Console.WriteLine ("не выходной");
if (number == 5) Console.WriteLine ("не выходной");
if (number == 6) Console.WriteLine ("выходной");
if (number == 7) Console.WriteLine ("выходной");*/

Console.WriteLine ("Введите день недели ");
int number = int.Parse (Console.ReadLine());
while (number < 1 || number > 7)
{
    Console.WriteLine ("Дни недели имеют порядковые номера от 1 до 7, введите повторно ");
    number = int.Parse (Console.ReadLine());
}
if (number >= 1 && number <=5) Console.WriteLine ("не выходной");
if (number == 7 || number == 6) Console.WriteLine ("выходной");