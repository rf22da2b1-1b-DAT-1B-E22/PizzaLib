// See https://aka.ms/new-console-template for more information
using PizzaLib.model;

Console.WriteLine("Hello, World!");


Pizza p = new Pizza(2, "vesuio", 55);

Console.WriteLine(p);


try
{
    //p.Id = -1;
    p.Pris = 39;
}
catch(ArgumentException ae)
{
    Console.WriteLine(ae.Message);
}