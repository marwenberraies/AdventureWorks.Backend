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

    // BusinessEntityContact
    ///<summary>
    /// Cross-reference table mapping stores, vendors, and employees to people
    ///</summary>
    [Table("BusinessEntityContact", Schema = "Person")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Person_BusinessEntityContact
    {

        ///<summary>
        /// Primary key. Foreign key to BusinessEntity.BusinessEntityID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"BusinessEntityID", Order = 1, TypeName = "int")]
        [Index(@"PK_BusinessEntityContact_BusinessEntityID_PersonID_ContactTypeID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Business entity ID")]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Primary key. Foreign key to Person.BusinessEntityID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"PersonID", Order = 2, TypeName = "int")]
        [Index(@"IX_BusinessEntityContact_PersonID", 1, IsUnique = false, IsClustered = false)]
        [Index(@"PK_BusinessEntityContact_BusinessEntityID_PersonID_ContactTypeID", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Person ID")]
        public int PersonId { get; set; } // PersonID (Primary key)

        ///<summary>
        /// Primary key.  Foreign key to ContactType.ContactTypeID.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ContactTypeID", Order = 3, TypeName = "int")]
        [Index(@"IX_BusinessEntityContact_ContactTypeID", 1, IsUnique = false, IsClustered = false)]
        [Index(@"PK_BusinessEntityContact_BusinessEntityID_PersonID_ContactTypeID", 3, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Contact type ID")]
        public int ContactTypeId { get; set; } // ContactTypeID (Primary key)

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        [Column(@"rowguid", Order = 4, TypeName = "uniqueidentifier")]
        [Index(@"AK_BusinessEntityContact_rowguid", 1, IsUnique = true, IsClustered = false)]
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

        // Foreign keys

        /// <summary>
        /// Parent Person_BusinessEntity pointed by [BusinessEntityContact].([BusinessEntityId]) (FK_BusinessEntityContact_BusinessEntity_BusinessEntityID)
        /// </summary>
        [ForeignKey("BusinessEntityId"), Required] public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } // FK_BusinessEntityContact_BusinessEntity_BusinessEntityID

        /// <summary>
        /// Parent Person_ContactType pointed by [BusinessEntityContact].([ContactTypeId]) (FK_BusinessEntityContact_ContactType_ContactTypeID)
        /// </summary>
        [ForeignKey("ContactTypeId"), Required] public virtual Person_ContactType Person_ContactType { get; set; } // FK_BusinessEntityContact_ContactType_ContactTypeID

        /// <summary>
        /// Parent Person_Person pointed by [BusinessEntityContact].([PersonId]) (FK_BusinessEntityContact_Person_PersonID)
        /// </summary>
        [ForeignKey("PersonId"), Required] public virtual Person_Person Person_Person { get; set; } // FK_BusinessEntityContact_Person_PersonID

        public Person_BusinessEntityContact()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
        }
    }

}
// </auto-generated>
