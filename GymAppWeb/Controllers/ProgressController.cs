using Microsoft.AspNetCore.Mvc;
using GymAppWeb.Models;

namespace GymAppWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProgressController : ControllerBase
    {
        private static readonly List<ProgressEntry> _entries = new();

        [HttpGet]
        public IEnumerable<ProgressEntry> Get() => _entries;

        [HttpPost]
        public IActionResult Post(ProgressEntry entry)
        {
            entry.Date = entry.Date == default ? DateTime.UtcNow : entry.Date;
            _entries.Add(entry);
            return CreatedAtAction(nameof(Get), entry);
        }
    }
}
