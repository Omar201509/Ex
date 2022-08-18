Console.Write ("Введите имя пользователя:");
string username = Console.ReadLine();

if (username.ToLower() == "omar")
{
    Console.WriteLine ("Ура,Это же OMAR!");
}
else
{
    Console.WriteLine ("Привет,");
    Console.WriteLine (username);
}