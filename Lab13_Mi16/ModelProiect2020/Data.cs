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
    public partial class Data
    {
        [DataMember]
        public int DataID { get; set; }
        [DataMember]
        public string DateType { get; set; }
        [DataMember]
        public System.DateTime CreationDate { get; set; }
        [DataMember]
        public string EventName { get; set; }
        [DataMember]
        public string People { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public bool MovedData { get; set; }
        [DataMember]
        public bool FavoriteData { get; set; }

    }
}
