Console.WriteLine("Введите имя пользователя: ");
String username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}