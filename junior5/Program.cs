string name = "Anton";
string lastName = "Red";

Console.WriteLine($"Начальные значения: {name} {lastName}");

string revert = name;
name = lastName;
lastName = revert;

Console.WriteLine($"Новые значения: {name} {lastName}");