// See https://aka.ms/new-console-template for more information
Console.WriteLine("Wprowadź temperaturę ....");
int temp = Int32.Parse(Console.ReadLine());

if (temp < 0)
{
    Console.WriteLine("Cholernie Piździ ....");
}
else if (temp >= 0 && temp <= 10 )
{
    Console.WriteLine("Zimno ....");
}
else if (temp >= 10 && temp  >= 20) 
{
    Console.WriteLine("Chłodno ....");
}
else if (temp >= 20 && temp  >= 30) 
{
    Console.WriteLine("Jest w sam raz ....");
}
else if (temp >= 30 && temp  >= 40) 
{
    Console.WriteLine("Zaczyna być gorąco ....");
}
else if (temp >= 40 ) 
{
    Console.WriteLine("A weź wyprowadzam się na ALASKĘ ....");
}