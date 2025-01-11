namespace OOP3VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "DBA Employee", SecurityPriv.DBA, Gender.M, 70000, new HiringDate { day = 1, month = 1, year = 2020 });
            

            EmpArr[1] = new Employee(2, "Guest Employee", SecurityPriv.guest, Gender.M, 30000, new HiringDate { day = 1, month = 1, year = 2022 });
            

            EmpArr[2] = new Employee(3, "Police Officer", SecurityPriv.guest | SecurityPriv.Developer | SecurityPriv.secretary | SecurityPriv.DBA, Gender.M, 30000, new HiringDate { day = 1, month = 1, year = 2023 });
            int boxingCount = 0, unboxingCounts = 0;
            Array.Sort(EmpArr, (emp1,emp2) =>
            {
                //Boxing happens when comparing the HiringDate (value types are boxed)
                boxingCount++;
                int result = emp1.HiringDate.CompareTo(emp2.HiringDate);

                //Unboxing happens when accessing value types from boxed objects
                unboxingCounts++;
                return result;
            
            });

            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp.ToString());
            }

            Console.WriteLine($"Boxing happened {boxingCount} times\nUnboxing happened {unboxingCounts}times");
        }
    }
}
