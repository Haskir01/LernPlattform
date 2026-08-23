using LernPlattform.Api.Data;
using LernPlattform.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LernPlattform.Api.Controllers
{

    [ApiController]
    [Route("api/bereiche")]
    public class BereicheController:ControllerBase
    {
        private readonly AppDbContext _db;
        public BereicheController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<BereichDto>>>GetBereiche()
        {
            var bereiche=await _db.Pruefungsbereiche.OrderBy(b=>b.Reihenfolge).Select(b=>new BereichDto {
                Id=b.Id,
                Kuerzel=b.Kuerzel,
                Titel=b.Titel,
                Beschreibung=b.Beschreibung,
                Farbe=b.Farbe
                }).ToListAsync();return Ok(bereiche);
        }
    }
}
