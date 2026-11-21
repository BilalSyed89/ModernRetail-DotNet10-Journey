using PacktLibraryNet2;

namespace Packt.Shared;

public class Person :Object
{
    public WondersOfTheAncientWorld FavoriteAncientWonder;

    public ProfessionalGames FavoriteProfessionalGame;


    #region Fields: Data or state for this person.
    public string? Name; // ? means it can be null.
    public DateTimeOffset Born;
    #endregion
}