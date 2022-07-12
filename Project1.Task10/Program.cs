// Программа принимает трехзначное число и показывает вторую цифру
Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

string SecondSymbol(int numb)
{
    if (numb >= 100 && numb < 1000)
    {
        int step1 = numb / 10;
        int step2 = step1 % 10;
        return ("Второе число " + step2);
    }
    else
    return ("Введённое число не является трёхзначным");
}
Console.WriteLine(SecondSymbol(num));