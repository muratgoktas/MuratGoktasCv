using MuratGoktasCv.Dal.Abstract;
using MuratGoktasCvPro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuratGoktasCv.Dal.Concrete.EntityFramework
{
   

    public class EfPersonDal : IPersonDal
    {
        private MuratGoktasCvContext _context = new MuratGoktasCvContext();
        public void Add(People people)
        {
            _context.People.Add(people);
            _context.SaveChanges();
        }

        public void Delete(int peopleId)
        {
             _context.People.Remove(_context.People.FirstOrDefault(p=>p.Id==peopleId));
            _context.SaveChanges();
        }

        public People Get(int peopleId)
        {
            return _context.People.FirstOrDefault(p => p.Id == peopleId);// veya
           // return _context.People.Where(p => p.Id == peopleId).FirstOrDefault();
        }

        public List<People> Getall()
        {
            return _context.People.ToList();
        }

        public void Update(People people)
        {
            People peopleUpdate = _context.People.FirstOrDefault(p => p.Id == people.Id);
            peopleUpdate.FirstName = people.FirstName;
            peopleUpdate.MiddleName = people.MiddleName;
            peopleUpdate.LastName = people.LastName;
            peopleUpdate.MaritalStatus = people.MaritalStatus;
            peopleUpdate.MilitaryStatus = people.MilitaryStatus;
            peopleUpdate.Picture = people.Picture;
            peopleUpdate.PictureUrl = people.PictureUrl;
            _context.SaveChanges();
        }
    }
}
