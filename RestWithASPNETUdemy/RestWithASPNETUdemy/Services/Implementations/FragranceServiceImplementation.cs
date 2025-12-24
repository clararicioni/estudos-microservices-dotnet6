using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class FragranceServiceImplementation : IFragranceService
    {
        private volatile int count;
        public Fragrance Create(Fragrance fragrance)
        {
            return fragrance;
        }

        public void Delete(long id)
        {
            
        }

        public List<Fragrance> FindAll()
        {
            List<Fragrance> fragrances = new List<Fragrance>();
            for (int i = 0; i < 8; i++)
            {
                Fragrance fragrance = MockFragrance(i);
                fragrances.Add(fragrance);
            }
            return fragrances;
        }

        private Fragrance MockFragrance(int i)
        {
            return new Fragrance
            {
                Id = IncrementAndGet(),
                Name = "Fragrance Name " + i,
                Brand = "Fragrance Brand " + i,
                Gender = "Fragrance Gender " + i,
                Note = "Orange Blossom"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public Fragrance FindByID(long id)
        {
            return new Fragrance
            {
                Id = IncrementAndGet(),
                Name = "212 NYC",
                Brand = "Carolina Herrera",
                Gender = "For Her",
                Note = "Orange Blossom"
            };
        }

        public Fragrance Update(Fragrance fragrance)
        {
            return fragrance;
        }
    }
}
