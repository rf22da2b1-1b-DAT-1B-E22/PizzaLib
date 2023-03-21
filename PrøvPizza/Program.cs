// See https://aka.ms/new-console-template for more information
using PizzaLib.model;



//Pizza2 p1 = new Pizza2(2, "vesuio", 55);
//Pizza2 p2 = new Pizza2(2, "vesuio", 55);

//Console.WriteLine(p1 == p2);
//Console.WriteLine(p1.Equals(p2));
//Console.WriteLine(p1 == p1);
//Console.WriteLine(p1.Equals(p1));

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

//IGenericRepository<Pizza2> repo = new GenericRepository<Pizza2>();
//repo.Create(p);
//repo.Create(new Pizza2());

//foreach(Pizza2 pz in repo.GetAll())
//{
//    Console.WriteLine(pz);
//}




List<Pizza2> pizzas = new List<Pizza2>()
{
    new Pizza2(2, "vesuio", 55),
    new Pizza2(4, "napoli", 53),
    new Pizza2(6, "roma", 65),
    new Pizza2(3, "milano", 58),
    new Pizza2(5, "firence", 52)
};


foreach (Pizza2 p in pizzas)
{
    Console.WriteLine(p);
}

Console.WriteLine("Sorteret");
pizzas.Sort();
foreach (Pizza2 p in pizzas)
{
    Console.WriteLine(p);
}

