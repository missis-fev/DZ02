// Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Программа, на выходе показывает вторую цифру введенного трехзначного числа");
Console.WriteLine("Введите число: ");
int Digit = int.Parse(Console.ReadLine()!);

 if (Digit < 99)
    {
        Console.WriteLine("Третьей цифры нет");
    
    }
    else
    {
int OutThirdDigit(int Digit)
{
     
    if (Digit > 999)
    {
        Digit = Digit /100;
    }
   
    int firstDigit = Digit/100;
    int secondDigit = (Digit - firstDigit*100)/10;
    int thirdDigit = Digit % 10;
    return (thirdDigit);


}

Console.WriteLine("Третья цифра введенного числа: " + OutThirdDigit (Digit));
    }

