using System.Xml.XPath;

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите основание: ");
// int baseNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень: ");
// int degree = Convert.ToInt32(Console.ReadLine());


// int GetPow (int baseNumber, int degree)
// {
// double res = 0;
// for (int i=1; i <=degree;i++)
// {
//    res=Math.Pow(baseNumber,i);
// }
// return (int)res;
// }

// Console.WriteLine($"{baseNumber} в степени {degree} = {GetPow (baseNumber,  degree)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int len = numberLength(number);

Console.WriteLine($"Сумма цифр в числе {number} = {numberSum(number, len)}");


int numberLength(int number) //Находим длину числа
{
int index = 0;
while (number > 0)
{
number /= 10;
index++;
}
return index;
}


 int numberSum (int number, int len) //Находим сумму чисел
 {
 int sum = 0;
 for (int i = 1; i <= len; i++)
 {
 sum += number % 10;
 number /= 10;
//  Console.WriteLine(number);
 }
 return sum;
 }
        