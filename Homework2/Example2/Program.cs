/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num100 = num % 10;

int num1000 = (num /10) % 10;

int num10000 = (num /100) % 10;

if (num < 100)
{
   Console.WriteLine("третьей цифры нет"); 
}
else if (num > 100 && num < 1000)
 {
    Console.WriteLine(num100); 
}
else if (num > 1000 && num < 10000)
 {
    Console.WriteLine(num1000);
 }
 else if (num > 10000 && num < 100000)
 {
    Console.WriteLine(num10000);
 }