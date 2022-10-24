// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
//456 -> 5
//782 -> 8
//918 -> 1


Console.WriteLine("Программа, на выходе показывает вторую цифру введенного трехзначного числа");
Console.WriteLine("Введите число: ");
int Digit = int.Parse(Console.ReadLine()!);

int OutSecondDigit(int Digit)
{
    int firstDigit = Digit/100;
    int secondDigit = (Digit - firstDigit*100)/10;
    int thirdDigit = Digit % 10;
    return (secondDigit);
}

Console.WriteLine("Вторая цифра введенного числа: " + OutSecondDigit (Digit));