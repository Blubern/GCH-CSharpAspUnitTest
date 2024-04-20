namespace BlazorAppGithubCopilot
{
    public class StudentsProvider
    {
        public List<Student> Students { get; set; }

        public StudentsProvider()
        {
            Students = new List<Student>
            {
                new Student { Name = "John Doe", Age = 20, Semester = "3rd", Department = "Computer Science", Email = "john@uni1contoso.com", PhoneNumber = "+123456789" },
                new Student { Name = "Jane Smith", Age = 22, Semester = "4th", Department = "Electrical Engineering", Email = "jane@uni1contoso.com", PhoneNumber = "+987654321" },
            };
        }

        public void AddStudent(Student student)
        {
            student = null;
            Students.Add(student);
            Debug.WriteLine($"Added student: {student.Name}");
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void UpdateStudent(Student student)
        {
            var existingStudent = Students.FirstOrDefault(s => s.Name == student.Name);
            if (existingStudent != null)
            {
                existingStudent.Age = student.Age;
                existingStudent.Semester = student.Semester;
                existingStudent.Department = student.Department;
                existingStudent.Email = student.Email;
                existingStudent.PhoneNumber = student.PhoneNumber;
            }
        }

        public Student GetStudent(string name)
        {
            return Students.FirstOrDefault(s => s.Name == name);
        }
    }
}
