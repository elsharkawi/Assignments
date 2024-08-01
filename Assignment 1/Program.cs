using System.ComponentModel.Design;

Console.WriteLine("Calculator");
Console.WriteLine("Choose your operation");
Console.WriteLine("Press 1 if Addition");

Console.WriteLine("Press 2 if Subtraction");

Console.WriteLine("Press 3 if Multiplication");

Console.WriteLine("Press 4 if Division");

int operation = int.Parse (Console.ReadLine());

Console.WriteLine("Enter your first number");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter your Second number");
double num2 = double.Parse(Console.ReadLine());

if (operation == 1) 
{
    double result = num1 + num2;
    Console.WriteLine("result of Addition ="+result);
    
}
else if (operation == 2)
{
    double result = num1 - num2;
    Console.WriteLine("result of Subtraction =" + result);
}
else if (operation == 3)
{
    double result = num1 * num2;
    Console.WriteLine("result of multiplication =" + result);
}
else if(operation == 4)
{
    double result = num1 / num2;
    Console.WriteLine("result of division =" + result);
}

Console.WriteLine("thank you");





