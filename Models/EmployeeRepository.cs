using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOADMORE.Models
{
    public class EmployeeRepository
    {
        private readonly AppDbCon _con;
        public EmployeeRepository(AppDbCon con)
        {
            _con = con;
        }

        
        private const int pagesize = 10;

        public List<Employee> GetEmployees(int? pageNumber)
        {
            var numberOfRecordToskip = pageNumber * pagesize;
            return _con.Employees.Skip(Convert.ToInt32(numberOfRecordToskip)).Take(pagesize).ToList<Employee>();
            
        }

    }
}
