using DataAccessLayer.UnitOfWork;
using System.Linq;
using Entities;
using DataAccessLayer;
using AutoMapper;
using System.Transactions;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class ProductService : IProductService
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public ProductService()
        {
            _unitOfWork = new UnitOfWork();
        }

        #region GetProduct Details

        /// <summary>
        /// Method To Get product List along the Subproducts and Variant if any.
        /// </summary>
        /// <returns></returns>
        public List<ProductEntity> GetProductList()
        {

            var _products = _unitOfWork.ProductRepository.GetAll().ToList();

            var productsModel = Mapper.DynamicMap<List<Product>, List<ProductEntity>>(_products);

            return productsModel;
        }
        #endregion

        #region Add Product Deatils To DataBase From UI

        /// <summary>
        /// Method To Insert Product Into DB From UI
        /// </summary>
        /// <param name="_product"></param>
        /// <returns></returns>
        public bool AddProduct(ProductEntity _product)
        {
            bool isSuccess = false;
            using (var scope = new TransactionScope())
            {
                //var config = new MapperConfiguration(cfg => { cfg.CreateMap<ProductEntity, Product>(); });

                //IMapper mapper = config.CreateMapper();

                // var productsModel = mapper.Map<ProductEntity, Product>(_product);
                var productsModel = Mapper.DynamicMap<ProductEntity, Product>(_product);
                

                _unitOfWork.ProductRepository.Insert(productsModel);
                _unitOfWork.Save();
                scope.Complete();
                isSuccess = true;
            }

            return isSuccess;

        }

        /// <summary>
        /// Method To Insert Sub Product tnto DB From UI
        /// </summary>
        /// <param name="_subProduct"></param>
        /// <returns></returns>
        public bool AddSubProduct(SubProductEntity _subProduct)
        {
            bool isSuccess = false;
            using (var scope = new TransactionScope())
            {
                //var config = new MapperConfiguration(cfg => { cfg.CreateMap<SubProductEntity, SubProduct>(); });

                //IMapper mapper = config.CreateMapper();

                //var subProducts = mapper.Map<SubProductEntity, SubProduct>(_subProduct);
                var subProducts = Mapper.DynamicMap<SubProductEntity, SubProduct>(_subProduct);

                _unitOfWork.SubProductRepository.Insert(subProducts);
                _unitOfWork.Save();
                scope.Complete();
                isSuccess = true;
            }

            return isSuccess;

        }

        /// <summary>
        /// Method To Insert Variant Into DB from UI
        /// </summary>
        /// <param name="_variant"></param>
        /// <returns></returns>
        public bool AddVariant(VariantEntity _variant)
        {
            bool isSuccess = false;
            using (var scope = new TransactionScope())
            {
                //var config = new MapperConfiguration(cfg => { cfg.CreateMap<VariantEntity, Variant>(); });

                //IMapper mapper = config.CreateMapper();

                //var subProducts = mapper.Map<VariantEntity, Variant>(_variant);

                var variant = Mapper.DynamicMap<VariantEntity, Variant>(_variant);

                _unitOfWork.VariantRepository.Insert(variant);
                _unitOfWork.Save();
                scope.Complete();
                isSuccess = true;
            }

            return isSuccess;

        }
        #endregion
    }
}
