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

    // ProductInventory
    ///<summary>
    /// Product inventory information.
    ///</summary>
    [Table("ProductInventory", Schema = "Production")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_ProductInventory
    {

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ProductID", Order = 1, TypeName = "int")]
        [Index(@"PK_ProductInventory_ProductID_LocationID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Product ID")]
        public int ProductId { get; set; } // ProductID (Primary key)

        ///<summary>
        /// Inventory location identification number. Foreign key to Location.LocationID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"LocationID", Order = 2, TypeName = "smallint")]
        [Index(@"PK_ProductInventory_ProductID_LocationID", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Location ID")]
        public short LocationId { get; set; } // LocationID (Primary key)

        ///<summary>
        /// Storage compartment within an inventory location.
        ///</summary>
        [Column(@"Shelf", Order = 3, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Shelf")]
        public string Shelf { get; set; } // Shelf (length: 10)

        ///<summary>
        /// Storage container on a shelf in an inventory location.
        ///</summary>
        [Column(@"Bin", Order = 4, TypeName = "tinyint")]
        [Required]
        [Display(Name = "Bin")]
        public byte Bin { get; set; } // Bin

        ///<summary>
        /// Quantity of products in the inventory location.
        ///</summary>
        [Column(@"Quantity", Order = 5, TypeName = "smallint")]
        [Required]
        [Display(Name = "Quantity")]
        public short Quantity { get; set; } // Quantity

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 6, TypeName = "uniqueidentifier")]
        [Required]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 7, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Production_Location pointed by [ProductInventory].([LocationId]) (FK_ProductInventory_Location_LocationID)
        /// </summary>
        [ForeignKey("LocationId"), Required] public virtual Production_Location Production_Location { get; set; } // FK_ProductInventory_Location_LocationID

        /// <summary>
        /// Parent Production_Product pointed by [ProductInventory].([ProductId]) (FK_ProductInventory_Product_ProductID)
        /// </summary>
        [ForeignKey("ProductId"), Required] public virtual Production_Product Production_Product { get; set; } // FK_ProductInventory_Product_ProductID

        public Production_ProductInventory()
        {
            Quantity = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
