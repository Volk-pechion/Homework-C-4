// Задача 1: Написать циклб который принимает на вход два чмсла (А и В)
// и возводит число А в натуральную степень В

int promt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int A = promt("Введите число A");
int B = promt("введите число B");
int count = 0;
int DegreeA = 1;

while (count<B)
{
    count++;
    System.Console.WriteLine(DegreeA=DegreeA*A);
}