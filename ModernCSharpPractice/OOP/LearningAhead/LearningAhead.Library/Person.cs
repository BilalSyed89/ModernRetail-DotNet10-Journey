namespace LearningAhead.Library;

public class Person
{
    public string? Name { get; set; }
    public DateOnly DateOfBirth { get; set; }

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Name))
        {
            throw new PersonException(
                "A person must have a name.");
        }

        if (DateOfBirth > DateOnly.FromDateTime(DateTime.Today))
        {
            throw new PersonException(
                "The date of birth cannot be in the future.");
        }
    }
}