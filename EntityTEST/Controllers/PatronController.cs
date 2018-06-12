using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityTEST.Models.Patron;
using LibraryData;
using Microsoft.AspNetCore.Mvc;

namespace EntityTEST.Controllers
{
    public class PatronController : Controller
    {

        private readonly IPatronService _patronService;

        public PatronController(IPatronService patronService)
        {
            _patronService = patronService;
        }

        public IActionResult Index()
        {


            var allPatrons = _patronService.GetPatrons();

            var patronModels = allPatrons
                .Select(p => new PatronListingModel
                {
                    Id = p.Id,
                    LastName = p.LastName,
                    FirstName = p.FirstName,
                    Address = p.Address,
                    DateOfBirth = p.DateOfBirth
                }).ToList();

            var model = new PatronIndexModel
            {
                Patrons = patronModels
            };

            return View(model);

            //return View();
        }
    }
}