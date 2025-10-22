using System;


class Calculator
{
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subt(double a, double b)
    {
        return a - b;
    }

    static double Mult(double a, double b)
    {
        return a * b;
    }

    static double Div(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Sıfıra bölmək olmaz!");
            return double.NaN;
        }
        return a / b;
    }

    static void Main()
    {
        Console.WriteLine("Kalkulyator proqramina xos gelmisiniz!");
        Console.Write("Birinci ededi daxil edin: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci ededi daxil edin: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEmeliyyati secin:");
        Console.WriteLine("1 - Toplama (Add)");
        Console.WriteLine("2 - Cixma (Subt)");
        Console.WriteLine("3 - Vurma (Mult)");
        Console.WriteLine("4 - Bolme (Div)");

        Console.Write("\nSeciminizi daxil edin (1-4): ");
        int secim = Convert.ToInt32(Console.ReadLine());

        double netice;

        switch (secim)
        {
            case 1:
                netice = Add(num1, num2);
                Console.WriteLine($"Netice: {netice}");
                break;

            case 2:
                netice = Subt(num1, num2);
                Console.WriteLine($"Netice: {netice}");
                break;

            case 3:
                netice = Mult(num1, num2);
                Console.WriteLine($"Netice: {netice}");
                break;

            case 4:
                netice = Div(num1, num2);
                Console.WriteLine($"Netice: {netice}");
                break;

            default:
                Console.WriteLine("Yanlis secim etdiniz!");
                break;
        }

        Console.WriteLine("\nProqram bitdi.");
    }
}
