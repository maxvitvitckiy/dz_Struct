using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Employee
{
    struct Date
    {
        public int day;
        public int month;
        public int year;
    }
    struct FIO
    {
        public string name;
        public string lastname;
        public string patronymic;
    }
    struct Employee
    {
        public FIO name;
        public int age;
        public Date birthDate;
        public string position;
        public Date hiringDate;
        public float salary;

    }
    


    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
