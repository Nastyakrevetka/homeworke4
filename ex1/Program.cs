// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int level = int.Parse(Console.ReadLine());

for (; level > 0;)

{
    double result = Math.Pow(numb, level);
    Console.WriteLine($"{numb} в {level} степени равен: {result}");
    break;
}