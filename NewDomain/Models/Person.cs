namespace Domain.Models
{
    public class Person
    {
        public Person()
        {
        }
        public Guid Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
    }
}
