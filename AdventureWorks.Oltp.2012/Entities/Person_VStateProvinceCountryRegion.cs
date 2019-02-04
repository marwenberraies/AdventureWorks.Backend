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

    // vStateProvinceCountryRegion
    [Table("vStateProvinceCountryRegion", Schema = "Person")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Person_VStateProvinceCountryRegion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"StateProvinceID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "State province ID")]
        public int StateProvinceId { get; set; } // StateProvinceID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"StateProvinceCode", Order = 2, TypeName = "nchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Key]
        [Display(Name = "State province code")]
        public string StateProvinceCode { get; set; } // StateProvinceCode (Primary key) (length: 3)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"IsOnlyStateProvinceFlag", Order = 3, TypeName = "bit")]
        [Required]
        [Key]
        [Display(Name = "Is only state province flag")]
        public bool IsOnlyStateProvinceFlag { get; set; } // IsOnlyStateProvinceFlag (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"StateProvinceName", Order = 4, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "State province name")]
        public string StateProvinceName { get; set; } // StateProvinceName (Primary key) (length: 50)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"TerritoryID", Order = 5, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Territory ID")]
        public int TerritoryId { get; set; } // TerritoryID (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CountryRegionCode", Order = 6, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Key]
        [Display(Name = "Country region code")]
        public string CountryRegionCode { get; set; } // CountryRegionCode (Primary key) (length: 3)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CountryRegionName", Order = 7, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "Country region name")]
        public string CountryRegionName { get; set; } // CountryRegionName (Primary key) (length: 50)
    }

}
// </auto-generated>
