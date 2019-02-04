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

    // vAdditionalContactInfo
    [Table("vAdditionalContactInfo", Schema = "Person")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Person_VAdditionalContactInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"BusinessEntityID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Business entity ID")]
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"FirstName", Order = 2, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "First name")]
        public string FirstName { get; set; } // FirstName (Primary key) (length: 50)

        [Column(@"MiddleName", Order = 3, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Middle name")]
        public string MiddleName { get; set; } // MiddleName (length: 50)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"LastName", Order = 4, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Last name")]
        public string LastName { get; set; } // LastName (Primary key) (length: 50)

        [Column(@"TelephoneNumber", Order = 5, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Phone]
        [Display(Name = "Telephone number")]
        public string TelephoneNumber { get; set; } // TelephoneNumber (length: 50)

        [Column(@"TelephoneSpecialInstructions", Order = 6, TypeName = "nvarchar(max)")]
        [Display(Name = "Telephone special instructions")]
        public string TelephoneSpecialInstructions { get; set; } // TelephoneSpecialInstructions

        [Column(@"Street", Order = 7, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Street")]
        public string Street { get; set; } // Street (length: 50)

        [Column(@"City", Order = 8, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "City")]
        public string City { get; set; } // City (length: 50)

        [Column(@"StateProvince", Order = 9, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "State province")]
        public string StateProvince { get; set; } // StateProvince (length: 50)

        [Column(@"PostalCode", Order = 10, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; } // PostalCode (length: 50)

        [Column(@"CountryRegion", Order = 11, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Country region")]
        public string CountryRegion { get; set; } // CountryRegion (length: 50)

        [Column(@"HomeAddressSpecialInstructions", Order = 12, TypeName = "nvarchar(max)")]
        [Display(Name = "Home address special instructions")]
        public string HomeAddressSpecialInstructions { get; set; } // HomeAddressSpecialInstructions

        [Column(@"EMailAddress", Order = 13, TypeName = "nvarchar")]
        [MaxLength(128)]
        [StringLength(128)]
        [EmailAddress]
        [Display(Name = "Em ail address")]
        public string EMailAddress { get; set; } // EMailAddress (length: 128)

        [Column(@"EMailSpecialInstructions", Order = 14, TypeName = "nvarchar(max)")]
        [Display(Name = "Em ail special instructions")]
        public string EMailSpecialInstructions { get; set; } // EMailSpecialInstructions

        [Column(@"EMailTelephoneNumber", Order = 15, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Em ail telephone number")]
        public string EMailTelephoneNumber { get; set; } // EMailTelephoneNumber (length: 50)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"rowguid", Order = 16, TypeName = "uniqueidentifier")]
        [Required]
        [Key]
        [Display(Name = "Rowguid")]
        public System.Guid Rowguid { get; set; } // rowguid (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ModifiedDate", Order = 17, TypeName = "datetime")]
        [Required]
        [Key]
        [DataType(DataType.DateTime)]
        [Display(Name = "Modified date")]
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate (Primary key)
    }

}
// </auto-generated>
