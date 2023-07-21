using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CRVS.Core.Models.SharedCode
{
    public class CommonProp
    {
        #region AllProp
        public bool IsDeleted { get; set; }=false;
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }

        #endregion

        #region Enums
        public enum Genders{
            [Display(Name = "ذكر")]

            ذكر = 1,
            [Display(Name = "أنثى")]

            أثنى = 2,
                 [Display(Name = "خنثى")]

            خنثى = 3
        }
        public enum BirthTypes { طبيعية, قيصرية }
        public enum NumberOfBirths { مفردة, توأم, ثلاثية, اكثر }
        public enum PlaceOfBirths {
            [Display(Name = "بيت")]

            home = 1,
            [Display(Name = "مستشفى او مركز صحي")]

            HOSP = 2,
          
        }
        public enum BirthOccurredBys { طبيب, ممرضة_مجازة_بالتوليد,قابلة_مجازة,اخرى }
        public enum DocumentTypes {
            [Display(Name = "هوية_الاحوال المدنية")]

            هوية_الاحوال_المدنية = 1,
            [Display(Name = "البطاقة الموحدة")]

            البطاقة_الموحدة = 2,
            [Display(Name = "جواز سفر")]

            جواز_سفر = 3,

            [Display(Name = "رقم الاقامة")]

            رقم_الاقامة = 4

          }
        public enum NationalIdFors {
            [Display(Name = "الاب")]

            fa = 1,
            [Display(Name = "الام")]

            mo = 2
        }

        #endregion
    }
}
