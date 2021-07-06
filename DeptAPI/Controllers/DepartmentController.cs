using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DeptAPI.Models;
namespace DeptAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        Departments depts;

        public DepartmentController()
        {
            depts = new Departments();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(depts);
        }
    }
}