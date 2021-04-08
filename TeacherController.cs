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
    
        public class TeacherController : BaseController<TeacherController, TeacherModel>
        {
            private readonly IBaseRepository<TeacherModel> _repo;

            public TeacherController(IBaseRepository<TeacherModel> repo) : base(repo)
            {

            }
        }
   
}
