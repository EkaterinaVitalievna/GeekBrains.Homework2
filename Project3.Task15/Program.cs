// Принимает на вход цифру, обозначающую день недели и проверяет, является ли цифра выходным днём

Console.WriteLine("Какой по счёту день недели?");
int day = Convert.ToInt32(Console.ReadLine());

string Week (int dayNumber)
{
    if (dayNumber >= 1 && dayNumber <= 5)
    {
        return "Введённый день - будний";
    }
    else if (dayNumber <= 6 && dayNumber >= 7)
    {
        return "Введенный день - выходным";
    }
    else
        return "Error";
}

Console.WriteLine(Week(day));