using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Lecture9PL.DAL;
using Lecture9PL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lecture9PL.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly GakkDbContext _dbContext;

    public StudentsController(GakkDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // GET api/students
    [HttpGet]
    public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
    {
        // SELECT * FROM Students WHERE LastName LIKE 'A%' ORDER BY LastName
        var data = await _dbContext.Students
            .Include(s => s.StudentGroup)
            .OrderBy(s => s.LastName)
            .ToListAsync(cancellationToken);

        return Ok(data);
    }
}