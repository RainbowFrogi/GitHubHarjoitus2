using System;

int howMany = 0;
int num1, num2, num3, num4, sum;
int chose = 0;

Console.WriteLine("Write 1. if you want to plus");
Console.WriteLine("Write 2. if you want to minus");
Console.WriteLine("Write 3. if you want to multiply");
Console.WriteLine("Write 4. if you want to divide");
chose = Convert.ToInt32(Console.ReadLine());

while (chose < 1 && chose > 4)
{
    Console.WriteLine("Write 1. if you want to plus");
    Console.WriteLine("Write 2. if you want to minus");
    Console.WriteLine("Write 3. if you want to multiply");
    Console.WriteLine("Write 4. if you want to divide");
    chose = Convert.ToInt32(Console.ReadLine());
}

if (chose == 1)
{
    Console.WriteLine("How many numbers do you want to plus with(2-4)?");

    howMany = Convert.ToInt32(Console.ReadLine());

    while (howMany <= 2 && howMany >= 4)
    {
        howMany = Convert.ToInt32(Console.ReadLine());
    }

    switch (howMany)
    {
        case 2:
            Console.WriteLine("Give me 2 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            Console.WriteLine(sum);
            break;

        case 3:
            Console.WriteLine("Give me 3 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2 + num3;
            Console.WriteLine(sum);
            break;

        case 4:
            Console.WriteLine("Give me 4 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2 + num3 + num4;
            Console.WriteLine(sum);
            break;
    }
}

else if (chose == 2)
{
    Console.WriteLine("How many numbers do you want to minus with(2-4)?");

    howMany = Convert.ToInt32(Console.ReadLine());

    while (howMany <= 2 && howMany >= 4)
    {
        howMany = Convert.ToInt32(Console.ReadLine());
    }

    switch (howMany)
    {
        case 2:
            Console.WriteLine("Give me 2 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 - num2;
            Console.WriteLine(sum);
            break;

        case 3:
            Console.WriteLine("Give me 3 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            sum = num1 - num2 - num3;
            Console.WriteLine(sum);
            break;

        case 4:
            Console.WriteLine("Give me 4 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());

            sum = num1 - num2 - num3 - num4;
            Console.WriteLine(sum);
            break;
    }

}

else if (chose == 3)
{
    Console.WriteLine("How many numbers do you want to multiply with(2-4)?");

    howMany = Convert.ToInt32(Console.ReadLine());

    while (howMany <= 2 && howMany >= 4)
    {
        howMany = Convert.ToInt32(Console.ReadLine());
    }

    switch (howMany)
    {
        case 2:
            Console.WriteLine("Give me 2 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 * num2;
            Console.WriteLine(sum);
            break;

        case 3:
            Console.WriteLine("Give me 3 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            sum = num1 * num2 * num3;
            Console.WriteLine(sum);
            break;

        case 4:
            Console.WriteLine("Give me 4 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());

            sum = num1 * num2 * num3 * num4;
            Console.WriteLine(sum);
            break;
    }

}

else if (chose == 4)
{
    Console.WriteLine("How many numbers do you want to divide with(2-4)?");

    howMany = Convert.ToInt32(Console.ReadLine());

    while (howMany <= 2 && howMany >= 4)
    {
        howMany = Convert.ToInt32(Console.ReadLine());
    }

    switch (howMany)
    {
        case 2:
            Console.WriteLine("Give me 2 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 / num2;
            Console.WriteLine(sum);
            break;

        case 3:
            Console.WriteLine("Give me 3 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            sum = num1 / num2 / num3;
            Console.WriteLine(sum);
            break;

        case 4:
            Console.WriteLine("Give me 4 numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());

            sum = num1 / num2 / num3 / num4;
            Console.WriteLine(sum);
            break;
    }

}


