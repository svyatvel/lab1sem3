namespace Lab1;

public class Student : Person, IIceSkater
{
    public int Course { get; set; }

    public string StudentTicket { get; set; } = "";

    public Residence ResidenceInfo { get; set; } = new Residence();

    public string Skate()
    {
        return $"{FirstName} {LastName} (Студент) " +
               "катається на ковзанах на університетській ковзанці.";
    }
}