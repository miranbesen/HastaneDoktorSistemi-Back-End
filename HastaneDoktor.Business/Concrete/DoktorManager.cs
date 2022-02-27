using HastaneDoktor.Business.Abstract;
using HastaneDoktor.DataAccess.Abstract;
using HastaneDoktor.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HastaneDoktor.Business.Concrete
{
    public class DoktorManager : IDoktorService
    {
        private IDoktorRepository _doktorRepository;

        public DoktorManager(IDoktorRepository DoktorRepository)
        {
            _doktorRepository = DoktorRepository;
        }

        public Doktor CreateDoktor(Doktor doktor)
        {
           return  _doktorRepository.Create(doktor);
        }

        public void DeleteDoktor(int id)
        {
            _doktorRepository.Delete(id);
        }

        public List<Doktor> GetAllDoktor()
        {
            return _doktorRepository.GetAll().ToList();
        }

        public Doktor UpdateDoktor(Doktor doktor)
        {
            return _doktorRepository.Update(doktor);
        }

       
    }
}
