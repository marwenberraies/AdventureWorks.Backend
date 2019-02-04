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

    // ContactType
    ///<summary>
    /// Lookup table containing the types of business entity contacts.
    ///</summary>
    [Table("ContactType", Schema = "Person")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Person_ContactType
    {

        ///<summary>
        /// Primary key for ContactType records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ContactTypeID", Order = 1, TypeName = "int")]
        [Index(@"PK_ContactType_ContactTypeID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Contact type ID")]
        public int ContactTypeId { get; set; } // ContactTypeID (Primary key)

        ///<summary>
        /// Contact type description.
        ///</summary>
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Index(@"AK_ContactType_Name", 1, IsUnique = true, IsClustered = false)]
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
        /// Child Person_BusinessEntityContacts where [BusinessEntityContact].[ContactTypeID] point to this entity (FK_BusinessEntityContact_ContactType_ContactTypeID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Person_BusinessEntityContact> Person_BusinessEntityContacts { get; set; } // BusinessEntityContact.FK_BusinessEntityContact_ContactType_ContactTypeID

        public Person_ContactType()
        {
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityContacts = new System.Collections.Generic.List<Person_BusinessEntityContact>();
        }
    }

}
// </auto-generated>
