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
    public class MusteriTarifeController : ControllerBase
    {
        IMusteriTarifeService _musteriTarifeService;

        public MusteriTarifeController(IMusteriTarifeService musteriTarifeService)
        {
            _musteriTarifeService = musteriTarifeService;
        }
        [HttpGet("getall")]
        public IActionResult getAll()
        {
            var result = _musteriTarifeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult getById(int id)
        {
            var result = _musteriTarifeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallbyid")]
        public IActionResult getAllById(int id)
        {
            var result = _musteriTarifeService.GetAllByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getprice")]
        public IActionResult getPrice(decimal min,decimal max)
        {
            var result = _musteriTarifeService.GetByUnitPrice(min, max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult delete(MusteriTarife musteriTarife)
        {
            var result = _musteriTarifeService.Delete(musteriTarife);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult add(MusteriTarife musteriTarife)
        {
            var result = _musteriTarifeService.Add(musteriTarife);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult update(MusteriTarife musteriTarife)
        {
            var result = _musteriTarifeService.Update(musteriTarife);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getdetails")]
        public IActionResult getDetails()
        {
            var result = _musteriTarifeService.GetMusteriTarifeDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }





    }
}
