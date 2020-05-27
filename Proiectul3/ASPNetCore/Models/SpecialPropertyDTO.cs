using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ASPNetCore.Models
{
    public class SpecialPropertyDTO
    {
        [Key]
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
