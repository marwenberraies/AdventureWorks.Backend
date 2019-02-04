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

    // ShipMethod
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Purchasing_ShipMethodConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Purchasing_ShipMethod>
    {
        public Purchasing_ShipMethodConfiguration()
            : this("Purchasing")
        {
        }

        public Purchasing_ShipMethodConfiguration(string schema)
        {
            Property(x => x.ShipBase).HasPrecision(19,4);
            Property(x => x.ShipRate).HasPrecision(19,4);
        }
    }

}
// </auto-generated>
