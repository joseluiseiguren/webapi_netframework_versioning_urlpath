using Microsoft.Web.Http;
using System.Linq;
using System.Web.Http;
using webapiexample.Dto;
using webapiexample.Repository;

namespace webapiexample.Controllers.V2
{
    [ApiVersion("2.0")]    
    [RoutePrefix("api/v{version:apiVersion}/persons")]
    public class PersonsController : ApiController
    {
        [Route]
        public IHttpActionResult Get()
        {
            var personRepository = new PersonRepository();

            var persons = personRepository.GetByFilter().ToList();

            var resp = new PersonDto()
            {
                Records = persons.Count,
                Persons = persons
            };

            return this.Ok(resp);
        }
    }
}
