using EFCoreA1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbcontext = new ITIDbContext();

            List<Department> departments = new List<Department>
            {
                new Department(){ Name = "IT", HiringDate= new DateOnly(2025,10,10)},
                new Department(){ Name = "Logistics", HiringDate= new DateOnly(2025,10,18)}

            };

            //insert
            dbcontext.Set<Department>().AddRange(departments);
            dbcontext.SaveChanges();

            //Select
            var dept01 = (from D in dbcontext.Set<Department>()
                                           where D.Id ==1
                                           select D).FirstOrDefault();
            Console.WriteLine("Department's nmae before updating");
            Console.WriteLine(dept01.Name);

            if (dept01 != null)
            {
                dept01.Name = "Updated Department Name"; // Modify property
                dbcontext.SaveChanges(); // Save changes to database
                Console.WriteLine("Department updated successfully.");
            }
            else
            {
                Console.WriteLine("Department not found.");
            }

            if (dept01 != null)
            {
                dbcontext.Set<Department>().Remove(dept01); // Mark entity for deletion
                dbcontext.SaveChanges(); // Commit deletion
                Console.WriteLine("Department deleted successfully.");
            }
            else
            {
                Console.WriteLine("Department not found.");
            }

            //Eager Loading

            var instructors = dbcontext.Set<Department>().Include(D=>D.Instructors).FirstOrDefault(D=>D.Id==2);
        }
    }
}
