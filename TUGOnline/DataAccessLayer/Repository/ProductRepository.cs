using System.Linq;
using Entities;


namespace DataAccessLayer.Repository
{
    public class ProductRepository
    {
        #region Private member variables...
        //internal TUGEntities Context;
        //internal DbSet<MENU_MASTER> DbSetMenu;
        //internal DbSet<SUBMENU_MASTER> DbSetSubMenu;
        //internal DbSet<SUBMENU_VARIANT> DbSetVariant;
        private readonly UnitOfWork.UnitOfWork _unitOfWork;
        #endregion

        #region Public Constructor...
        /// <summary>
        /// Public Constructor,initializes privately declared local variables.
        /// </summary>
        /// <param name="context"></param>
        public ProductRepository()
        {
            _unitOfWork = new UnitOfWork.UnitOfWork();
        }
        #endregion

        public  void GetProductList()
        {

            var getSubProducts = _unitOfWork.SubProductRepository.GetAll().ToList();

            var variant = _unitOfWork.VariantRepository.Get().ToList();


        }


    }
}
