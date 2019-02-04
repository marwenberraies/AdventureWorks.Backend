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

namespace Contexts
{

    // CountryRegion
    ///<summary>
    /// Lookup table containing the ISO standard codes for countries and regions.
    ///</summary>
    [Table("CountryRegion", Schema = "Person")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Person_CountryRegion
    {

        ///<summary>
        /// ISO standard code for countries and regions.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CountryRegionCode", Order = 1, TypeName = "nvarchar")]
        [Index(@"PK_CountryRegion_CountryRegionCode", 1, IsUnique = true, IsClustered = true)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Key]
        [Display(Name = "Country region code")]
        public string CountryRegionCode { get; set; } // CountryRegionCode (Primary key) (length: 3)

        ///<summary>
        /// Country or region name.
        ///</summary>
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Index(@"AK_CountryRegion_Name", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 3, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Person_StateProvinces where [StateProvince].[CountryRegionCode] point to this entity (FK_StateProvince_CountryRegion_CountryRegionCode)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Person_StateProvince> Person_StateProvinces { get; set; } // StateProvince.FK_StateProvince_CountryRegion_CountryRegionCode
        /// <summary>
        /// Child Sales_CountryRegionCurrencies where [CountryRegionCurrency].[CountryRegionCode] point to this entity (FK_CountryRegionCurrency_CountryRegion_CountryRegionCode)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_CountryRegionCurrency> Sales_CountryRegionCurrencies { get; set; } // CountryRegionCurrency.FK_CountryRegionCurrency_CountryRegion_CountryRegionCode
        /// <summary>
        /// Child Sales_SalesTerritories where [SalesTerritory].[CountryRegionCode] point to this entity (FK_SalesTerritory_CountryRegion_CountryRegionCode)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Sales_SalesTerritory> Sales_SalesTerritories { get; set; } // SalesTerritory.FK_SalesTerritory_CountryRegion_CountryRegionCode

        public Person_CountryRegion()
        {
            ModifiedDate = System.DateTime.Now;
            Sales_CountryRegionCurrencies = new System.Collections.Generic.List<Sales_CountryRegionCurrency>();
            Sales_SalesTerritories = new System.Collections.Generic.List<Sales_SalesTerritory>();
            Person_StateProvinces = new System.Collections.Generic.List<Person_StateProvince>();
        }
    }

}
// </auto-generated>
