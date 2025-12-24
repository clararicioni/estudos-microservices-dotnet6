using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public interface IFragranceService
    {
        Fragrance Create(Fragrance fragrance);
        Fragrance FindByID(long id);
        Fragrance Update(Fragrance fragrance);
        List<Fragrance> FindAll();
        void Delete(long id);
    }
}
