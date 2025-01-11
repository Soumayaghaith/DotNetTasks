using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3VS
{
    [Flags]
    enum SecurityPriv { guest =1, Developer=2, secretary=4, DBA=8 }
    enum Gender { M, F}
    internal class Employee
    {
        #region Properties 
        public int Id { get; set; }
        public string Name { get; set; }
        private SecurityPriv securityLevel;
        private const SecurityPriv AllFlags = SecurityPriv.guest | SecurityPriv.Developer | SecurityPriv.secretary | SecurityPriv.DBA;

        public SecurityPriv SecurityLevel 
        {
            get { return securityLevel; }
            set 
            {
                if ( (value & ~AllFlags) !=0 )
                {
                    throw new ArgumentException("Invalid Security level");
                }
                securityLevel = value;  
            }
        
        }
        private Gender gender; //Full property for validation
        public Gender Gender
        {
            get { return gender; }
            set
            {
                if (value != Gender.F && value != Gender.M)
                {
                    throw new ArgumentException("Gender should be M or F");
                }
                gender = value;
            }

        }
        private double salary;
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative.");
                salary = value;
            }
        }
        public HiringDate HiringDate { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Security Level: {2}, Gender: {3}, Salary: {4:C}, Hire Date: {5}",
                Id,Name,SecurityLevel,Gender,Salary,HiringDate);
        }
        #endregion

        #region Constructor
        public Employee(int id, string name, SecurityPriv securityLevel, Gender gender, double salary, HiringDate hiringDate)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Gender = gender;
            Salary = salary;
            HiringDate = hiringDate;
            
        }
        #endregion



    }
}
