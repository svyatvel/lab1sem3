namespace Lab1;

public class ConsoleMenu
{
    private readonly IStudentRepository _repository;

    public ConsoleMenu(IStudentRepository repository)
    {
        _repository = repository;
    }

    public void ShowMenu()
    {
        List<Student> students =
            _repository.GetAllStudents().ToList();

        ShowSearchResults(students);

        ShowBehaviorDemonstration(students);
    }

    private void ShowSearchResults(List<Student> students)
    {
        var targetStudents = students
            .Where(s =>
                s.Course == 1 &&
                s.Gender == Gender.Female &&
                s.ResidenceInfo != null &&
                s.ResidenceInfo.IsHostel)
            .ToList();

        Console.WriteLine(
            "--- РЕЗУЛЬТАТИ ПОШУКУ (Варіант 3) ---"
        );

        Console.WriteLine(
            $"Знайдено студенток 1-го курсу в гуртожитку: " +
            $"{targetStudents.Count}\n"
        );

        foreach (Student student in targetStudents)
        {
            Console.WriteLine(
                $"ПІБ: {student.LastName} {student.FirstName}"
            );

            Console.WriteLine(
                $"Студентський квиток: {student.StudentTicket}"
            );

            Console.WriteLine(
                $"Місце проживання: " +
                $"{student.ResidenceInfo.GetFormattedResidence()}\n"
            );
        }
    }

    private void ShowBehaviorDemonstration(List<Student> students)
    {
        Console.WriteLine(
            "--- ДЕМОНСТРАЦІЯ ПОВЕДІНКИ ---"
        );

        IIceSkater? studentSkater =
            students.FirstOrDefault();

        IIceSkater musicianSkater =
            new Musician
            {
                FirstName = "Святослав",
                LastName = "Вакарчук",
                Gender = Gender.Male,
                Instrument = "Вокал"
            };

        if (studentSkater != null)
        {
            Console.WriteLine(studentSkater.Skate());
        }

        Console.WriteLine(musicianSkater.Skate());
    }
}