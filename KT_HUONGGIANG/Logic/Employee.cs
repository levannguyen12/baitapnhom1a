using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_HUONGGIANG.Logic
{
    internal class Employee
    {
            public string IdEmployee { get; set; }
            public string Name { get; set; }
            public DateTime DateBirth { get; set; }
            public Boolean Gender { get; set; }
            public string PlaceBirth { get; set; }
            public string IdDepartment { get; set; }
            public Employee()
            {

            }
            public Employee(string id, string name, DateTime ngsinh, Boolean gt, string noisinh, string idDe)
            {

            this.IdEmployee = id;
            this.Name = name;
            this.DateBirth = ngsinh;
            this.Gender = gt;
            this.PlaceBirth = noisinh;
            this.IdDepartment = idDe;
            }
        }
}
