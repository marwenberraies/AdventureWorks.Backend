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

    // Shift
    ///<summary>
    /// Work shift lookup table.
    ///</summary>
    [Table("Shift", Schema = "HumanResources")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class HumanResources_Shift
    {

        ///<summary>
        /// Primary key for Shift records.
        ///</summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ShiftID", Order = 1, TypeName = "tinyint")]
        [Index(@"PK_Shift_ShiftID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Shift ID")]
        public byte ShiftId { get; set; } // ShiftID (Primary key)

        ///<summary>
        /// Shift description.
        ///</summary>
        [Column(@"Name", Order = 2, TypeName = "nvarchar")]
        [Index(@"AK_Shift_Name", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } // Name (length: 50)

        ///<summary>
        /// Shift start time.
        ///</summary>
        [Column(@"StartTime", Order = 3, TypeName = "time")]
        [Index(@"AK_Shift_StartTime_EndTime", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Start time")]
        public System.TimeSpan StartTime { get; set; } // StartTime

        ///<summary>
        /// Shift end time.
        ///</summary>
        [Column(@"EndTime", Order = 4, TypeName = "time")]
        [Index(@"AK_Shift_StartTime_EndTime", 2, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "End time")]
        public System.TimeSpan EndTime { get; set; } // EndTime

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
        /// Child HumanResources_EmployeeDepartmentHistories where [EmployeeDepartmentHistory].[ShiftID] point to this entity (FK_EmployeeDepartmentHistory_Shift_ShiftID)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistories { get; set; } // EmployeeDepartmentHistory.FK_EmployeeDepartmentHistory_Shift_ShiftID

        public HumanResources_Shift()
        {
            ModifiedDate = System.DateTime.Now;
            HumanResources_EmployeeDepartmentHistories = new System.Collections.Generic.List<HumanResources_EmployeeDepartmentHistory>();
        }
    }

}
// </auto-generated>
