Console.WriteLine("ВВедите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "лиза")
    {
        Console.WriteLine("Ура, это Лиза!!");
    }
    else
    {
        Console.Write("Привет, ");
        Console.WriteLine(username);
    }