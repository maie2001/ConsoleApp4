double answre1, answre2, answre;
char symbol;
List<int> Answre = new List<int>();
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
        }
        if (symbol == '/')
        {
            Answree();
            answre = answre1 / answre2;
            Console.WriteLine(answre);
        }
        if (symbol == '+')
        {
            Answree();
            answre = answre1 + answre2;
            Console.WriteLine(answre);
        }
        if (symbol == '-')
        {
            Answree();
            answre = answre1 - answre2;
            Console.WriteLine(answre);
        }
        if (symbol == '^')
        {
            Answree();
            answre = (int)Math.Pow(answre1, answre2);
            Console.WriteLine(answre);
        }
        if (symbol == '√')
        {
            Console.WriteLine("Please enter your number :");
            answre1 = Convert.ToInt32(Console.ReadLine());
            answre = (int)Math.Sqrt(answre1);
            Console.WriteLine(answre);
        }
    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Wrong input(Just number!)");
        Console.ResetColor();
    }
}
catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Wrong input(Just symbol!)");
    Console.ResetColor();
}
void Answree()
{
    Console.WriteLine("Please enter your number :");
    Console.WriteLine("Number 1 :");
    answre1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Number 2 :");
    answre2 = Convert.ToInt32(Console.ReadLine());
}