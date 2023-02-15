// See https://aka.ms/new-console-template for more information
using PizzaLib.model;



Pizza2 p = new Pizza2(2, "vesuio", 55);

/*
 
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
*/



//IPizzaRepository repo = new PizzaRepository();

IGenericRepository<Pizza2> repo = new GenericRepository<Pizza2>();
repo.Create(p);
repo.Create(new Pizza2());

foreach(Pizza2 pz in repo.GetAll())
{
    Console.WriteLine(pz);
}


