﻿//
// Built using quicktype
// https://app.quicktype.io/#l=cs&r=json2csharp
//
namespace EntityGraphQL.Schema.Models
{
    public partial class Schema
    {
        public QueryType QueryType { get; set; }

        public MutationType MutationType { get; set; }

        public SubscriptionType SubscriptionType { get; set; }

        public TypeElement[] Types { get; set; }

        public Directives[] Directives { get; set; }
    }

    public partial class QueryType
    {
        public string Name { get; set; }
    }

    public partial class MutationType
    {
        public string Name { get; set; }
    }

    public partial class SubscriptionType
    {
        public string Name { get; set; }
    }

    public partial class TypeElement
    {
        public string Kind { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Field[] Fields { get; set; }

        public object InputFields { get; set; }

        public object[] Interfaces { get; set; }

        public EnumValue[] EnumValues { get; set; }

        public object PossibleTypes { get; set; }
        public TypeElement OfType { get; set; }
    }

    public partial class Field
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Arg[] Args { get; set; }

        public TypeElement Type { get; set; }

        public bool IsDeprecated { get; set; }

        public object DeprecationReason { get; set; }
    }

    public partial class Arg
    {
        public string Name { get; set; }

        public object Description { get; set; }

        public TypeElement Type { get; set; }

        public object DefaultValue { get; set; }
    }

    public partial class Directives
    {
        public string Name { get; set; }

        public object Description { get; set; }

        public string[] Locations { get; set; }

        public Arg[] Args { get; set; }
    }

    public partial class EnumValue
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsDeprecated { get; set; }

        public object DeprecationReason { get; set; }
    }
}