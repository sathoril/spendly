using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class DailyTransactionController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Add()
    {
        var dailyTransactions = new[]
        {
            new DailyTransaction(Guid.NewGuid().ToString(), 100, 100, DateTime.Now, 100),
            new DailyTransaction(Guid.NewGuid().ToString(), 100, 100, DateTime.Now, 200),
            new DailyTransaction(Guid.NewGuid().ToString(), 100, 100, DateTime.Now, 300),
            new DailyTransaction(Guid.NewGuid().ToString(), 100, 100, DateTime.Now, 400),
            new DailyTransaction(Guid.NewGuid().ToString(), 100, 100, DateTime.Now, 500),
            new DailyTransaction(Guid.NewGuid().ToString(), 100, 100, DateTime.Now, 600),
            new DailyTransaction(Guid.NewGuid().ToString(), 100, 100, DateTime.Now, 700),
            new DailyTransaction(Guid.NewGuid().ToString(), 100, 100, DateTime.Now, 800),
            new DailyTransaction(Guid.NewGuid().ToString(), 100, 100, DateTime.Now, 900),
            new DailyTransaction(Guid.NewGuid().ToString(), 100, 100, DateTime.Now, 1000),
            new DailyTransaction(Guid.NewGuid().ToString(), 100, 100, DateTime.Now, 1100)
        };
        
        return Ok(dailyTransactions);
    }
}