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

    // vStateProvinceCountryRegion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Person_VStateProvinceCountryRegionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Person_VStateProvinceCountryRegion>
    {
        public Person_VStateProvinceCountryRegionConfiguration()
            : this("Person")
        {
        }

        public Person_VStateProvinceCountryRegionConfiguration(string schema)
        {
            Property(x => x.StateProvinceCode).IsFixedLength();
        }
    }

}
// </auto-generated>
