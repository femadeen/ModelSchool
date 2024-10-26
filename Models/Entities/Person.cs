namespace ModelSchool.Models.Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdresss { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly DateOfBith {  get; set; }
        public string Address { get; set; }
    }
}
