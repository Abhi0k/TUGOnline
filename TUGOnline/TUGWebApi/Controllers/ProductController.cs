using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TUGWebApi.Controllers
{
    //[Authorize]
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {

        private readonly IProductService _productServices;
        #region Public Constructor

        /// <summary>
        /// Public constructor to initialize product service instance
        /// </summary>
        public ProductController()
        {
            _productServices = new ProductService();
        }

        #endregion
        // GET: api/Product
        [Route("GetProducts")]
        public HttpResponseMessage Get()
        {
            var products = _productServices.GetProductList();
            if (products != null)
            {
                var productEntities = products as List<ProductEntity> ?? products.ToList();
                if (productEntities.Any())
                    return Request.CreateResponse(HttpStatusCode.OK, productEntities);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }


        // POST api/Product
        [Route("AddProduct")]
        public bool AddProduct([FromBody] ProductEntity _productEntity)
        {
            return _productServices.AddProduct(_productEntity);
        }

        // POST api/Product
        [Route("AddSubProduct")]
        public bool AddSubProduct([FromBody] SubProductEntity _subproductEntity)
        {
            return _productServices.AddSubProduct(_subproductEntity);
        }

        // POST api/Product
        [Route("AddVariant")]
        public bool AddVariant([FromBody] VariantEntity _variantEntity)
        {
            return _productServices.AddVariant(_variantEntity);
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
