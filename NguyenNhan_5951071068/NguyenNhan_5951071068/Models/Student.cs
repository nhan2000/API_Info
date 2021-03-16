using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NguyenNhan_5951071068.Models
{
    public class Student
    {
        [DataMember(Name = "idStudent")]
        public String idStudent { get; set; }

        [DataMember(Name = "NameStudent")]
        public String NameStudent { get; set; }

        [DataMember(Name = "AddressStudent")]
        public String AddressStudent { get; set; }

        [DataMember(Name ="Email")]
        public String Email { get; set; }
    }
}