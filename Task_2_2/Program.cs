using Task_2_2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Ви можете необмежено вводити інформацію про команди та співробітників. " +
    "Якщо хочете завершити введення - просто натисніть Enter, тим самим залишивши рядок пустим.");

List<Team> teams = new() { };

for (int i = 0; ; i++)
{
    Console.WriteLine($"Введіть назву команди {i + 1}:");

    var teamName = Console.ReadLine();
    if (string.IsNullOrEmpty(teamName)) break;

    Team newTeam = new Team(teamName);

    for (int j = 0; ; j++)
    {
        AddNewEmployee:

        Console.WriteLine($"Введіть тип співробітника {j + 1}, розробник (0) або менеджер (1):");
        
        var employeeTypeStr = Console.ReadLine();
        if (string.IsNullOrEmpty(employeeTypeStr)) break;
        if (!int.TryParse(employeeTypeStr, out int employeeType) || !(employeeType == 0 || employeeType == 1))
        {
            Console.WriteLine("Please enter only 0 or 1!");
            goto AddNewEmployee;
        }

        Console.WriteLine($"Введіть ПІБ співробітника {j + 1}:");

        var employeeName = Console.ReadLine();
        if (string.IsNullOrEmpty(employeeName)) break;

        Worker newEmployee;

        if (employeeType == 0) newEmployee = new Developer(employeeName);
        else if (employeeType == 1) newEmployee = new Manager(employeeName);
        else break;

        newTeam.AddEmployee(newEmployee);

        Console.WriteLine($"Співробітника {j + 1} додано до команди {i + 1}!");
    }

    teams.Add(newTeam);

    Console.WriteLine($"Команду {i + 1} додано успішно!");
}

if (teams.Count == 0) 
{
    Console.WriteLine("Жодної команди не було додано!");
    return;
}

Console.WriteLine("Дані доданих команд:");

int index = 0;
foreach (var team in teams)
{
    Console.Write($"{++index}) ");
    team.PrintDetailedInfo();
}
