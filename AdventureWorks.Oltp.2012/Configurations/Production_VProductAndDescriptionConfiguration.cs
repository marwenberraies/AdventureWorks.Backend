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

    // vProductAndDescription
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Production_VProductAndDescriptionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Production_VProductAndDescription>
    {
        public Production_VProductAndDescriptionConfiguration()
            : this("Production")
        {
        }

        public Production_VProductAndDescriptionConfiguration(string schema)
        {
            Property(x => x.CultureId).IsFixedLength();
        }
    }

}
// </auto-generated>
