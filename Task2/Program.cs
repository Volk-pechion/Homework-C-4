// Задача 2: Написать программу, которая принимает на вход число и выдает сумму цифр в числе

int promt(string message)
{
   System.Console.Write(message); 
   string param = Console.ReadLine();
   return int.Parse(param);
}

int number = promt("Ведите число: ");
int summa = 0; 

while(number!=0)
{
    summa = summa + number % 10;
    number = number / 10;
}
System.Console.WriteLine($"Сумма чисел равна: {summa}");
