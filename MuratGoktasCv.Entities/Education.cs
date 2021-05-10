using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratGoktasCvPro.Entities
{
    public class Education
    {
        public int Id { get; set; }
        public int SchoolName { get; set; }
        public string Department { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public int Degree { get; set; }
        public string OtherInfo { get; set; }
    }
}
