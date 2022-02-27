using HastaneDoktor.Entities;
using System.Collections.Generic;

namespace HastaneDoktor.Business.Abstract
{
    public interface IHastaneService
    {
        List<Hastane> GetAllHastane();

        Hastane CreateHastane(Hastane hastane);

        Hastane UpdateHastane(Hastane hastane);

        void DeleteHastane(int id);

    }
}
