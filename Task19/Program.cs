// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int rev = 0;

int pal(int num, int reverse)
{
    while (num > 0)
    {
        int number2 = num % 10;
        int result = reverse * 10 + number2;
        num = num / 10;
        reverse = result;
    }
    return reverse;
}
if (number < 10000 && number > 99999)
{
    Console.WriteLine("Ошибка! Число не пятизначное.");
}
else
{
    int result = pal(number, rev);
    Console.WriteLine(number == result
     ? "Это палиндром" 
     : "Это не палиндром");
}