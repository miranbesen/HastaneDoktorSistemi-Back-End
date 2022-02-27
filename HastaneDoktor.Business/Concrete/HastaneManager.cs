using HastaneDoktor.Business.Abstract;
using HastaneDoktor.DataAccess.Abstract;
using HastaneDoktor.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HastaneDoktor.Business.Concrete
{
    public class HastaneManager : IHastaneService
    {

        private IHastaneRepository _hastaneRepository;

        public HastaneManager(IHastaneRepository HastaneRepository)
        {
            _hastaneRepository = HastaneRepository;
        }

        public Hastane CreateHastane(Hastane hastane)
        {
            return _hastaneRepository.Create(hastane);
        }

        public void DeleteHastane(int id)
        {
            _hastaneRepository.Delete(id);
        }

        public List<Hastane> GetAllHastane()
        {
            return _hastaneRepository.GetAll().ToList();
        }

        public Hastane UpdateHastane(Hastane hastane)
        {
            return _hastaneRepository.Update(hastane);
        }
    }
}
