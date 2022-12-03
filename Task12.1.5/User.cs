using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User
{
    private string login;
    private string name;
    private bool premium;

    public User()
    {
    }

    public string Login { get { return login; } set { login = value; } }
    public string Name { get { return name; } set { name = value; } }
    public bool IsPremium
    {
        get
        {
            if(premium == true)
                return true;
            else
            {
                ShowAds();
                return false;
            }
        }
        set { premium = value; }
    }

    void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }
}
