using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using openswaggerNswag.Models;

namespace openswaggerNswag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoitemsController : ControllerBase
    {
        private readonly todocontextContext _context;

        public TodoitemsController(todocontextContext context)
        {
            _context = context;
        }

        // GET: api/Todoitems
        [HttpGet]
        public IEnumerable<Todoitems> GetTodoitems()
        {
            return _context.Todoitems;
        }

        // GET: api/Todoitems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTodoitems([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var todoitems = await _context.Todoitems.FindAsync(id);

            if (todoitems == null)
            {
                return NotFound();
            }

            return Ok(todoitems);
        }

        // PUT: api/Todoitems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoitems([FromRoute] long id, [FromBody] Todoitems todoitems)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != todoitems.Id)
            {
                return BadRequest();
            }

            _context.Entry(todoitems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoitemsExists(id))
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

        // POST: api/Todoitems
        [HttpPost]
        public async Task<IActionResult> PostTodoitems([FromBody] Todoitems todoitems)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Todoitems.Add(todoitems);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTodoitems", new { id = todoitems.Id }, todoitems);
        }

        // DELETE: api/Todoitems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoitems([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var todoitems = await _context.Todoitems.FindAsync(id);
            if (todoitems == null)
            {
                return NotFound();
            }

            _context.Todoitems.Remove(todoitems);
            await _context.SaveChangesAsync();

            return Ok(todoitems);
        }

        private bool TodoitemsExists(long id)
        {
            return _context.Todoitems.Any(e => e.Id == id);
        }
    }
}