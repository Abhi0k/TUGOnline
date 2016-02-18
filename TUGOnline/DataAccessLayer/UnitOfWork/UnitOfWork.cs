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

        private TUGDBEntities _context = null;
        private GenericRepository<Customer> _customerRepository;
        private GenericRepository<CustomerAddress> _custAddressRepository;
        private GenericRepository<DeliveryStaff> _deliveryStaffRepository;
        private GenericRepository<Product> _productRepository;
        private GenericRepository<OrderDetail> _orderDetailRepository;
        private GenericRepository<Order> _orderRepository;
        private GenericRepository<OrderStatu> _orderStatusRepository;
        private GenericRepository<Payment> _paymentRepository;
        private GenericRepository<Store> _storeRepository;
        private GenericRepository<SubProduct> _subProductRepository;
        private GenericRepository<Variant> _variantRepository;
        private GenericRepository<Topping> _toppingRepository;
        

        #endregion

        public UnitOfWork()
        {
            _context = new TUGDBEntities();
        }

        #region Public Repository Creation properties...

        /// <summary>
        /// Get/Set Property for CUSTOMER repository.
        /// </summary>
        public GenericRepository<Customer> CustomerRepository
        {
            get
            {
                if (this._customerRepository == null)
                    this._customerRepository = new GenericRepository<Customer>(_context);
                return _customerRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for CUSTOMER_ADDRESS repository.
        /// </summary>
        public GenericRepository<CustomerAddress> AddressRepository
        {
            get
            {
                if (this._custAddressRepository == null)
                    this._custAddressRepository = new GenericRepository<CustomerAddress>(_context);
                return _custAddressRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for DELIVERY_STAFF repository.
        /// </summary>
        public GenericRepository<DeliveryStaff> DeliveryStaffRepository
        {
            get
            {
                if (this._deliveryStaffRepository == null)
                    this._deliveryStaffRepository = new GenericRepository<DeliveryStaff>(_context);
                return _deliveryStaffRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for Product repository.
        /// </summary>
        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (this._productRepository == null)
                    this._productRepository = new GenericRepository<Product>(_context);
                return _productRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for order Details repository.
        /// </summary>
        public GenericRepository<OrderDetail> OrderDetailRepository
        {
            get
            {
                if (this._orderDetailRepository == null)
                    this._orderDetailRepository = new GenericRepository<OrderDetail>(_context);
                return _orderDetailRepository;
            }
        }
        /// <summary>
        /// Get/Set Property for order  repository.
        /// </summary>
        public GenericRepository<Order> OrderRepository
        {
            get
            {
                if (this._orderRepository == null)
                    this._orderRepository = new GenericRepository<Order>(_context);
                return _orderRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for order status repository.
        /// </summary>
        public GenericRepository<OrderStatu> OrderStatusRepository
        {
            get
            {
                if (this._orderStatusRepository == null)
                    this._orderStatusRepository = new GenericRepository<OrderStatu>(_context);
                return _orderStatusRepository;
            }
        }
        /// <summary>
        /// Get/Set Property for Payment repository.
        /// </summary>
        public GenericRepository<Payment> PaymentRepository
        {
            get
            {
                if (this._paymentRepository == null)
                    this._paymentRepository = new GenericRepository<Payment>(_context);
                return _paymentRepository;
            }
        }


        /// <summary>
        /// Get/Set Property for Store repository.
        /// </summary>
        public GenericRepository<Store> StoreRepository
        {
            get
            {
                if (this._storeRepository == null)
                    this._storeRepository = new GenericRepository<Store>(_context);
                return _storeRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for SubProduct repository.
        /// </summary>
        public GenericRepository<SubProduct> SubProductRepository
        {
            get
            {
                if (this._subProductRepository == null)
                    this._subProductRepository = new GenericRepository<SubProduct>(_context);
                return _subProductRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for  Variant repository.
        /// </summary>
        public GenericRepository<Variant> VariantRepository
        {
            get
            {
                if (this._variantRepository == null)
                    this._variantRepository = new GenericRepository<Variant>(_context);
                return _variantRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for order Details repository.
        /// </summary>
        public GenericRepository<Topping> ToppingRepository
        {
            get
            {
                if (this._toppingRepository == null)
                    this._toppingRepository = new GenericRepository<Topping>(_context);
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
