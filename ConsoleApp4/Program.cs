int answre1, answre2, answre;
char symbol;
List<int> Answre = new List<int>();
try
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Please enter your number :");
    Console.ResetColor();
    Console.WriteLine("Number 1 :");
    answre1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Number 2 :");
    answre2 = Convert.ToInt32(Console.ReadLine());
    try
    {
        Console.WriteLine(" Please elect the desired symbol");
        Console.WriteLine("* / + -");
        symbol = Convert.ToChar(Answre);
        if (symbol == '*')
        {
            answre = answre1 * answre2;
        }
        if (symbol == '/')
        {
            answre = answre1 / answre2;
        }
        if (symbol == '+')
        {
            answre = answre1 * answre2;
        }
        if (symbol == '-')
        {
            answre = answre1 * answre2;
        }
        Answre.Add(answre);
    }
    catch (Exception) { }
}
catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Wrong input(Just Number!)");
    Console.ResetColor();
}