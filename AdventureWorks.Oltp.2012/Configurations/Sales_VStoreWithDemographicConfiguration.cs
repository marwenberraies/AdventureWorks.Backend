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

namespace Configurations
{
    using Entities;
    using Interfaces;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // vStoreWithDemographics
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Sales_VStoreWithDemographicConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sales_VStoreWithDemographic>
    {
        public Sales_VStoreWithDemographicConfiguration()
            : this("Sales")
        {
        }

        public Sales_VStoreWithDemographicConfiguration(string schema)
        {
            Property(x => x.AnnualSales).IsOptional().HasPrecision(19,4);
            Property(x => x.AnnualRevenue).IsOptional().HasPrecision(19,4);
            Property(x => x.BankName).IsOptional();
            Property(x => x.BusinessType).IsOptional();
            Property(x => x.YearOpened).IsOptional();
            Property(x => x.Specialty).IsOptional();
            Property(x => x.SquareFeet).IsOptional();
            Property(x => x.Brands).IsOptional();
            Property(x => x.Internet).IsOptional();
            Property(x => x.NumberEmployees).IsOptional();
        }
    }

}
// </auto-generated>
