// Console.WriteLine("Введите пятизначное число: ");
// string number = Console.ReadLine();

// if (number?[0] == number?[4] && number?[1] == number?[3])
// {
//     Console.WriteLine("True");
// }
// else
// {
// Console.WriteLine("False");
// }

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже

      if (10000 > number || number > 99999)
{
    System.Console.WriteLine("Число не пятизначное");
    return false;
}
      int reverse = 0;
for (int i = number; i > 0; i = i / 10)
{
    int remain = i % 10;
    reverse = reverse * 10 + remain;
}
      if (number == reverse)
{
    return true;
}
else
{
    return false;
}
      
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 12327
        ;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}