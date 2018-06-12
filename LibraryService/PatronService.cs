using LibraryData;
using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LibraryService
{
    public class PatronService : IPatronService
    {
        private readonly LibraryContext _context;

        public PatronService(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Patron newPatron)
        {
            _context.Add(newPatron);
            _context.SaveChanges();
        }

        public Patron Get(int Id)
        {
            return GetAll()
                .FirstOrDefault(p => p.Id == Id);
        }
        
        public IEnumerable<Patron> GetAll()
        {
            return _context.Patrons
                .Include(a => a.FirstName)
                .Include(a => a.LastName);
        }

        public string GetAddress(int Id)
        {
            return _context.Patrons.First(a => a.Id == Id).Address;
        }
        
        public DateTime GetDateOfBirth(int Id)
        {
            return _context.Patrons.First(a => a.Id == Id).DateOfBirth;
        }

        public string GetFirstName(int Id)
        {
            return _context.Patrons.First(a => a.Id == Id).FirstName;
        }

        public string GetLastName(int Id)
        {
            return _context.Patrons.First(a => a.Id == Id).LastName;
        }

        public IEnumerable<Patron> GetPatrons()
        {
            return new List<Patron>
            {
                new Patron
                {
                    Id = 1,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Address = "1 Main St",
                    DateOfBirth = new DateTime(1972, 01, 23)
                },

                new Patron
                {
                    Id = 2,
                    FirstName = "Jack",
                    LastName = "Smith",
                    Address = "Oak Drive",
                    DateOfBirth = new DateTime(1983, 07, 3)
                }
            };
        }
    }
}
