using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ASPNetCore.Models
{
    public class DataDTO
    {
        [Key]
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
