// Задача 30: Показать кубы чисел, заканчивающихся на четную цифру.
/* Console.Clear(); 
for(int i = 2; i < 10; i+=2)
{
    Console.WriteLine(i * i * i);
} */

Console.Clear(); 
int n = 10;
int[] mass = new int[n/2];
int j = 2;
for(int i = 0; i < n/2; i++)
{
    Console.WriteLine(j * j * j);
    mass[i] = j*j*j;
    j+=2;
} 
