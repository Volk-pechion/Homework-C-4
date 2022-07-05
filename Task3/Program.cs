// Задача 3: Написать программу, которая задает массив из 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции.

int[] RandomArray()
{
    int [] Array = new int [8];
    for (int i=0; i< Array.Length; i++)
    {
        Array[i]=new Random().Next(0, 100);
    }
    return Array;
}
void PrintArray(int[] Array)
{
    foreach (int el in Array)
    {
        if (el == Array[Array.Length-1])
        {
            System.Console.WriteLine($"{el}");
            break;
        }
        System.Console.Write($"{el} ");
        }
}
PrintArray (RandomArray());

