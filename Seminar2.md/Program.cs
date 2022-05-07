void ReduceNumber()
{
    int num = new Random().Next(100, 999);
    Console.Write(num + " -> ");
    int firstNum = num / 100;
    int secondNum = num % 10;
    int thirdNum =  firstNum * 10 + secondNum;

    Console.Write(thirdNum);
}

ReduceNumber();