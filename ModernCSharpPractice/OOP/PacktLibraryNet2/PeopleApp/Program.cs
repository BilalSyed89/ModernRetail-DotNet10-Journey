using Packt.Shared;
using PacktLibraryNet2;

ConfigureConsole(); // Sets current culture to US English

Person bob = new();

WriteLine(bob);


bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
  year: 1965, month: 12, day: 22,
  hour: 16, minute: 28, second: 0,
  offset: TimeSpan.FromHours(-5)); // US Eastern Standard Time.
WriteLine(format: "{0} was born on {1:D}.", // Long date.
  arg0: bob.Name, arg1: bob.Born);


Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
    // This is an optional offset from UTC time zone.
    TimeSpan.Zero)
};
WriteLine(format: "{0} was born on {1:d}.", // Short date.
  arg0: alice.Name, arg1: alice.Born);


bob.FavoriteAncientWonder = WondersOfTheAncientWorld.
StatueOfZeusAtOlympia;
WriteLine(
  format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
  arg0: bob.Name,
  arg1: bob.FavoriteAncientWonder,
  arg2: (int)bob.FavoriteAncientWonder);



alice.FavoriteProfessionalGame = ProfessionalGames.CallOfDuty;
WriteLine(
  format: "{0}'s favorite professional game is {1}. Its integer is {2}.",
  arg0: alice.Name,
  arg1: alice.FavoriteProfessionalGame,
  arg2: (int)alice.FavoriteProfessionalGame);


RetailShop shop1 = new()
{
    Name = "Shop 1",
    Location = "New York"
};

RetailShop shop2 = new()
{
    Name = "Shop 2",
    Location = "Los Angeles"
};

WriteLine(
  format: "{0} is located in {1}.",
  arg0: shop1.Name,
  arg1: shop1.Location);

WriteLine(
  format: "{0} is located in {1}.",
  arg0: shop2.Name,
  arg1: shop2.Location);


shop1.
    itemCatagory = ProductsCatagories.Bakery;

shop2.
    itemCatagory = ProductsCatagories.Dairy;

WriteLine(
    format: "{0} sells {1}.",
    arg0: shop1.Name,
    arg1: shop1.itemCatagory);

WriteLine(
    format: "{0} sells {1}.",
    arg0: shop2.Name,
    arg1: shop2.itemCatagory);