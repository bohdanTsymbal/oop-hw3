var input = Console.ReadLine();

if (input == null)
{
    Console.WriteLine("Failed to read your input, sorry...");
    return;
}

if (String.IsNullOrEmpty(input))
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
