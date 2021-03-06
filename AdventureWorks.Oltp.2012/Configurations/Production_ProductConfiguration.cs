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

    // Product
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_ProductConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_Product>
    {
        public Production_ProductConfiguration()
            : this("Production")
        {
        }

        public Production_ProductConfiguration(string schema)
        {
            Property(x => x.Color).IsOptional();
            Property(x => x.StandardCost).HasPrecision(19,4);
            Property(x => x.ListPrice).HasPrecision(19,4);
            Property(x => x.Size).IsOptional();
            Property(x => x.SizeUnitMeasureCode).IsOptional().IsFixedLength();
            Property(x => x.WeightUnitMeasureCode).IsOptional().IsFixedLength();
            Property(x => x.Weight).IsOptional().HasPrecision(8,2);
            Property(x => x.ProductLine).IsOptional().IsFixedLength();
            Property(x => x.Class).IsOptional().IsFixedLength();
            Property(x => x.Style).IsOptional().IsFixedLength();
            Property(x => x.ProductSubcategoryId).IsOptional();
            Property(x => x.ProductModelId).IsOptional();
            Property(x => x.SellEndDate).IsOptional();
            Property(x => x.DiscontinuedDate).IsOptional();

        }
    }

}
// </auto-generated>
