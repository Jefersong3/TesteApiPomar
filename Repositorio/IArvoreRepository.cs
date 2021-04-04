using System;
using System.Collections.Generic;
using ApiPomar.Models;

namespace ApiPomar.Repositorio
{
    public interface IArvoreRepository
    {
        void add(Arvores user);

        IEnumerable<Arvores> GettAll();

        Arvores Find(long id);

        void Remove(long id);

        void Update(Arvores user);
        IEnumerable<Arvores> GetAll();
    }
}