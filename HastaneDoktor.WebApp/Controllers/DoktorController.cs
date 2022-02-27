using HastaneDoktor.Business.Abstract;
using HastaneDoktor.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HastaneDoktor.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoktorController : ControllerBase
    {
        private readonly IDoktorService _doktorService;

        public DoktorController(IDoktorService DoktorManager)
        {
            _doktorService = DoktorManager;
        }


        [HttpGet]
        public List<Doktor> Get()
        {
            return _doktorService.GetAllDoktor().ToList();
        }

        [HttpPost]
        public Doktor Post(Doktor doktor)
        {
            return _doktorService.CreateDoktor(doktor);
        }

        [HttpPut]
        public Doktor Put(Doktor doktor)
        {
            return _doktorService.UpdateDoktor(doktor);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _doktorService.DeleteDoktor(id);
        }
    }
}
