//Задача 1.
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void SecondNumber(int n)
{
    int secondnum = n / 10 % 10;
    Console.Write("Second digit is " + secondnum);
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

SecondNumber(num);
*/

//Задача 2.
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void ThirtNumber(int n)
{
    if (n / 100 > 0)
    {
        while (n / 1000 > 0)
        {
            n = n / 10;
        }
        n = n % 10;
        Console.WriteLine("The third digit is " + n);
    }
    else
    {
        Console.WriteLine("There is no third digit :(");
    }

}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
ThirtNumber(num);
*/

//Задача 3.
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void Week(int day)
{
    if(day > 7 || day < 1)
    {
    Console.WriteLine("Incorrect number of day!");
    }
    else
    {
        if (day == 6 ^ day == 7)
        {
            Console.WriteLine("It's the weekend");
        }
        else
        {
            Console.WriteLine("it's a working day");
        }
    }
}

Console.Write("Input number of weekday: ");
int num = Convert.ToInt32(Console.ReadLine());
Week(num);
*/