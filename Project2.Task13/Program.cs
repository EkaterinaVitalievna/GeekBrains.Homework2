// Выводит третью цифру числа или сообщает, что её нет
Console.WriteLine("Введите число");

string NUMBERS = Console.ReadLine();

if (NUMBERS.Length < 3)
{
    Console.WriteLine("Третьей цифры в числе нет");
}
else
{
    Console.WriteLine("Третья цифра числа " + NUMBERS[2]);
}