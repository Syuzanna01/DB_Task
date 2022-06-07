using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new HRDatabaseEntities1();
            var Employees_Table = new Employees_Table
            {
                ID = 1,
                Firstname = "Angelina",
                Lastname = "Jolly",
                Employee_identification_number = 1,
                Birth_date = DateTime.Now,
                Gender = "Female",
                Contact_number = "+374771564**",
                email = "fgdsgadrg@gmail.com"
            };
            context.Employees_Tables.Add(Employees_Table);
            context.SaveChanges();
        }
    }
}
