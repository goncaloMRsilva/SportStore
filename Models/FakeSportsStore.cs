using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class FakeSportsStore : ISportsStoreRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product
            {
                Name = "Football",
                Price = 25
            },
            new Product
            {
                Name = "PranchaSurf",
                Price = 175
            },
            new Product
            {
                Name = "RunningShoes",
                Price = 40
            }
        };
    }
}
