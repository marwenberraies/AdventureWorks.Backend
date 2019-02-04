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

    // SalesOrderHeaderSalesReason
    ///<summary>
    /// Cross-reference table mapping sales orders to sales reason codes.
    ///</summary>
    [Table("SalesOrderHeaderSalesReason", Schema = "Sales")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Sales_SalesOrderHeaderSalesReason
    {

        ///<summary>
        /// Primary key. Foreign key to SalesOrderHeader.SalesOrderID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"SalesOrderID", Order = 1, TypeName = "int")]
        [Index(@"PK_SalesOrderHeaderSalesReason_SalesOrderID_SalesReasonID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Sales order ID")]
        public int SalesOrderId { get; set; } // SalesOrderID (Primary key)

        ///<summary>
        /// Primary key. Foreign key to SalesReason.SalesReasonID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"SalesReasonID", Order = 2, TypeName = "int")]
        [Index(@"PK_SalesOrderHeaderSalesReason_SalesOrderID_SalesReasonID", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Sales reason ID")]
        public int SalesReasonId { get; set; } // SalesReasonID (Primary key)

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        [Column(@"ModifiedDate", Order = 3, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys

        /// <summary>
        /// Parent Sales_SalesOrderHeader pointed by [SalesOrderHeaderSalesReason].([SalesOrderId]) (FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID)
        /// </summary>
        [ForeignKey("SalesOrderId"), Required] public virtual Sales_SalesOrderHeader Sales_SalesOrderHeader { get; set; } // FK_SalesOrderHeaderSalesReason_SalesOrderHeader_SalesOrderID

        /// <summary>
        /// Parent Sales_SalesReason pointed by [SalesOrderHeaderSalesReason].([SalesReasonId]) (FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID)
        /// </summary>
        [ForeignKey("SalesReasonId"), Required] public virtual Sales_SalesReason Sales_SalesReason { get; set; } // FK_SalesOrderHeaderSalesReason_SalesReason_SalesReasonID

        public Sales_SalesOrderHeaderSalesReason()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
