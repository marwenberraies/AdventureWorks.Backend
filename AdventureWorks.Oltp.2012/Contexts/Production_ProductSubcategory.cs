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

    // ProductSubcategory
    ///<summary>
    /// Product subcategories. See ProductCategory table.
    ///</summary>
    [Table("ProductSubcategory", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_ProductSubcategory
    {

        ///<summary>
        /// Primary key for ProductSubcategory records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ProductSubcategoryID", Order = 1, TypeName = "int")]
        [Index(@"PK_ProductSubcategory_ProductSubcategoryID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product subcategory ID")]
        public int ProductSubcategoryId { get; set; } // ProductSubcategoryID (Primary key)

        ///<summary>
        /// Product category identification number. Foreign key to ProductCategory.ProductCategoryID.
        ///</summary>
        [Column(@"ProductCategoryID", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Product category ID")]
        public int ProductCategoryId { get; set; } // ProductCategoryID

        ///<summary>
        /// Subcategory description.
        ///</summary>
        [Column(@"Name", Order = 3, TypeName = "nvarchar")]
        [Index(@"AK_ProductSubcategory_Name", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 4, TypeName = "uniqueidentifier")]
        [Index(@"AK_ProductSubcategory_rowguid", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 5, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation

        /// <summary>
        /// Child Production_Products where [Product].[ProductSubcategoryID] point to this entity (FK_Product_ProductSubcategory_ProductSubcategoryID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Production_Product> Production_Products { get; set; } // Product.FK_Product_ProductSubcategory_ProductSubcategoryID

        // Foreign keys

        /// <summary>
        /// Parent Production_ProductCategory pointed by [ProductSubcategory].([ProductCategoryId]) (FK_ProductSubcategory_ProductCategory_ProductCategoryID)
        /// </summary>
        [ForeignKey("ProductCategoryId"), Required] public virtual Production_ProductCategory Production_ProductCategory { get; set; } // FK_ProductSubcategory_ProductCategory_ProductCategoryID

        public Production_ProductSubcategory()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_Products = new System.Collections.Generic.List<Production_Product>();
        }
    }

}
// </auto-generated>
