using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DateReminder;
using DateReminder.Models;

namespace DateReminder.Controllers
{
    [Route("api/list")]
    [ApiController]
    public class ListModelsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ListModelsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/lists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ListModel>>> GetLists()
        {
            return await _context.Lists.ToListAsync();
        }

        // GET: api/lists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ListModel>> GetListModel(int id)
        {
            var listModel = await _context.Lists.FindAsync(id);

            if (listModel == null)
            {
                return NotFound();
            }

            return listModel;
        }

        // PUT: api/lists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListModel(int id, ListModel listModel)
        {
            if (id != listModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(listModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListModelExists(id))
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

        // POST: api/lists
        [HttpPost]
        public async Task<ActionResult<ListModel>> PostListModel(ListModel listModel)
        {
            _context.Lists.Add(listModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetListModel", new { id = listModel.Id }, listModel);
        }

        // DELETE: api/lists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteListModel(int id)
        {
            var listModel = await _context.Lists.FindAsync(id);
            if (listModel == null)
            {
                return NotFound();
            }

            _context.Lists.Remove(listModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //Get: api/lists/{userid}
        [HttpGet("s/{userId}")]
        public async Task<ActionResult> GetUserList(int userId)
        {
            var listModel = await _context.Lists.FindAsync(userId);
            if (listModel == null)
            {
                return NotFound();
            }

            _context.Lists.Remove(listModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ListModelExists(int id)
        {
            return _context.Lists.Any(e => e.Id == id);
        }
    }
}
