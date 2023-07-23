// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);

int ShowSecondDigit (int num)
{
    int firstTwo = num / 10;
    int second = firstTwo % 10;
    return second;
}
int result = ShowSecondDigit(number);
Console.WriteLine($"Получилось: {result}");
*/

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

//ВАРИАНТ №1

// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumDigit (int num)                     
// {   
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;   
//     }
// return count;
// }

// void ThreeNum (int dig, int num)
// {
//     if (dig < 3)
//     { 
//         Console.Write("Третьей цифры нет!");
//     }
//     else
//     {   int count = 0;
//         while(count < dig - 3)
//         {
//             num = num / 10;
//             count++; 
//         }
//     int final = num % 10;
//     Console.WriteLine(final);
//     }
// }
// int digit = SumDigit (number);
// ThreeNum (digit, number);

//Вариант №2 (Тоже работает!)

// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumDigit (int num)                     
// {   
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;   
//     }
// return count;
// }

// void ThreeNum (int dig, int num)
// {
//     if (dig < 3)
//     { 
//         Console.Write("  Третьей цифры нет!");
//     }
//     else
//     {  
//         int count = 0;
//         count = dig - 3;
//         while (num >= 1000)
//         {
//             num = num / 10;
//             count++; 
//         }
//     int final = num % 10;
//     Console.WriteLine(final);
//     }
// }
// int digit = SumDigit (number);
// ThreeNum (digit, number);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет






