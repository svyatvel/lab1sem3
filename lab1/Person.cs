namespace Lab1;

public abstract class Person : IPerson
{
    public string FirstName { get; set; } = "";

    public string LastName { get; set; } = "";

    public Gender Gender { get; set; }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}