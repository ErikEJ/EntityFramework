// <auto-generated />
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Cosmos.ValueGeneration.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Newtonsoft.Json.Linq;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class DependentDerivedEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentDerived<int>",
                typeof(CompiledModelTestBase.DependentDerived<int>),
                baseEntityType,
                discriminatorProperty: "$type",
                discriminatorValue: "DependentDerived",
                propertyCount: 5,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(CompiledModelTestBase.AbstractBase).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<int>).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);

            var type = runtimeEntityType.AddProperty(
                "$type",
                typeof(string),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                valueGeneratorFactory: new DiscriminatorValueGeneratorFactory().Create);

            var data = runtimeEntityType.AddProperty(
                "Data",
                typeof(string),
                propertyInfo: typeof(CompiledModelTestBase.DependentDerived<int>).GetProperty("Data", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentDerived<int>).GetField("<Data>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);

            var __id = runtimeEntityType.AddProperty(
                "__id",
                typeof(string),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                valueGeneratorFactory: new IdValueGeneratorFactory().Create);
            __id.AddAnnotation("Cosmos:PropertyName", "id");

            var __jObject = runtimeEntityType.AddProperty(
                "__jObject",
                typeof(JObject),
                nullable: true,
                valueGenerated: ValueGenerated.OnAddOrUpdate,
                beforeSaveBehavior: PropertySaveBehavior.Ignore,
                afterSaveBehavior: PropertySaveBehavior.Ignore);
            __jObject.AddAnnotation("Cosmos:PropertyName", "");

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}