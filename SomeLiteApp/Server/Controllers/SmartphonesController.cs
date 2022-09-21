using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SomeLiteApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartphonesController : ControllerBase
    {
        private readonly ISmartphoneServiece _serviece;

        public SmartphonesController(ISmartphoneServiece serviece)
        {
            _serviece = serviece;
        }

        [HttpGet]
        public async Task<ActionResult<List<Smartphone>>> GetAllAsync()
        {
            return Ok( await _serviece.GetAllAsync());
        }
    }
}
