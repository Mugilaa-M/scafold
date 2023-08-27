using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoScafffold.Models
{
    public class EmployeeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
    }

    // To communicate with DB for retriving and saving the data Need to complete the code as follow

    public class EmpDBContext : DbContext
    {
        public DbSet<EmployeeData> Employees { get; set; }
    }


}