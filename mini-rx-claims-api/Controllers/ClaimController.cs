using Microsoft.AspNetCore.Mvc;
using MiniRxClaimsApi.Models;

namespace MiniRxClaimsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaimController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllClaims()
        {
            return Ok(new[]
            {
                new Claim { Id = 1, MemberId = "ABC123", DrugCode = "RX001", DateFilled = DateTime.UtcNow }
            });
        }
    }
}
