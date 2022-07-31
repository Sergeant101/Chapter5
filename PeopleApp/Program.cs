using Packt.Shared;
using static System.Console;

var bob = new Person();
WriteLine(bob.ToString());
bob.name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWonder = WordestOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WordestOfTheAncientWorld.HangingGardensOfBabylon | WordestOfTheAncientWorld.MausoleumAtHalicarnassus;
bob.Children.Add(new Person{name = "Alfred" });
bob.Children.Add(new Person{name = "Zoe"});

WriteLine(
    format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: bob.name,
    arg1: bob.DateOfBirth);

WriteLine(format:
    "{0}'s favorite wonder is {1}. It's integer is {2}.",
    arg0: bob.name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder
);

WriteLine($"{bob.name}'s bucket list is {bob.BucketList } ");

WriteLine($"{bob.name} has {bob.Children.Count } chidren ");
foreach(Person p in bob.Children)
{
    WriteLine(p.name);
}