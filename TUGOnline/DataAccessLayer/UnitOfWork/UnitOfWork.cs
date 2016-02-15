using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;
using System.Data.Entity.Validation;

namespace DataAccessLayer.UnitOfWork
{
    /// <summary>
    /// Unit of Work class responsible for DB transactions
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        #region Private member variables...

        private TUGEntities _context = null;
        private GenericRepository<CUSTOMER> _customerRepository;
        private GenericRepository<CUSTOMER_ADDRESS> _custAddressRepository;
        private GenericRepository<DELIVERY_STAFF> _deliveryStaffRepository;
        private GenericRepository<MENU_MASTER> _menuRepository;
        private GenericRepository<ORDER_DETAILS> _orderDetailRepository;
        private GenericRepository<ORDER_MASTER> _orderRepository;
        private GenericRepository<ORDER_STATUS> _orderStatusRepository;
        private GenericRepository<PAYMENT> _paymentRepository;
        private GenericRepository<STORE> _storeRepository;
        private GenericRepository<SUBMENU_MASTER> _subMenuRepository;
        private GenericRepository<SUBMENU_VARIANT> _variantRepository;
        private GenericRepository<TOPPING> _toppingRepository;
        

        #endregion

        public UnitOfWork()
        {
            _context = new TUGEntities();
        }

        #region Public Repository Creation properties...

        /// <summary>
        /// Get/Set Property for CUSTOMER repository.
        /// </summary>
        public GenericRepository<CUSTOMER> CustomerRepository
        {
            get
            {
                if (this._customerRepository == null)
                    this._customerRepository = new GenericRepository<CUSTOMER>(_context);
                return _customerRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for CUSTOMER_ADDRESS repository.
        /// </summary>
        public GenericRepository<CUSTOMER_ADDRESS> AddressRepository
        {
            get
            {
                if (this._custAddressRepository == null)
                    this._custAddressRepository = new GenericRepository<CUSTOMER_ADDRESS>(_context);
                return _custAddressRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for DELIVERY_STAFF repository.
        /// </summary>
        public GenericRepository<DELIVERY_STAFF> DeliveryStaffRepository
        {
            get
            {
                if (this._deliveryStaffRepository == null)
                    this._deliveryStaffRepository = new GenericRepository<DELIVERY_STAFF>(_context);
                return _deliveryStaffRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for MENU MASTER repository.
        /// </summary>
        public GenericRepository<MENU_MASTER> MenuRepository
        {
            get
            {
                if (this._menuRepository == null)
                    this._menuRepository = new GenericRepository<MENU_MASTER>(_context);
                return _menuRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for order Details repository.
        /// </summary>
        public GenericRepository<ORDER_DETAILS> OrderDetailRepository
        {
            get
            {
                if (this._orderDetailRepository == null)
                    this._orderDetailRepository = new GenericRepository<ORDER_DETAILS>(_context);
                return _orderDetailRepository;
            }
        }
        /// <summary>
        /// Get/Set Property for order  repository.
        /// </summary>
        public GenericRepository<ORDER_MASTER> OrderRepository
        {
            get
            {
                if (this._orderRepository == null)
                    this._orderRepository = new GenericRepository<ORDER_MASTER>(_context);
                return _orderRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for order status repository.
        /// </summary>
        public GenericRepository<ORDER_STATUS> OrderStatusRepository
        {
            get
            {
                if (this._orderStatusRepository == null)
                    this._orderStatusRepository = new GenericRepository<ORDER_STATUS>(_context);
                return _orderStatusRepository;
            }
        }
        /// <summary>
        /// Get/Set Property for Payment repository.
        /// </summary>
        public GenericRepository<PAYMENT> PaymentRepository
        {
            get
            {
                if (this._paymentRepository == null)
                    this._paymentRepository = new GenericRepository<PAYMENT>(_context);
                return _paymentRepository;
            }
        }


        /// <summary>
        /// Get/Set Property for Store repository.
        /// </summary>
        public GenericRepository<STORE> StoreRepository
        {
            get
            {
                if (this._storeRepository == null)
                    this._storeRepository = new GenericRepository<STORE>(_context);
                return _storeRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for Submenu Master repository.
        /// </summary>
        public GenericRepository<SUBMENU_MASTER> SubMenuRepository
        {
            get
            {
                if (this._subMenuRepository == null)
                    this._subMenuRepository = new GenericRepository<SUBMENU_MASTER>(_context);
                return _subMenuRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for SubMenu Variant repository.
        /// </summary>
        public GenericRepository<SUBMENU_VARIANT> VariantRepository
        {
            get
            {
                if (this._variantRepository == null)
                    this._variantRepository = new GenericRepository<SUBMENU_VARIANT>(_context);
                return _variantRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for order Details repository.
        /// </summary>
        public GenericRepository<TOPPING> ToppingRepository
        {
            get
            {
                if (this._toppingRepository == null)
                    this._toppingRepository = new GenericRepository<TOPPING>(_context);
                return _toppingRepository;
            }
        }
        #endregion

        #region Public member methods...
        /// <summary>
        /// Save method.
        /// </summary>
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format("{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now, eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                throw e;
            }

        }

        #endregion

        #region Implementing IDiosposable...

        #region private dispose variable declaration...
        private bool disposed = false;
        #endregion

        /// <summary>
        /// Protected Virtual Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //Debug.WriteLine("UnitOfWork is being disposed");
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
