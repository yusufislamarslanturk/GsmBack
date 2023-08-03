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
    public class TarifeController : ControllerBase
    {
        ITarifeService _tarifeService;
        public TarifeController(ITarifeService tarifeService)
        {
            _tarifeService = tarifeService;
        }
        [HttpGet("getall")]
        public IActionResult getAll()
        {
            var result = _tarifeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult getById(int id)
        {
            var result = _tarifeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallbyid")]
        public IActionResult getAllById(int id)
        {
            var result = _tarifeService.GetAllByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult add(Tarife tarife)
        {
            var result = _tarifeService.Add(tarife);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult delete(Tarife tarife)
        {
            var result = _tarifeService.Delete(tarife);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult update(Tarife tarife)
        {
            var result = _tarifeService.Update(tarife);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result); 
        }
        [HttpGet("getbyprice")]
        public IActionResult getByPrice(decimal min,decimal max)
        {
            var result = _tarifeService.GetByUnitPrice(min,max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
