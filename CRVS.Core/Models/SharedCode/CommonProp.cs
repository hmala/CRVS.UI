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
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }

        #endregion

        #region Enums
        public enum Genders{ ذكر, أنثى, خنثى }
        public enum BirthTypes { طبيعية, قيصرية }
        public enum NumberOfBirths { مفردة, توأم, ثلاثية, اكثر }
        public enum PlaceOfBirths { بيت, مستشفى_او_مركزصحي }
        public enum BirthOccurredBys { طبيب, ممرضة_مجازة_بالتوليد,قابلة_مجازة,اخرى }
        public enum DocumentTypes { هوية_الاحوال_المدنية,البطاقة_الموحدة,جواز_سفر,رقم_الاقامة}
        public enum NationalIdFors {
            [Display(Name = "الاب")]

            fa = 1,
            [Display(Name = "الام")]

            mo = 2
        }

        #endregion
    }
}
