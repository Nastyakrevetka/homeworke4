//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10

Console.WriteLine("введите число: ");
int numb = int.Parse(Console.ReadLine());
int sum = 0;
while (numb > 0)
{

    sum = sum + numb % 10;
    numb = numb / 10;

}
Console.WriteLine($"сумма цифр числа {numb} равна: {sum}");