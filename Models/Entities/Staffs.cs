namespace ModelSchool.Models.Entities
{
    public class Staffs 
    {
        public List<Lecturer> Lecturers { get; set; } = new List<Lecturer>();
        public List<SchoolWoker> SchoolWokers { get; set; }
    }
}
