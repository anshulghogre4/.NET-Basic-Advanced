using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminstrationAPI
{
    public interface IEmployee
    {
        // this interfacr thus we do not need acces specifier here before properties
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
    }
}
