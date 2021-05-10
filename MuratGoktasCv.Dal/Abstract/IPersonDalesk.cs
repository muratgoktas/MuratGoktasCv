using MuratGoktasCvPro.Entities;
using System.Collections.Generic;


namespace MuratGoktasCv.Dal.Abstract
{
    public interface IPersonDal
    {
        List<People> Getall();
        People Get(int peopleId);
        void Add(People people);
        void Delete(int peopleId);
        void Update(People people);
    }
}
