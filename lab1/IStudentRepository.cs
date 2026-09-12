namespace Lab1;

public interface IStudentRepository
{
    IEnumerable<Student> GetAllStudents();

    void SaveStudents(IEnumerable<Student> students);
}