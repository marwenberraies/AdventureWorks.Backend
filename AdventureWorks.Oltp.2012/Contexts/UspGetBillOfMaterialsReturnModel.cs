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

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class UspGetBillOfMaterialsReturnModel
    {
        public System.Int32? ProductAssemblyID { get; set; }
        public System.Int32? ComponentID { get; set; }
        public System.String ComponentDesc { get; set; }
        public System.Decimal? TotalQuantity { get; set; }
        public System.Decimal? StandardCost { get; set; }
        public System.Decimal? ListPrice { get; set; }
        public System.Int16? BOMLevel { get; set; }
        public System.Int32? RecursionLevel { get; set; }
    }

}
// </auto-generated>
