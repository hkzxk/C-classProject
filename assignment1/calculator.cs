// See https://aka.ms/new-console-template for more information


Console.WriteLine("enter the first number : ");

string op1 = Console.ReadLine();
Console.WriteLine("enter the operator : ");
string oper = Console.ReadLine();
Console.WriteLine("enter the second number : ");
string op2 = Console.ReadLine();

if (oper == "+")
{
    Console.WriteLine(double.Parse(op1) + double.Parse(op2));

}
else if (oper == "-")
{
    Console.WriteLine(double.Parse(op1) - double.Parse(op2));

}
else if (oper == "*")
{
    Console.WriteLine(double.Parse(op1) * double.Parse(op2));
}
else if (oper == "/")
{
    Console.WriteLine(double.Parse(op1) / double.Parse(op2));
}
else
{
    Console.WriteLine("operator is inlegal!");
}

    