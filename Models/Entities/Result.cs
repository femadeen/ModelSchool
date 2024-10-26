namespace ModelSchool.Models.Entities
{
    public class Result
    {
        public int Id { get; set; }

        public List<Course> courses { get; set; } = new List<Course>();
        public List<Student> students { get; set; } = new List<Student>();
    }
}
