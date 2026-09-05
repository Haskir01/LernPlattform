using LernPlattform.Api.Data;
using LernPlattform.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace LernPlattform.Api.Controllers
{
    [ApiController]
    [Route("api/kurse")]
    public class KursController:ControllerBase
    {
        private readonly AppDbContext _db;
        public KursController(AppDbContext db)
        {
            _db= db;
        }
        [HttpGet]
        public async Task<ActionResult<List<KursDto>>> GetKurse()
        {
            var Kurse = await _db.Kurse.OrderBy(b => b.Reihenfolge).Select(b => new KursDto
            {
                Id = b.Id,
                Bezeichnung = b.Bezeichnung,
                Farbe = b.Farbe
            }).ToListAsync();

            return Ok(Kurse);
            
        }
    }
}
