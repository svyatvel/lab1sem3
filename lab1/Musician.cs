namespace Lab1;

public class Musician : Person, IIceSkater
{
    public string Instrument { get; set; } = "";

    public string Skate()
    {
        return $"{FirstName} {LastName} (Музикант) " +
               "граціозно катається на ковзанах.";
    }
}