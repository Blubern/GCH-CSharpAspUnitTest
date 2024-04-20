namespace BlazorAppGithubCopilot
{
#pragma warning disable CS8618
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Semester { get; set; }

        public string Department { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Semester: {Semester}, Department: {Department}, Email: {Email}, PhoneNumber: {PhoneNumber}";
        }
#pragma warning restore CS8618
    }
}
