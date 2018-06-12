using LibraryData.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface IPatronService
    {


        IEnumerable<Patron> GetAll();
        Patron Get(int Id);
        void Add(Patron newPatron);

        string GetFirstName(int Id);

        string GetLastName(int Id);

        string GetAddress(int Id);

        DateTime GetDateOfBirth(int Id);

        IEnumerable<Patron> GetPatrons();
    }
}
