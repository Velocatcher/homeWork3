using System.Xml.XPath;

Console.Write("Введите основание: ");
int baseNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());


int GetPow (int baseNumber, int degree)
{
double res = 0;
for (int i=1; i <=degree;i++)
{
   res=Math.Pow(baseNumber,i);
}
return (int)res;
}

Console.WriteLine($"{baseNumber} в степени {degree} = {GetPow (baseNumber,  degree)}");