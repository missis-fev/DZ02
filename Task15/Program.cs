// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Программа, которая проверяет является ли день недели выходным");
Console.WriteLine("Введите число - день недели: ");
int numberW = int.Parse(Console.ReadLine()!);

if ((numberW > 0)&&(numberW < 8)) 
    {
    if ((numberW == 6)||(numberW == 7)) 
     {
        Console.WriteLine("Да");
     }
    else
        {
        Console.WriteLine("Нет");
       }
    }
   
else
  {
        Console.WriteLine("Ошибка ввода. Введите число от 1 до 7");
  }



//string Holiday(int numberW) 

//if (numberW > 7) Console.WriteLine("Нет");
//if (numberW < 1) Console.WriteLine("Нет");
//if (numberW ==6) Console.WriteLine("Да");
//if (numberW == 7) Console.WriteLine("Да");

  //  else 
   // Console.WriteLine("Ошибка ввода.\n Введите число от 1 до 7");
 //return (numberW);

