namespace Lab1;

public class Residence
{
    public bool IsHostel { get; set; }

    public int? HostelNumber { get; set; }

    public int? RoomNumber { get; set; }

    public string GetFormattedResidence()
    {
        if (!IsHostel)
        {
            return "Приватне житло";
        }

        return $"Гуртожиток №{HostelNumber}, кімната №{RoomNumber}";
    }
}