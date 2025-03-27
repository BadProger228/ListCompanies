using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Employees
{
    internal class Project
    {
        public string _name { get; set; }
        public string? pathFile { get; set; }
        
        public Project(string name, string pathFile) {
            _name = name;
            this.pathFile = pathFile;
            
        }
    }
}
