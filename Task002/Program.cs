// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Text(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Summa(int number)
{
int sum = 0;
while (number > 0)
{
    sum += number%10;
    number = number/10;    
}
return sum;
}

//_______________________________________________


int number = Text("Введите число: ");
    Console.WriteLine(Summa(number));