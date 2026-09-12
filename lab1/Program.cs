using System.Text;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string path = "students_data.json";

        IStudentRepository repository =
            new FileStudentRepository(path);

        if (!File.Exists(path))
        {
            repository.SaveStudents(CreateInitialStudents());
        }

        ConsoleMenu menu =
            new ConsoleMenu(repository);

        menu.ShowMenu();
    }

    private static List<Student> CreateInitialStudents()
    {
        return new List<Student>
        {
            new Student
            {
                FirstName = "Олена",
                LastName = "Коваленко",
                Course = 1,
                Gender = Gender.Female,
                StudentTicket = "KB123",
                ResidenceInfo = new Residence
                {
                    IsHostel = true,
                    HostelNumber = 4,
                    RoomNumber = 205
                }
            },

            new Student
            {
                FirstName = "Марія",
                LastName = "Іваненко",
                Course = 1,
                Gender = Gender.Female,
                StudentTicket = "KB124",
                ResidenceInfo = new Residence
                {
                    IsHostel = false
                }
            },

            new Student
            {
                FirstName = "Андрій",
                LastName = "Петров",
                Course = 2,
                Gender = Gender.Male,
                StudentTicket = "KB125",
                ResidenceInfo = new Residence
                {
                    IsHostel = true,
                    HostelNumber = 3,
                    RoomNumber = 101
                }
            },

            new Student
            {
                FirstName = "Анна",
                LastName = "Сидоренко",
                Course = 1,
                Gender = Gender.Female,
                StudentTicket = "KB126",
                ResidenceInfo = new Residence
                {
                    IsHostel = true,
                    HostelNumber = 4,
                    RoomNumber = 208
                }
            }
        };
    }
}