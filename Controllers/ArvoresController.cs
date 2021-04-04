using System.Collections.Generic;
using ApiPomar.Models;
using ApiPomar.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ApiPomar.Controllers
{
    [Route("api/[Controller]")]
    public class ArvoresController : Controller
    {
        private readonly IArvoreRepository _arvoreRepository;
        private long id;

        public ArvoresController(IArvoreRepository arvoreRepo)
        {
            _arvoreRepository = arvoreRepo;
        }

        [HttpGet]

        public IEnumerable<Arvores> GetAll()
        {
            return _arvoreRepository.GetAll();
        }

        [HttpGet("{id}", Name="GetArvore")]
        public IActionResult GetById(long Id)
        {
            var arvore = _arvoreRepository.Find(id);
            if (arvore==null)
                return NotFound();

            return new ObjectResult(arvore);
        }
        
    }
}