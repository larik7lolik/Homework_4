//Задача 28: Подсчитать сумму цифр в числе.
//Сделать проверку на дурака
//Создать цикл, который будет считать остаток от деления на 10, 
//потом у этого числа удалять последнюю цифру за счет деления на 10 
//и складывать в другой переменной значения остатка.
string numberStr = String.Empty; 
int number = 0;
int sum = 0;
int numberOst = 0;
while(number <= 0)
{
    Console.Write("Введите положительное число: ");
    numberStr = Console.ReadLine();
    int.TryParse(numberStr, out number);
}

for(int i = 0; i < numberStr.Length; i++)
{
    numberOst = number % 10;
    number = number / 10;
    sum = sum + numberOst;
    //Console.WriteLine(numberOst);
}
Console.WriteLine();
Console.WriteLine($"Сумма цифр в числе = {sum}");


/* Console.WriteLine();
int var28 = new Random().Next(1,1000);
int summary(int num)
 {
    if (num<10)
    {
        return num;
    } 
    else return num%10+summary(num/10);
}
Console.WriteLine($"Для числа {var28} сумма чисел равна {summary(var28)}");
 */