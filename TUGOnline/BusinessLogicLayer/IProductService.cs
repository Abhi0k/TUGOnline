using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogicLayer
{
    public interface IProductService
    {

        List<ProductEntity> GetProductList();
        bool AddProduct(ProductEntity _product);
        bool AddSubProduct(SubProductEntity _subProduct);
        bool AddVariant(VariantEntity _variant);
    }
}
