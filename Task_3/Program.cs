using Task_3;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.Unicode;


Tuple<string, decimal> currencyFromData = getCurrencyData("Введіть назву валюти, з якої хочете виконати конвертацію:");
Currency currencyFrom = new(currencyFromData.Item1, currencyFromData.Item2);

Tuple<string, decimal> currencyToData = getCurrencyData("Введіть назву валюти, до якої хочете виконати конвертацію:");
Currency currencyTo = new(currencyToData.Item1, currencyToData.Item2);

Console.WriteLine("Введіть суму:");
decimal sum = ReadDecimalValue();

Console.WriteLine($"{sum} {currencyFrom.Name} = {Converter.Convert(currencyFrom, currencyTo, sum)} {currencyTo.Name}");


Tuple<string, decimal> getCurrencyData(string initialMessage)
{
    Console.WriteLine(initialMessage);
    var currencyName = ReadStringValue();

    Console.WriteLine("Введіть курс цієї валюти по відношенню до гривні:");
    decimal currencyRate = ReadDecimalValue();

    return new Tuple<string, decimal>(currencyName, currencyRate);
}

decimal ReadDecimalValue()
{
    ReadDecimal:

    var input = ReadStringValue();

    if (!decimal.TryParse(input, out decimal value))
    {
        Console.WriteLine("Значення має бути decimal типу!");
        goto ReadDecimal;
    }

    return value;
}

string ReadStringValue()
{
    ReadString:

    var input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Не має бути пустим!");
        goto ReadString;
    }

    return input;
}
