// See https://aka.ms/new-console-template for more information
int num1, num2;
int sum = 0;
Console.WriteLine("first number:");

num1 = int.Parse(Console.ReadLine());

Console.WriteLine("last number:");

num2 = int.Parse(Console.ReadLine());

Console.Write("numbers found: ");
for (int i = num1; i < num2; i++)
{

    for (int timer = 1; timer < i; timer++)
    {

        if (i % timer == 0) sum += timer;
    }
    if (sum == i)
    {

        Console.Write(i + ", ");

    }

    sum = 0;
}   
    

