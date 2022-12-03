string name;
string login;
string premium;
bool prem;

User newUser = new User();

Console.WriteLine("Enter your name:");
newUser.Name = Console.ReadLine();
Console.WriteLine("Enter your login:");
newUser.Login = Console.ReadLine();
Console.WriteLine("Do you have a premium? Y(yes) or N(not)");
premium = Console.ReadLine();

Console.WriteLine($"Hello {newUser.Name}!");

if (premium == "Y")
    newUser.IsPremium = true;
else if (premium == "N")
{
    newUser.IsPremium = false;
    prem = newUser.IsPremium;
}
else
    Console.WriteLine("Enter Y or N, please");
