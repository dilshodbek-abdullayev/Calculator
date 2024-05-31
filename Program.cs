using System;

repeat1:
Console.WriteLine("Enter first number");
double numberOne = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number");
double numberTwo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Choose arifmetic operators");
    repeat:
Console.WriteLine($"1 => + \t\t\t5 => {numberOne} power of {numberTwo} \n2 => - \t\t\t6 => {numberTwo} power of {numberOne} \n3 => * \t\t\t7 => Square root {numberOne}\n4 => / \t\t\t8 => Square root {numberTwo}");
int number = Convert.ToInt32(Console.ReadLine());
if(number <1 || number >8){
    Console.WriteLine("Please enter a number between 1 and 8");
    goto repeat;
}
switch(number)
{
    case 1: MethodByAdding(numberOne,numberTwo);
        break;
    case 2: MethodBySubtracted(numberOne,numberTwo);
        break;
    case 3: MethodByMultiplied(numberOne,numberTwo);
        break;
    case 4: MethodByDivided(numberOne,numberTwo);
        break;
    case 5: MethodByPowerFirstToSecond(numberOne,numberTwo);
        break;
    case 6: MethodByPowerSecondToFirst(numberOne,numberTwo);
        break;
    case 7: MethodBySquareFirst(numberOne);
        break;
    case 8: MethodBySquareSecond(numberTwo);
        break;
    default: Console.WriteLine("Thank you");
        break; 
}
Console.WriteLine("Do you want to do it again?\n[y/n]");
string txt = Console.ReadLine();
txt = txt.ToLower();
if(txt == "y")
{
    goto repeat1;
}
Console.WriteLine("Thank you");

static void MethodByAdding(double first, double second)
{
    Console.WriteLine($"{first} + {second} = {first+second}");
}

static void MethodBySubtracted(double first,double second)
{
    Console.WriteLine($"{first} - {second} = {first-second}");
}

static void MethodByMultiplied(double first,double second)
{
    Console.WriteLine($"{first} * {second} = {first*second}");
}

static void MethodByDivided(double first, double second)
{
    Console.WriteLine($"{first} / {second} = {first/second}");
}
static void MethodByPowerFirstToSecond(double first , double second)
{
    Console.WriteLine($"{first} ^ {second} = {Math.Pow(first,second)}");
}
static void MethodByPowerSecondToFirst(double first , double second)
{
    Console.WriteLine($"{second} ^ {first} = {Math.Pow(second,first)}");
}
static void MethodBySquareFirst(double first)
{
    Console.WriteLine($"square root {first} is = {Math.Sqrt(first)}");
}
static void MethodBySquareSecond(double second)
{
    Console.WriteLine($"square root {second} is = {Math.Sqrt(second)}");
}






