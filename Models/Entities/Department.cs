namespace ModelSchool.Models.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> Students = new List<Student>();
    }
}
