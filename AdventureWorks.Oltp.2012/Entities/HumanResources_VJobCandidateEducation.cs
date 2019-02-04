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

    // vJobCandidateEducation
    [Table("vJobCandidateEducation", Schema = "HumanResources")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class HumanResources_VJobCandidateEducation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"JobCandidateID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Job candidate ID")]
        public int JobCandidateId { get; set; } // JobCandidateID (Primary key)

        [Column(@"Edu.Level", Order = 2, TypeName = "nvarchar(max)")]
        [Display(Name = "Edu level")]
        public string Edu46Level { get; set; } // Edu.Level

        [Column(@"Edu.StartDate", Order = 3, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Edu start date")]
        public System.DateTime? Edu46StartDate { get; set; } // Edu.StartDate

        [Column(@"Edu.EndDate", Order = 4, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Edu end date")]
        public System.DateTime? Edu46EndDate { get; set; } // Edu.EndDate

        [Column(@"Edu.Degree", Order = 5, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Edu degree")]
        public string Edu46Degree { get; set; } // Edu.Degree (length: 50)

        [Column(@"Edu.Major", Order = 6, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Edu major")]
        public string Edu46Major { get; set; } // Edu.Major (length: 50)

        [Column(@"Edu.Minor", Order = 7, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Edu minor")]
        public string Edu46Minor { get; set; } // Edu.Minor (length: 50)

        [Column(@"Edu.GPA", Order = 8, TypeName = "nvarchar")]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Edu gpa")]
        public string Edu46Gpa { get; set; } // Edu.GPA (length: 5)

        [Column(@"Edu.GPAScale", Order = 9, TypeName = "nvarchar")]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Edu gpas cale")]
        public string Edu46GpaScale { get; set; } // Edu.GPAScale (length: 5)

        [Column(@"Edu.School", Order = 10, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Edu school")]
        public string Edu46School { get; set; } // Edu.School (length: 100)

        [Column(@"Edu.Loc.CountryRegion", Order = 11, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Edu loc country region")]
        public string Edu46Loc46CountryRegion { get; set; } // Edu.Loc.CountryRegion (length: 100)

        [Column(@"Edu.Loc.State", Order = 12, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Edu loc state")]
        public string Edu46Loc46State { get; set; } // Edu.Loc.State (length: 100)

        [Column(@"Edu.Loc.City", Order = 13, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Edu loc city")]
        public string Edu46Loc46City { get; set; } // Edu.Loc.City (length: 100)
    }

}
// </auto-generated>
