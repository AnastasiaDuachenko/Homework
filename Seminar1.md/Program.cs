/*

// Задача 1. 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
    Console.WriteLine("The largest number is " + num1);
else
    Console.WriteLine("The largest number is " + num2);

*/

/*
// Задача 2.
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(max > num2)
    max = num1;
else
    max = num2;

if(max > num3)   
    Console.WriteLine("The largest number is " + max);
else
{
    max = num3;
    Console.WriteLine("The largest number is " + max);
}
 */

/*
 // Задача 3.
 //  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.   

Console.WriteLine("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine("The number is even");
else
    Console.WriteLine("The number is odd");
 */

/*
 // Задача 4.
 // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.   

 Console.WriteLine("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    int count = 1;
    while (count <= num)
    {
        if (count%2 == 0)
        {
            Console.Write(count);
            Console.Write(" ");
        }
        count+=1;
    }
}
if (num <= 0)
{
    int count = -1;
    while (count >= num)
    {
        if (count%2 == 0)
        {
            Console.Write(count);
            Console.Write(" ");
        }
        count+=-1;
    }
}
if (num == 0)
{
    Console.Write("There are no even numbers in the specified range");
}
*/


