using System.Collections.Generic;
using System.Linq;
using ApiPomar.Models;

namespace ApiPomar.Repositorio
{
    public class ArvoreRepository : IArvoreRepository
    {
        private readonly ArvoresDbContext _contexto;
        public ArvoreRepository(ArvoresDbContext ctx)
        {
            _contexto = ctx;
        }
        public void add(Arvores Arvore)
        {
            _contexto.Arvores.Add(Arvore);
            _contexto.SaveChanges();
        }

        public Arvores Find(long id)
        {
            return _contexto.Arvores.FirstOrDefault(u => u.ArvoreId == id);
        }

        public IEnumerable<Arvores> GetAll()
        {
            return _contexto.Arvores.ToList();
        }

        public IEnumerable<Arvores> GettAll()
        {
            return _contexto.Arvores.ToList();
        }

        public void Remove(long id)
        {
            var entity = _contexto.Arvores.First(u=> u.ArvoreId == id);
            _contexto.Arvores.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Update(Arvores Arvore)
        {
            _contexto.Arvores.Update(Arvore);
            _contexto.SaveChanges();
        }
    }
}