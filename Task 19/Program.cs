Console.WriteLine("Task 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.Write("Введите число: ");
string input = Console.ReadLine();
Console.WriteLine();

if (!int.TryParse(input, out _))
{
    Console.WriteLine($"Не удается преобразовать {input} в целочисленную переменную"); 
}
else if (input.Length != 5)
{
    Console.WriteLine($"Введенное число не пятизначное");
}
else
{
    if (new string(input.Reverse().ToArray()) == input)
    {
        Console.WriteLine($" Число {input} палиндром");
    }
    else 
    {
        Console.WriteLine($" Число {input} НЕ палиндром");
    }
}