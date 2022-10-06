double answre1, answre2, answre;
char symbol;
List<double> Answre = new List<double>();
Ask();
void calculator()
{
    try
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" Please elect the desired symbol");
        Console.WriteLine("* / + - ^ √");
        Console.ResetColor();
        symbol = Convert.ToChar(Console.ReadLine());
        try
        {
            if (symbol == '*')
            {
                Answree();
                answre = answre1 * answre2;
                Console.WriteLine(answre);
                Answre.Add(answre);
            }
            if (symbol == '/')
            {
                Answree();
                answre = answre1 / answre2;
                Console.WriteLine(answre);
                Answre.Add(answre);
            }
            if (symbol == '+')
            {
                Answree();
                answre = answre1 + answre2;
                Console.WriteLine(answre);
                Answre.Add(answre);
            }
            if (symbol == '-')
            {
                Answree();
                answre = answre1 - answre2;
                Console.WriteLine(answre);
                Answre.Add(answre);
            }
            if (symbol == '^')
            {
                Answree();
                answre = (int)Math.Pow(answre1, answre2);
                Console.WriteLine(answre);
                Answre.Add(answre);
            }
            if (symbol == '√')
            {
                Console.WriteLine("Please enter your number :");
                answre1 = Convert.ToInt32(Console.ReadLine());
                answre = (int)Math.Sqrt(answre1);
                Console.WriteLine(answre);
                Answre.Add(answre);
            }
        }
        catch (Exception)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Wrong input(Just number!)");
            Console.WriteLine("*****************");
            Console.ResetColor();
        }
        Console.WriteLine("*****************");
        Ask();
    }
    catch (Exception)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Wrong input(Just symbol!)");
        Console.WriteLine("*****************");
        Console.ResetColor();
    }
}
void Ask()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Enter 1 to use the calculator :");
    Console.WriteLine("Enter 2 to show hitory :");
    Console.WriteLine("Or enter any key to logout :");
    Console.ResetColor();
    answre1 = Convert.ToInt32(Console.ReadLine());
    if (answre1 == 1)
    {
        Console.Clear();
        calculator();
    }
    if (answre1 == 2)
    {
        Console.Clear();
        Console.WriteLine("History :");
        foreach (double history in Answre)
        {
            Console.WriteLine(history);
        }
        Console.WriteLine("*****************");
        Ask();
    }
    else
    {
        return;
    }
}
void Answree()
{
    Console.WriteLine("Please enter your number :");
    Console.WriteLine("Number 1 :");
    answre1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Number 2 :");
    answre2 = Convert.ToInt32(Console.ReadLine());
}