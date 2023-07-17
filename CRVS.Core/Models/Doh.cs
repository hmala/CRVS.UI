using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.Models
{
    public class Doh
    {
        public int DohId { get; set; }    
       
        public string? DohName { get; set; }
        [ForeignKey("Governorate")]
        public int GovernorateId { get; set; }
        public Governorate? governorate { get; set; }


    }
}
