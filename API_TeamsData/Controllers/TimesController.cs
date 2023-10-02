using API_TeamsData.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_TeamsData.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TimesController : ControllerBase
    {
        private readonly ITimesRepository _timesRepository;

        public TimesController(ITimesRepository timesRepository)
        {
            _timesRepository = timesRepository;
        }

        public async Task<IActionResult> SearchAllTeams()
        {
            throw new NotImplementedException();
        }
    }
}
