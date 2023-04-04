// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int numN = int.Parse(Console.ReadLine());

int num1 = numN / 10000;
int num2 = (numN % 10000) / 1000;
int num4 = (numN % 100) / 10;
int num5 = numN % 10;

   if (num1 == num5 && num2 == num4)
   {
      Console.WriteLine("число является палиндромом");
   }
   else if (numN > 9999 && numN < 100000 && num1 != num5 && num2 != num4)
   {
      Console.WriteLine("число не является палиндромом");
   }
   else
   {
      Console.WriteLine("Введено не пятизначное число");
   }



