using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProjectAPI.Data;
using FinalProjectAPI.Data.Entities;

namespace FinalProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly ProductDBContext _context;

        public SubCategoryController(ProductDBContext context)
        {
            _context = context;
        }

        // GET: api/SubCategory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubCategory>>> GetSubCategories()
        {
            return await _context.SubCategories.ToListAsync();
        }

        // GET: api/SubCategory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubCategory>> GetSubCategory(int id)
        {
            var subCategory = await _context.SubCategories.FindAsync(id);

            if (subCategory == null)
            {
                return NotFound();
            }

            return subCategory;
        }

        // PUT: api/SubCategory/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubCategory(int id, SubCategory subCategory)
        {
            if (id != subCategory.ID)
            {
                return BadRequest();
            }

            _context.Entry(subCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubCategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SubCategory
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SubCategory>> PostSubCategory(SubCategory subCategory)
        {
            _context.SubCategories.Add(subCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubCategory", new { id = subCategory.ID }, subCategory);
        }

        // DELETE: api/SubCategory/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SubCategory>> DeleteSubCategory(int id)
        {
            var subCategory = await _context.SubCategories.FindAsync(id);
            if (subCategory == null)
            {
                return NotFound();
            }

            _context.SubCategories.Remove(subCategory);
            await _context.SaveChangesAsync();

            return subCategory;
        }

        private bool SubCategoryExists(int id)
        {
            return _context.SubCategories.Any(e => e.ID == id);
        }
    }
}
