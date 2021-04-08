//using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCBasics;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class EmployeeController : BaseController<EmployeeController,EmployeeModel>
    {
        //private readonly IBaseRepository<EmployeeModel> _repo;

        public EmployeeController(IBaseRepository<EmployeeModel> repo) : base(repo)
        {
            
        }

        // GET: Employee
      
    }
}
