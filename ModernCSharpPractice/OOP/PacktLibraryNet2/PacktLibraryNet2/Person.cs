using PacktLibraryNet2;

namespace Packt.Shared;

public class Person :Object
{
    public WondersOfTheAncientWorld BucketList;
    public WondersOfTheAncientWorld FavoriteAncientWonder;

    public ProfessionalGames FavoriteProfessionalGame;

    public List<Person> Children = new();




    #region Fields: Data or state for this person.
    public string? Name; // ? means it can be null.
    public DateTimeOffset Born;
    #endregion
}