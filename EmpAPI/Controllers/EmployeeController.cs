using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmpAPI.Models;
namespace EmpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        Employees emps;

        public EmployeeController()
        {
            emps = new Employees();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(emps);
        }
    }
}