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

    // vVendorWithContacts
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Purchasing_VVendorWithContactConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Purchasing_VVendorWithContact>
    {
        public Purchasing_VVendorWithContactConfiguration()
            : this("Purchasing")
        {
        }

        public Purchasing_VVendorWithContactConfiguration(string schema)
        {
            Property(x => x.Title).IsOptional();
            Property(x => x.MiddleName).IsOptional();
            Property(x => x.Suffix).IsOptional();
            Property(x => x.PhoneNumber).IsOptional();
            Property(x => x.PhoneNumberType).IsOptional();
            Property(x => x.EmailAddress).IsOptional();
        }
    }

}
// </auto-generated>
