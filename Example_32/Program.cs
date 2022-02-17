// Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран
Console.Clear();
int[] array = new int[8];
void FillArray(int[] collection) // метод заполнения одномерного массива случ.числами
{
    int length = collection.Length;
    for(int index = 0; index < length; index++)
    {
      collection[index] = new Random().Next(0,2); //[0,2) от 0 до 1, 2 не входит
    }
}

void PrintArray(int[] coll) // метод выведения и печати одномерного массива 
{
    int count = coll.Length;
    for(int position = 0; position < count; position++)
    {
        Console.Write($"{coll[position]}  ");
    }
}
FillArray(array);
PrintArray(array);