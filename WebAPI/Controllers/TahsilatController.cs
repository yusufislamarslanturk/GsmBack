using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TahsilatController : ControllerBase
    {
        ITahsilatService _tahsilatService;

        public TahsilatController(ITahsilatService tahsilatService)
        {
            _tahsilatService = tahsilatService;
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger
            //Dependency chain --

            var result = _tahsilatService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Tahsilat tahsilat)
        {
            var result = _tahsilatService.Add(tahsilat);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getallbyid")]
        public IActionResult GetById(int id)
        {
            var result = _tahsilatService.GetAllByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Tahsilat tahsilat)
        {
            var result = _tahsilatService.Delete(tahsilat);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyprice")]
        public IActionResult getbyprice(decimal minPrice,decimal maxPrice)
        {
            var result = _tahsilatService.GetByUnitPrice(minPrice,maxPrice);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}

