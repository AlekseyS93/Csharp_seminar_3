// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Text(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Power(int osnov, int stepen)
{
    int power = 1;
    for (int i = 1; i <= stepen; i++)
    {
        power *= osnov;
    }
    return power;
}

bool proverkaStepen(int stepen)
{
    if (stepen < 0)
    {
        Console.WriteLine("Показатель должен быть положительным");
        return false;
    }
    return true;
}

//__________________________________________________

int osnov = Text("Введите основание: ");
int stepen = Text("Введите основание: ");

if (proverkaStepen(stepen))
{
    Console.WriteLine($"Число {osnov} в степени {stepen} равно {Power(osnov, stepen)}");
}