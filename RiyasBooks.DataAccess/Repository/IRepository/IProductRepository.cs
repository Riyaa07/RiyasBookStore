using RiyasBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiyasBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository: IRepository<Product>
    {

        void Update(Product product);
       
    }
}
