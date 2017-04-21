using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId=1, CategoryName="Xbox One Games", Description="Games for the Xbox One console"},
                    new Category{CategoryId=2, CategoryName="PS4 Games", Description="Games for the PS4 console"},
                    new Category{CategoryId=3, CategoryName="PC Games", Description="Games for the PC"}
                };
            }
        }
    }
}
