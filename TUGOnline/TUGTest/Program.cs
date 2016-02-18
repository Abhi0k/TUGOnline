using BusinessLogicLayer;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace TUGTest
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductService p = new ProductService();
            p.GetProductList();


            //ProductEntity product = new ProductEntity();
            //product.ProductName = "Burger";
            //product.ProductDescription = "Burger Description";
            //product.ProductImagePath = "";
            //product.IsActive = true;
            //product.IsTopping = true;
            //product.LastModifyDate = DateTime.Now;
            //product.LastModifyBy = "Abhi";
            //product.CreatedDate = DateTime.Now;
            //product.CreatedBy = "Abhi";
            //p.InsertProduct(product);

            //SubProductEntity sp = new SubProductEntity();

            //sp.ProductID = 2;
            //sp.Name = "Ginger";
            //sp.IsVariant = false;
            //sp.Price = 30;
            //sp.SubProductDescription = "Ginger Description";
            //sp.LastModifyBy = "abhi";
            //sp.LastModifyDate = DateTime.Now;
            //sp.CreatedBy = "abhi";
            //sp.CreatedDate = DateTime.Now;
            //sp.IsActive = true;

            //p.AddSubProduct(sp);

            //VariantEntity v = new VariantEntity();
            //v.SubProductID = 1;
            //v.Name = "Medium";
            //v.Price = 139;
            //v.VariantDescription = "Serves-2";
            //v.LastModifyBy = "abhi";
            //v.LastModifyDate = DateTime.Now;
            //v.CreatedBy = "abhi";
            //v.CreatedDate = DateTime.Now;
            //v.IsActive = true;
            //p.AddVariant(v);



        }
    }
}
