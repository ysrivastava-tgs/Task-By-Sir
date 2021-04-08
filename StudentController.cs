using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class StudentController : BaseController<StudentController, StudentModel>
    {
        private readonly IBaseRepository<StudentModel> _repo;

        public StudentController(IBaseRepository<StudentModel> repo) : base(repo)
        {

        }
    }
}
