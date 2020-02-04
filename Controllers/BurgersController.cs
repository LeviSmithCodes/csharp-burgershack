using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharp_burgershack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using csharp_burgershack.Services;

namespace csharp_burgershack.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class BurgersController : ControllerBase
  {
    private readonly BurgersService _bs;
    public BurgersController(BurgersService bs)
    {
      _bs = bs;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Burger>> GetAll()
    {
      try
      {
        return Ok(_bs.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{burgerId}")]
    public ActionResult<Burger> GetAction(int burgerId)
    {
      try
      {
        return Ok(_bs.GetById(burgerId));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Burger> Create([FromBody] Burger newBurger)
    {
      try
      {
        return Ok(_bs.Create(newBurger));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Burger> Edit(int id, [FromBody] Burger burgerUpdate)
    {
      try
      {
        burgerUpdate.Id = id;
        return Ok(_bs.Edit(burgerUpdate));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<int> Delete(int id)
    {
      try
      {
        return Ok(_bs.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
