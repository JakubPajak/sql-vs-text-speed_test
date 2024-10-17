using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDB_SpeedTest.Models
{
    public class BasicDataDto
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{this.Name} | {this.Surname} | {this.DateOfBirth.ToString()} | {this.Phone.ToString()}";
        }
    }
}
