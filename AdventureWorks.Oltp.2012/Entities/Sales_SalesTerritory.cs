// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.5
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // SalesTerritory
    ///<summary>
    /// Sales territory lookup table.
    ///</summary>
    [Table("SalesTerritory", Schema = "Sales")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Sales_SalesTerritory
    {

        ///<summary>
        /// Primary key for SalesTerritory records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"TerritoryID", Order = 1, TypeName = "int")]
        [Index(@"PK_SalesTerritory_TerritoryID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Territory ID")]
        public int TerritoryId { get; set; } // TerritoryID (Primary key)

        ///<summary>
        /// Sales territory description
        ///</summary>
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Index(@"AK_SalesTerritory_Name", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        ///</summary>
        [Column(@"CountryRegionCode", Order = 3, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Country region code")]
        public string CountryRegionCode { get; set; } // CountryRegionCode (length: 3)

        ///<summary>
        /// Geographic area to which the sales territory belong.
        ///</summary>
        [Column(@"Group", Order = 4, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Group")]
        public string Group { get; set; } // Group (length: 50)

        ///<summary>
        /// Sales in the territory year to date.
        ///</summary>
        [Column(@"SalesYTD", Order = 5, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Sales ytd")]
        public decimal SalesYtd { get; set; } // SalesYTD

        ///<summary>
        /// Sales in the territory the previous year.
        ///</summary>
        [Column(@"SalesLastYear", Order = 6, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Sales last year")]
        public decimal SalesLastYear { get; set; } // SalesLastYear

        ///<summary>
        /// Business costs in the territory year to date.
        ///</summary>
        [Column(@"CostYTD", Order = 7, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Cost ytd")]
        public decimal CostYtd { get; set; } // CostYTD

        ///<summary>
        /// Business costs in the territory the previous year.
        ///</summary>
        [Column(@"CostLastYear", Order = 8, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Cost last year")]
        public decimal CostLastYear { get; set; } // CostLastYear

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 9, TypeName = "uniqueidentifier")]
        [Index(@"AK_SalesTerritory_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 10, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Person_StateProvinces where [StateProvince].[TerritoryID] point to this entity (FK_StateProvince_SalesTerritory_TerritoryID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Person_StateProvince> Person_StateProvinces { get; set; } // StateProvince.FK_StateProvince_SalesTerritory_TerritoryID
        /// <summary>
        /// Child Sales_Customers where [Customer].[TerritoryID] point to this entity (FK_Customer_SalesTerritory_TerritoryID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_Customer> Sales_Customers { get; set; } // Customer.FK_Customer_SalesTerritory_TerritoryID
        /// <summary>
        /// Child Sales_SalesOrderHeaders where [SalesOrderHeader].[TerritoryID] point to this entity (FK_SalesOrderHeader_SalesTerritory_TerritoryID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesTerritory_TerritoryID
        /// <summary>
        /// Child Sales_SalesPersons where [SalesPerson].[TerritoryID] point to this entity (FK_SalesPerson_SalesTerritory_TerritoryID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SalesPerson> Sales_SalesPersons { get; set; } // SalesPerson.FK_SalesPerson_SalesTerritory_TerritoryID
        /// <summary>
        /// Child Sales_SalesTerritoryHistories where [SalesTerritoryHistory].[TerritoryID] point to this entity (FK_SalesTerritoryHistory_SalesTerritory_TerritoryID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistories { get; set; } // SalesTerritoryHistory.FK_SalesTerritoryHistory_SalesTerritory_TerritoryID

        // Foreign keys

        /// <summary>
        /// Parent Person_CountryRegion pointed by [SalesTerritory].([CountryRegionCode]) (FK_SalesTerritory_CountryRegion_CountryRegionCode)
        /// </summary>
        [ForeignKey("CountryRegionCode"), Required] public virtual Person_CountryRegion Person_CountryRegion { get; set; } // FK_SalesTerritory_CountryRegion_CountryRegionCode

        public Sales_SalesTerritory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_Customers = new System.Collections.Generic.List<Sales_Customer>();
            Sales_SalesOrderHeaders = new System.Collections.Generic.List<Sales_SalesOrderHeader>();
            Sales_SalesPersons = new System.Collections.Generic.List<Sales_SalesPerson>();
            Sales_SalesTerritoryHistories = new System.Collections.Generic.List<Sales_SalesTerritoryHistory>();
            Person_StateProvinces = new System.Collections.Generic.List<Person_StateProvince>();
        }
    }

}
// </auto-generated>
