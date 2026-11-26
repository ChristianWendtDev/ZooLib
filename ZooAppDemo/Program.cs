using ZooAppDemo;
using ZooLib.NewFolder;

Console.WriteLine("Hello, World!");

Animal A  = new Animal("allan", "male");

Animal P = new Panda("kasten", "Male");
Animal Å = new Panda("Myrna", "Female");

Animal T = new Tiger("Børge", "Male");
Animal Y = new Tiger("Johanna", "Female");

Console.WriteLine(A.Eat());
Console.WriteLine(P.Eat());
Console.WriteLine(Å.Eat());
Console.WriteLine(T.Eat());
Console.WriteLine(Y.Eat());
Console.WriteLine("\n");
Console.WriteLine("..........");

ZooAnimals Animals = new ZooAnimals();

Animals.Add(P);
Animals.Add(Å);
Animals.Add(T);
Animals.Add(Y);

Console.WriteLine(Animals);
Console.WriteLine("\n");

foreach (Animal a in Animals.ListAll())
{
Console.WriteLine(a.Name + " " + a.Gender);
}

