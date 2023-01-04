using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_HUONGGIANG.Logic
{
    internal class Department
    {
        public string IdDeparment { get; set; }
        public string Name { get; set; }
        public Department()
        {

        }
        public Department(string id, string name)
        {

            this.IdDeparment = id;
            this.Name = name;
        }
    }
}
