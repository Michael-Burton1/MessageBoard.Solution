using System;
using System.Collections.Generic;
using System.Boolean;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoard.Models;

namespace MessageBoard.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EventsController : ControllerBase
  {
    private readonly MessageBoardContext _db;

    public EventsController(MessageBoardContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Event>>> Get()
    {
      var query = _db.Events.AsQueryable();

      // if (name != null)
      // {
      //   query = query.Where(entry => entry.Name == name);
      // }

      // if (category != null)
      // {
      //   query = query.Where(entry => entry.Category == category);
      // }

      // if (date != null)
      // {
      //   query = query.Where(entry => entry.Date == date);
      // }

      // if (booze != null)
      // {
      //   query = query.Where(entry => entry.Booze == booze);
      // }

      return await query.ToListAsync();
    }

    // POST api/events. 
    [HttpPost]
    public async Task<ActionResult<Event>> Post(Event event)
    {
      _db.Events.Add(event);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetEvent), new { id = event.EventId }, event);
    }

    // GET api/events/#
    [HttpGet("{id}")]
    public async Task<ActionResult<Event>> GetEvent(int id)
    {
      var event = await _db.Events.FindAsync(id);

      if (event == null)
      {
        return NotFound();
      }

      return event;
    }

    [HttpPut("{id")]
    public async Task<IActionResult> Put(int id, Event event)
    {
      if (id != event.EventId)
      {
        return BadRequest();
      }

      _db.Entry(event).State = EntityState.Modified;

      try
      {
        _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!EventExists(id))
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

    [HttpDelete("{id")]
    public async Task<ActionResult> DeleteEvent(int id)
    {
      var event = await _db.Events.FindAsync(id);
      if (event == null)
      {
        return NotFound();
      }

      _db.Events.Remove(event);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool EventExists(int id)
    {
      return _db.Events.Any(e => e.EventId == id);
    }
  }
}