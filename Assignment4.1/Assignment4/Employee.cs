using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Employee
    {
        protected int Empid;
        protected string Empname;
        protected float Salaryperhour;

        internal Employee(int Empid, string Empname, float Salaryperhour)
        {
            this.Empid = Empid;
            this.Empname = Empname;
            this.Salaryperhour = Salaryperhour;
        }
    }

    class ParttimeEmployee : Employee
    {
        float hoursofworking;
        internal ParttimeEmployee(int Empid, string Empname, float Salaryperhour, float hoursofworking) : base(Empid, Empname, Salaryperhour)
        {
            this.hoursofworking = hoursofworking;
        }
        internal float CalculateSalary()
        {
            return Salaryperhour * hoursofworking;
        }
        internal void DisplayDetails()
        {
            Console.WriteLine("Empolyeeid:{0}\nEmployee Name:{1}\nSalary:{2}", Empid, Empname, CalculateSalary());

        }
        static void Main()
        {
            ParttimeEmployee ptemployee = new ParttimeEmployee(10662951, "Manoj", 999.99f, 8.5f);
            ptemployee.DisplayDetails();
            Console.Read();

        }

    }

}

    
