﻿Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hey! its Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}

