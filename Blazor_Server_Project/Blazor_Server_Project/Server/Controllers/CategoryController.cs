using Blazor_Server_Project.Server.Context;
using Blazor_Server_Project.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Server_Project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext context;

        public CategoryController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return await context.Categories.AsNoTracking().ToListAsync();
        }

        [HttpGet("{categoryId}")]
        public async Task<ActionResult<Category>> GetCategoryById(int categoryId)
        {
            return await context.Categories.FirstOrDefaultAsync(x => x.CategoryId == categoryId);
        }

        [HttpPost]
        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            context.Add(category);
            await context.SaveChangesAsync();

            return new CreatedAtRouteResult("GetCategories",
                new { categoryId = category.CategoryId }, category);
        }

        [HttpPut]
        public async Task<ActionResult<Category>> UpdateCategory(Category category)
        {
            context.Entry(category).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return Ok(category);

        }

        [HttpDelete("{categoryId}")]
        public async Task<ActionResult<Category>> DeleteCategory(int categoryId)
        {
            var category = new Category { CategoryId = categoryId };
            context.Remove(category);
            await context.SaveChangesAsync();
            return Ok(category);

        }

    }
}
