//Задача 28: Подсчитать сумму цифр в числе.
Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int num = int.Parse(str);
 //Console.WriteLine(str.Length);
  int i = 0;
 int Sum = 0;
 while(num!= 0 && i <= str.Length)
 {
     num = num / 10;
     Sum = num + i;
     i++;
     
 }
 Console.WriteLine(Sum);
