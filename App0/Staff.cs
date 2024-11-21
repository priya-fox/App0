
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SQLite; 

namespace App0
{
    public class Staff
    {
        [PrimaryKey,AutoIncrement]
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressZip { get; set; }
        public string AddressCountry { get; set; }

    }
}
