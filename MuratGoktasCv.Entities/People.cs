using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratGoktasCvPro.Entities
{
    public class People
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        
        public DateTime BirthDate { get; set; }
        public string BirthCity { get; set; }
        public string MaritalStatus { get; set; }
        public string MilitaryStatus { get; set; }
        public string PictureUrl { get; set; }
        public string Picture { get; set; }
        public string FullName => $" {FirstName}{MiddleName}{LastName}";

    }
}
