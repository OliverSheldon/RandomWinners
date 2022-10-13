using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Domain.Context
{
    public class PersonContext : DbContext
    {
        private bool _updated = false;

        public DbSet<Person> People { get; set; }
        public PersonContext(DbContextOptions options) : base(options)
        {
            Seed();
        }

        //This isn't really a good idea, but for the sake of demonstration:
        public void Seed()
        {
            List<Person> seedData = new List<Person>();
            seedData.Add(new Person() { Id = new Guid("F34B52CC-A617-427B-9180-181E2A98C305"), Forename = "Homer", Surname = "Simpson" });
            seedData.Add(new Person() { Id = new Guid("03DA89FD-E73C-46DA-9DC1-372E7B24A632"), Forename = "Marge", Surname = "Simpson" });
            seedData.Add(new Person() { Id = new Guid("F058A3E2-FD4A-442C-9704-41F0D8E40BC9"), Forename = "Bart", Surname = "Simpson" });
            seedData.Add(new Person() { Id = new Guid("ABF76F45-A52F-4E9B-B54F-CD7B5FE4743E"), Forename = "Lisa", Surname = "Simpson" });
            seedData.Add(new Person() { Id = new Guid("8A490CEC-8474-4186-AF4B-D9F317CDDF5D"), Forename = "Maggie", Surname = "Simpson" });
            seedData.Add(new Person() { Id = new Guid("C971B2A5-747E-4C00-96E5-87687EB21D03"), Forename = "Ned", Surname = "Flanders" });
            seedData.Add(new Person() { Id = new Guid("26DF5BD7-039C-492E-B3AA-11A1B4E1082C"), Forename = "Ralph", Surname = "Wiggum" });
            seedData.Add(new Person() { Id = new Guid("D5877B40-8BBA-486A-ADD7-51AF6D8A22E4"), Forename = "Troy", Surname = "McClure" });
            seedData.Add(new Person() { Id = new Guid("682E23D9-C162-4CF8-9732-38860C05B635"), Forename = "Hans", Surname = "Moleman" });
            seedData.Add(new Person() { Id = new Guid("FED784F3-3602-4655-8DD3-F279310A5783"), Forename = "Groundskeeper", Surname = "Willie" });

            foreach (Person person in seedData)
            {
                if (People.Find(person.Id) == null)
                {
                    People.Add(person);
                    _updated = true;
                }
            }

            if (_updated)
            {
                SaveChanges();                
            }
        }
    }
}
