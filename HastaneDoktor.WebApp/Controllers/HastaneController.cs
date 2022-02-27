using HastaneDoktor.Business.Abstract;
using HastaneDoktor.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HastaneDoktor.WebApp.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HastaneController : ControllerBase
    {

        private readonly  IHastaneService _hastaneService;

        public HastaneController(IHastaneService HastaneManager)
        {
            _hastaneService = HastaneManager;
        }
    

        [HttpGet]
        public List<Hastane> Get()
        {
            return _hastaneService.GetAllHastane().ToList();
        }

      


        [HttpPost]
        public Hastane Post(Hastane hastane)
        {
            return _hastaneService.CreateHastane(hastane);
        }

        [HttpPut]
        public Hastane Put(Hastane hastane)
        {
            return _hastaneService.UpdateHastane(hastane);
         }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _hastaneService.DeleteHastane(id);
        }

    }
}
