using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HRApplication.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {      
        public HRContext _ctx;

        public UserController(HRContext ctx)
        {
            _ctx = ctx;
        }

        //GET

        [AllowAnonymous]
        [HttpGet("Users")]
        public IEnumerable<User> GetUsers()
        {
            return _ctx.Users.ToList();
        }

        [AllowAnonymous]
        [HttpGet("Companies")]
        public IEnumerable<Company> GetCompanies()
        {
            return _ctx.Companies.ToList();
        }

        [AllowAnonymous]
        [HttpGet("Jobs")]
        public IEnumerable<JobPosition> GetJobs()
        {
            return _ctx.JobPositions.ToList();
        }

        //POST

        [HttpPost("CreateUser")]
        public IActionResult CreateRegUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            _ctx.Add(user);
            _ctx.SaveChanges();

            return Created("api/user", user);
        }

        [HttpPost("CreateCompany")]
        public IActionResult CreateCompany([FromBody] Company company)
        {
            if (company == null)
            {
                return BadRequest();
            }
            _ctx.Add(company);
            _ctx.SaveChanges();

            return Created("api/user", company);
        }

        [HttpPost("CreateJob")]
        public IActionResult CreateJob([FromBody] JobPosition job)
        {
            if (job == null)
            {
                return BadRequest();
            }
            _ctx.Add(job);
            _ctx.SaveChanges();

            return Created("api/user", job);
        }

        //PUT

        [HttpPut("UpdateUser/{UserId}")]
        public IActionResult UpdateUser(int UserId, [FromBody] User updateUser)
        {
            if (updateUser == null)
            {
                return BadRequest();
            }

            var todo = _ctx.Users.Find(UserId);
            if (todo == null)
            {
                return NotFound();
            }

            todo.Name = updateUser.Name;
            todo.Surname = updateUser.Surname;
            todo.City = updateUser.City;
            todo.Country = updateUser.Country;
            todo.ChangeLocation = updateUser.ChangeLocation;
            todo.FullOrPartTime = updateUser.FullOrPartTime;
            todo.WorkExperience = updateUser.WorkExperience;
            todo.HistoryOfJobs = updateUser.HistoryOfJobs;
            todo.Keywords = updateUser.Keywords;

            _ctx.SaveChanges();

            return Ok();
        }

        [HttpPut("UpdateCompany/{CompanyId}")]
        public IActionResult UpdateCompany(int CompanyId, [FromBody]Company updateCompany)
        {
            if (updateCompany == null)
            {
                return BadRequest();
            }

            var todo = _ctx.Companies.Find(CompanyId);
            if (todo == null)
            {
                return NotFound();
            }

            todo.Name = updateCompany.Name;
            todo.Description = updateCompany.Description;
            todo.City = updateCompany.City;
            todo.Country = updateCompany.Country;
            todo.Phone = updateCompany.Phone;
            todo.Email = updateCompany.Email;
            todo.Website = updateCompany.Website;

            _ctx.SaveChanges();

            return Ok();
        }
        [HttpPut("UpdateJob/{JobId}")]
        public IActionResult UpdateJob(int JobId, [FromBody] JobPosition updateJob)
        {
            if (updateJob == null)
            {
                return BadRequest();
            }

            var todo = _ctx.JobPositions.Find(JobId);
            if (todo == null)
            {
                return NotFound();
            }

            todo.Name = updateJob.Name;
            todo.Description = updateJob.Description;
            todo.City = updateJob.City;
            todo.Country = updateJob.Country;
            todo.FullOrPartTime = updateJob.FullOrPartTime;
            todo.Keywords = updateJob.Keywords;

            _ctx.SaveChanges();

            return Ok();
        }

        //DELETE

        [HttpDelete("deleteUser/{UserId}")]
        public IActionResult deleteUser(int UserId)
        {
            var todo = _ctx.Users.Find(UserId);
            if (todo == null)
            {
                return NotFound();
            }
            _ctx.Users.Remove(todo);
            _ctx.SaveChanges();

            return Ok();
        }

        [HttpDelete("deleteCompany/{CompanyId}")]
        public IActionResult deleteCompany(int CompanyId)
        {
            var todo = _ctx.Companies.Find(CompanyId);
            if (todo == null)
            {
                return NotFound();
            }
            _ctx.Companies.Remove(todo);
            _ctx.SaveChanges();

            return Ok();
        }

        [HttpDelete("deleteJob/{JobId}")]
        public IActionResult deleteJob(int JobId)
        {
            var todo = _ctx.JobPositions.Find(JobId);
            if (todo == null)
            {
                return NotFound();
            }
            _ctx.JobPositions.Remove(todo);
            _ctx.SaveChanges();

            return Ok();
        }
    }
}
