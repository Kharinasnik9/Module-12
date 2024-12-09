using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Список пользователей
        List<User> users = new List<User>
        {
            new User { Login = "ivanov", Name = "Иван", IsPremium = true },
            new User { Login = "annasmith", Name = "Анна", IsPremium = false },
            new User { Login = "sergeyk", Name = "Сергей", IsPremium = true }
        };

        foreach (var user in users)
        {
            Console.WriteLine($"Привет, {user.Name}!");

            if (!user.IsPremium)
            {
                ShowAds();
            }
        }
    }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000); // Остановка на 1 секунду

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000); // Остановка на 2 секунды

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000); // Остановка на 3 секунды
    }
}

// Класс пользователя
public class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}
