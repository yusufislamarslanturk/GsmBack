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
    public class MusteriController : ControllerBase
    {
        IMusteriService _musteriService;
        public MusteriController(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }
        [HttpGet("getall")]
        public IActionResult getAll()
        {
            var result = _musteriService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult getById(int id)
        {
            var result = _musteriService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallbyid")]
        public IActionResult getAllById(int id)
        {
            var result = _musteriService.GetAllByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult add(Musteri musteri)
        {
            var result = _musteriService.Add(musteri);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult update(Musteri musteri)
        {
            var result = _musteriService.Update(musteri);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult delete(Musteri musteri)
        {
            var result = _musteriService.Delete(musteri);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
