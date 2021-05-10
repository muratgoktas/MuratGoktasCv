using MuratGoktasCvPro.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuratGoktasCv.Interfaces
{
   public interface IPeopleService
    {
        List<People> GetAll();
        People Get();
        void Add();
        void Update();
        void Delete();

    }
}
