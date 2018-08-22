using Microsoft.Web.Http;
using System.Web.Http;
using webapiexample.Repository;

namespace webapiexample.Controllers.V1
{
    [ApiVersion("1.0", Deprecated = true)]
    [RoutePrefix("api/v{version:apiVersion}/persons")]
    public class PersonsController : ApiController
    {
        [Route]
        public IHttpActionResult Get()
        {
            var personRepository = new PersonRepository();

            var persons = personRepository.GetByFilter();

            return this.Ok(persons);
        }
    }
}
