using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.Models
{
    public class Governorate
    {
        public int GovernorateId{ get; set; }
       
        public string? GovernorateName { get; set; }
     
        [NotMapped]
        public int DohId { get; set; }
        [NotMapped]
        public int DistrictId { get; set; }
        [NotMapped]
        public int NahiaId { get; set; }

    }
}
