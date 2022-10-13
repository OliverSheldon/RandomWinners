using Domain.Context;
using Domain.Models;

namespace RandomWinners.Models
{
    public class Winners
    {
        private PersonContext _pc { get; set; }
        public Winners(PersonContext pc)
        {
            _pc = pc;
        }
        public List<Person> GetWinners(WinnersRequest request)
        {
            List<Person> result = _pc.People.OrderBy(x => Guid.NewGuid()).Take(request.number).ToList();

            return result;
        }
    }
}
