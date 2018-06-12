using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityTEST.Models.Patron
{
    public class PatronIndexModel
    {
        public IEnumerable<PatronListingModel> Patrons { get; set; }
    }
}
