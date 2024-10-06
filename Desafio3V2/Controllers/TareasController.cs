using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Desafio3V2.Models;

namespace Desafio3V2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private readonly ProyectosDBContext _context;

        public TareasController(ProyectosDBContext context)
        {
            _context = context;
        }

        // GET: api/Tareas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TareaT>>> GetTarea()
        {
            return await _context.Tarea.ToListAsync();
        }

        // GET: api/Tareas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TareaT>> GetTareaT(int id)
        {
            var tareaT = await _context.Tarea.FindAsync(id);

            if (tareaT == null)
            {
                return NotFound();
            }

            return tareaT;
        }

        // PUT: api/Tareas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTareaT(int id, TareaT tareaT)
        {
            if (id != tareaT.Id)
            {
                return BadRequest();
            }

            _context.Entry(tareaT).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TareaTExists(id))
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

        // POST: api/Tareas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TareaT>> PostTareaT(TareaT tareaT)
        {
            _context.Tarea.Add(tareaT);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTareaT", new { id = tareaT.Id }, tareaT);
        }

        // DELETE: api/Tareas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTareaT(int id)
        {
            var tareaT = await _context.Tarea.FindAsync(id);
            if (tareaT == null)
            {
                return NotFound();
            }

            _context.Tarea.Remove(tareaT);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TareaTExists(int id)
        {
            return _context.Tarea.Any(e => e.Id == id);
        }
    }
}
