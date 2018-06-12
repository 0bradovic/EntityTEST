using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityTEST.Models.Patron
{
    public class PatronListingModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}
