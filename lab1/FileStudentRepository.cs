using System.Text.Json;

namespace Lab1;

public class FileStudentRepository : IStudentRepository
{
    private readonly string _filePath;

    public FileStudentRepository(string filePath)
    {
        _filePath = filePath;
    }

    public IEnumerable<Student> GetAllStudents()
    {
        if (!File.Exists(_filePath))
        {
            return new List<Student>();
        }

        string json = File.ReadAllText(_filePath);

        return JsonSerializer.Deserialize<List<Student>>(json)
               ?? new List<Student>();
    }

    public void SaveStudents(IEnumerable<Student> students)
    {
        string json = JsonSerializer.Serialize(
            students,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        File.WriteAllText(_filePath, json);
    }
}