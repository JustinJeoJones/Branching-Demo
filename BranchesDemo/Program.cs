//List of products
List<string> products = new List<string>() { "chips", "candy", "soda" };
foreach(string p in products)
{
    Console.WriteLine(p);
}
Console.WriteLine("Please choose an item");
string item = Console.ReadLine();