using HastaneDoktor.Entities;
using System.Collections.Generic;

namespace HastaneDoktor.Business.Abstract
{
    public interface IDoktorService 
    {
        List<Doktor> GetAllDoktor();
        Doktor CreateDoktor(Doktor doktor);
        Doktor UpdateDoktor(Doktor doktor);
        void DeleteDoktor(int id);

    }
}
