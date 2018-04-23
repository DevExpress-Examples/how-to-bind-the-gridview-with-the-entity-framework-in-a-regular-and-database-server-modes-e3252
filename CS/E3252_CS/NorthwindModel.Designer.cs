﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace E3252_CS {
    #region Contexts

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class NorthwindEntities : ObjectContext {
        #region Constructors

        /// <summary>
        /// Initializes a new NorthwindEntities object using the connection string found in the 'NorthwindEntities' section of the application configuration file.
        /// </summary>
        public NorthwindEntities()
            : base("name=NorthwindEntities", "NorthwindEntities") {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        public NorthwindEntities(string connectionString)
            : base(connectionString, "NorthwindEntities") {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new NorthwindEntities object.
        /// </summary>
        public NorthwindEntities(EntityConnection connection)
            : base(connection, "NorthwindEntities") {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        #endregion

        #region Partial Methods

        partial void OnContextCreated();

        #endregion

        #region ObjectSet Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Product> Products {
            get {
                if ((_Products == null)) {
                    _Products = base.CreateObjectSet<Product>("Products");
                }
                return _Products;
            }
        }
        private ObjectSet<Product> _Products;

        #endregion
        #region AddTo Methods

        /// <summary>
        /// Deprecated Method for adding a new object to the Products EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProducts(Product product) {
            base.AddObject("Products", product);
        }

        #endregion
    }


    #endregion

    #region Entities

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "NorthwindModel", Name = "Product")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class Product : EntityObject {
        #region Factory Method

        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="productID">Initial value of the ProductID property.</param>
        /// <param name="productName">Initial value of the ProductName property.</param>
        /// <param name="discontinued">Initial value of the Discontinued property.</param>
        public static Product CreateProduct(global::System.Int32 productID, global::System.String productName, global::System.Boolean discontinued) {
            Product product = new Product();
            product.ProductID = productID;
            product.ProductName = productName;
            product.Discontinued = discontinued;
            return product;
        }

        #endregion
        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 ProductID {
            get {
                return _ProductID;
            }
            set {
                if (_ProductID != value) {
                    OnProductIDChanging(value);
                    ReportPropertyChanging("ProductID");
                    _ProductID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ProductID");
                    OnProductIDChanged();
                }
            }
        }
        private global::System.Int32 _ProductID;
        partial void OnProductIDChanging(global::System.Int32 value);
        partial void OnProductIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String ProductName {
            get {
                return _ProductName;
            }
            set {
                OnProductNameChanging(value);
                ReportPropertyChanging("ProductName");
                _ProductName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ProductName");
                OnProductNameChanged();
            }
        }
        private global::System.String _ProductName;
        partial void OnProductNameChanging(global::System.String value);
        partial void OnProductNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> SupplierID {
            get {
                return _SupplierID;
            }
            set {
                OnSupplierIDChanging(value);
                ReportPropertyChanging("SupplierID");
                _SupplierID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SupplierID");
                OnSupplierIDChanged();
            }
        }
        private Nullable<global::System.Int32> _SupplierID;
        partial void OnSupplierIDChanging(Nullable<global::System.Int32> value);
        partial void OnSupplierIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> CategoryID {
            get {
                return _CategoryID;
            }
            set {
                OnCategoryIDChanging(value);
                ReportPropertyChanging("CategoryID");
                _CategoryID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CategoryID");
                OnCategoryIDChanged();
            }
        }
        private Nullable<global::System.Int32> _CategoryID;
        partial void OnCategoryIDChanging(Nullable<global::System.Int32> value);
        partial void OnCategoryIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String QuantityPerUnit {
            get {
                return _QuantityPerUnit;
            }
            set {
                OnQuantityPerUnitChanging(value);
                ReportPropertyChanging("QuantityPerUnit");
                _QuantityPerUnit = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("QuantityPerUnit");
                OnQuantityPerUnitChanged();
            }
        }
        private global::System.String _QuantityPerUnit;
        partial void OnQuantityPerUnitChanging(global::System.String value);
        partial void OnQuantityPerUnitChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Decimal> UnitPrice {
            get {
                return _UnitPrice;
            }
            set {
                OnUnitPriceChanging(value);
                ReportPropertyChanging("UnitPrice");
                _UnitPrice = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UnitPrice");
                OnUnitPriceChanged();
            }
        }
        private Nullable<global::System.Decimal> _UnitPrice;
        partial void OnUnitPriceChanging(Nullable<global::System.Decimal> value);
        partial void OnUnitPriceChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> UnitsInStock {
            get {
                return _UnitsInStock;
            }
            set {
                OnUnitsInStockChanging(value);
                ReportPropertyChanging("UnitsInStock");
                _UnitsInStock = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UnitsInStock");
                OnUnitsInStockChanged();
            }
        }
        private Nullable<global::System.Int16> _UnitsInStock;
        partial void OnUnitsInStockChanging(Nullable<global::System.Int16> value);
        partial void OnUnitsInStockChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> UnitsOnOrder {
            get {
                return _UnitsOnOrder;
            }
            set {
                OnUnitsOnOrderChanging(value);
                ReportPropertyChanging("UnitsOnOrder");
                _UnitsOnOrder = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UnitsOnOrder");
                OnUnitsOnOrderChanged();
            }
        }
        private Nullable<global::System.Int16> _UnitsOnOrder;
        partial void OnUnitsOnOrderChanging(Nullable<global::System.Int16> value);
        partial void OnUnitsOnOrderChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int16> ReorderLevel {
            get {
                return _ReorderLevel;
            }
            set {
                OnReorderLevelChanging(value);
                ReportPropertyChanging("ReorderLevel");
                _ReorderLevel = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ReorderLevel");
                OnReorderLevelChanged();
            }
        }
        private Nullable<global::System.Int16> _ReorderLevel;
        partial void OnReorderLevelChanging(Nullable<global::System.Int16> value);
        partial void OnReorderLevelChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Boolean Discontinued {
            get {
                return _Discontinued;
            }
            set {
                OnDiscontinuedChanging(value);
                ReportPropertyChanging("Discontinued");
                _Discontinued = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Discontinued");
                OnDiscontinuedChanged();
            }
        }
        private global::System.Boolean _Discontinued;
        partial void OnDiscontinuedChanging(global::System.Boolean value);
        partial void OnDiscontinuedChanged();

        #endregion

    }

    #endregion
}