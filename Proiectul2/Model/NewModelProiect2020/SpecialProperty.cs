//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelProiect2020
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class SpecialProperty
    {
        [DataMember]
        public int DataID { get; set; }
        [DataMember]
        public int PropertyID { get; set; }
        [DataMember]
        public string PropertyName { get; set; }
        [DataMember]
        public string PropertyDescription { get; set; }

    }
}