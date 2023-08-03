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
    public class FaturaController : ControllerBase
    {
        IFaturaService _faturaService;

        public FaturaController(IFaturaService faturaService)
        {
            _faturaService = faturaService;
        }
        [HttpGet("getall")]
        public IActionResult getAll()
        {
            var result = _faturaService.GetAll();
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }
        [HttpGet("getbyprice")]
        public IActionResult getByPrice(decimal minPrice,decimal maxPrice)
        {
            var result = _faturaService.GetByUnitPrice(minPrice, maxPrice);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallbyid")]
        public IActionResult getallbyid(int id)
        {
            var result = _faturaService.GetAllByCategoryId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult add(Fatura fatura)
        {
            var result = _faturaService.Add(fatura);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult update(Fatura fatura)
        {
            var result = _faturaService.Update(fatura);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult delete(Fatura fatura)
        {
            var result = _faturaService.Delete(fatura);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
