using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaCovisian.Services;
using PruebaCovisian.Repositories;

namespace PruebaCovisian.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController : ControllerBase
    {
        
        protected readonly IAlquilerService _alquilerService;
        public AlquilerController(IAlquilerService alquilerService)
        {
            _alquilerService = alquilerService;
        }
        [HttpGet]
        [Route("GetTables")]
        public IActionResult GetTables([FromQuery] DateOnly? dateStart, DateOnly dateEnd)
        {
            return Ok(_alquilerService.GetTablesInfo(dateStart,dateEnd));
        }
        [HttpPost]
        [Route("GetAlquileresMensuales")]
        public IActionResult GetAlquileresMensuales([FromBody] AlquilerByDate Fecha)
        {
            return Ok(_alquilerService.GetAlquileresMensuales(Fecha));
        }
        [HttpPost]
        [Route("GetAlquileresDiarios")]
        public IActionResult GetAlquileresDiarios([FromBody] AlquilerByDate Fecha)
        {
            return Ok(_alquilerService.GetAlquileresDiarios(Fecha));
        }
    }
}
