using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class IncomeController : ControllerBase
{
    [HttpPost("add")]
    public async Task<IActionResult> Add()
    {
        return NoContent();
    }
}