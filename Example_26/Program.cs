// Задача 26: Возведите число А в натуральную степень В используя цикл
Console.Clear();
Console.WriteLine();
int a = new Random().Next(1,10);
int b = new Random().Next(1,10);
double exp(int basis, int extent)
{
    if (extent == 0)
    {
       return 1;
    }
    else return basis*exp(basis, extent-1);
}
Console.Write($"Введено значение А = {a}  и B = {b}");
Console.WriteLine($"  {a} возведенное в степень {b} равно {exp(a,b)}");

