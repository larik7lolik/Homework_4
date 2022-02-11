// Задача 26: Возведите число А в натуральную степень В используя цикл
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine());
int B = A * A * A * A * A ;
int result = A*B;
for ( A = 1; B >=0; B++)
{
    Console.WriteLine(result);
    break;

}

