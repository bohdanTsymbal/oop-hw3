var input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Failed to read your input, you should enter some text here!");
    return;
}

if (!int.TryParse(input, out int inputNumber))
{
    Console.WriteLine("You should enter an integer!");
    return;
}

Console.WriteLine($"Ви ввели число {inputNumber}");
