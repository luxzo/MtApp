using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MtApp.Entities;

namespace MtApp.Controllers
{
    [ApiController]
    [Route("employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public EmployeesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("orderByBDay")]
        public async Task<ActionResult<List<Employee>>> GetByBDate()
        {
            return await context.Employees.OrderBy(x => x.BornDate).ToListAsync();
        }

        [HttpGet("orderByRfc")]
        public async Task<ActionResult<List<Employee>>> GetByName()
        {
            return await context.Employees.OrderBy(x => x.Name).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Employee employee)
        {
            context.Add(employee);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Employee employee, int id)
        {
            if (employee.Id != id)           
                return BadRequest("Id does not match");

            var exists = await context.Employees.AnyAsync(x => x.Id == id);
            if (!exists)
                return NotFound();

            context.Update(employee);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exists = await context.Employees.AnyAsync(x => x.Id == id);
            if (!exists)
                return NotFound();           
                
            context.Remove(new Employee { Id = id });
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
