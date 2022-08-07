Console.Write("Please enter your username: ");
String username = Console.ReadLine();

if (username.ToLower() == "masha") 
{
    Console.WriteLine($"Hello DEAR {username}");
} 
else 
{
    Console.WriteLine($"Hello {username}");
}