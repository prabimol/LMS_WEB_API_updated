using LMS_WEB_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly LMSDbContext context;
        [Route("InsertEmployee")]
        [HttpPost]
        public object RegisterEmployee(Employee employee)
        {
            try
            {

                //EmployeeLogin EL = new EmployeeLogin();
                
                    context.Employees.Add(employee);
                     context.SaveChanges();
                    return new Response
                    { Status = "Success", Message = "Record SuccessFully Saved." };
                
            }
            catch (Exception)
            {

                return new Response
                { Status = "Error", Message = "Error occured." };
            }
            
        }
        [Route("Login")]
        [HttpPost]
        public Response EmployeeLogin(Login login)
        {
            var log = context.Employees.Find(login.EmployeeId);

            if (log == null)
            {
                return new Response { Status = "Invalid", Message = "Invalid User." };
            }
            else
                return new Response { Status = "Success", Message = "Login Successfully" };
        }
    }
}

