
using CRVS.Core.Models.SharedCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static CRVS.Core.Models.SharedCode.CommonProp;

namespace CRVS.Core.Models
{
    public class BirthCertificate:CommonProp
    {
        
        public Guid BirthCertificateId { get; set; }
      //  //        [Required]
        [DisplayName("رقم الشهادة")]
        public string? CertificateNo { get; set; }
        public string? HelthID { get; set; }
       // //        [Required]
        [DisplayName("اسم المولود")]
        public string? ChildName { get; set; }
        [DisplayName("الجنس")]
       // //        [Required]
        public Genders? Gender { get; set; }
       
        [DisplayName("المحافظة")]
       // //        [Required]
        public int Governorate { get; set; }
        [DisplayName("دائرة الصحة")]
      //  //        [Required]
        public int DOH { get; set; }
        [DisplayName("القضاء")]
      //  //        [Required]
        public int District { get; set; }
        [DisplayName("الناحية")]
       // //        [Required]
        public int Nahia { get; set; }
        [DisplayName("القرية")]
        public string? Village { get; set; }
        [DisplayName("نوع الولادة")]
      //  //        [Required]
        public BirthTypes? BirthType { get; set; }
        
        [DisplayName("عدد المواليد")]
       // //        [Required]
        public NumberOfBirths? NumberOfBirth { get; set; }
       
      //  //        [Required]
        [DisplayName("الساعة")]
        public TimeSpan BHour { get; set; }
      //  //        [Required]
        [DisplayName("تاريخ الولادة")]
        public DateTime BOD { get; set; }
      //  //        [Required]
        [DisplayName("التاريخ كتابتاً")]
        public string? BODText { get; set; }
      //  //        [Required]
        [DisplayName("اسم الاب ")]
        public string? FatherFName { get; set; }
      //  //        [Required]
        [DisplayName("اسم الجد")]
        public string? FatherMName { get; set; }
     //   //        [Required]
        [DisplayName("اسم والد الجد")]
        public string? FatherLName { get; set; }
        public string? FatherFullName { get; set; }
   //   //        [Required]
        [DisplayName("تاريخ الولادة")]
        [DataType(DataType.Date)]
        public DateTime FatherBOD { get; set; }
        [DisplayName("العمر")]

        public int FatherAge { get; set; }
     //   //        [Required]
        [DisplayName("المهنة")]

        public int FatherJob { get; set; }

        [DisplayName("الجنسية")]
    //    //        [Required]
        public int FatherNationality { get; set; }
        [DisplayName("الديانة")]
    //    //        [Required]
        public int FatherReligion { get; set; }
        [DisplayName("رقم موبايل ")]
    //    //        [Required]
        public int FatherMobile { get; set; }
        [DisplayName("اسم الام")]
    //    //        [Required]
        public string? MotherFName { get; set; }
        [DisplayName("اسم والد الام")]
     //   //        [Required]
        public string? MotherMName { get; set; }
        [DisplayName("اسم جد الام")]
     //   //        [Required]
        public string? MotherLName { get; set; }
        public string? MotherFullName { get; set; }

        [DisplayName("تاريخ الولادة")]
        [DataType(DataType.Date)]
//        //        [Required]
        public DateTime MotherBOD { get; set; }
        [DisplayName("العمر")]

        public int MotherAge { get; set; }
        [DisplayName("المهنة")]
//        //        [Required]
        public int MotherJob { get; set; }
        [DisplayName(" الجنسية")]
//        //        [Required]
        public int MotherNationality { get; set; }
        [DisplayName("الديانة")]
//        //        [Required]
        public int MotherReligion { get; set; }
        [DisplayName("رقم موبايل ")]
        public int MotherMobile { get; set; }
        [DisplayName("هل هنالك صلة قرابة بين الام والاب؟")]
//        //        [Required]
        public bool Relative { get; set; }
        [DisplayName("الاحياء")]

        public int Alive { get; set; }
        [DisplayName("المواليد الاحياء ثم توفوا")]
        public int BornAliveThenDied { get; set; }
        [DisplayName("الذين ولدوا امواتاً")]
        public int StillBirth { get; set; }
        [DisplayName("الذين ولدوا معوقين")]
        public int BornDisable { get; set; }
        [DisplayName("عدد الاسقاطات")]
        public int NoAbortion { get; set; }
        [DisplayName("هل الولادة الحالية معوقة؟")]
        public bool IsDisabled { get; set; }
        [DisplayName("نوع العوق")]
        public string? IsDisabledType { get; set; }
        [DisplayName("مدة الحمل بالاسبوع")]
//        //        [Required]
        public int DurationOfPregnancy { get; set; }
        [DisplayName("وزن الطفل")]
//        //        [Required]
        public decimal BabyWeight { get; set; }
        [DisplayName("مكان الولادة")]
//        //        [Required]
        public PlaceOfBirths? PlaceOfBirth { get; set; }
       
        [DisplayName("حدثت الولادة بواسطة")]
//        //        [Required]
        public BirthOccurredBys BirthOccurredBy { get; set; }
        [DisplayName("رقم الاجازة")]
        public int LicenseNo { get; set; }
        [DisplayName("لسنة")]
        public string? LicenseYear { get; set;}
        [DisplayName("المحافظة")]
//        //        [Required]
        public string? FamilyGovernorate { get; set; }
        [DisplayName("القضاء")]
//        //        [Required]
        public string? FamilyDistrict { get; set; }
        [DisplayName("الناحية")]
//        //        [Required]
        public string? FamilyNahiah { get; set; }
        [DisplayName("المحلة او القرية")]
//        //        [Required]
        public string? FamilyMahala { get; set; }
//        [DisplayName("دائرة الصحة")]

        public string? FamilyDOH { get; set; }
        [DisplayName("القطاع")]
        public string? FamilySector { get; set; }
        [DisplayName("المركز الصحي")]
        public string? FamilyPHC { get; set; }
        [DisplayName("زقاق")]
        public string? FamilyZigag { get; set; }
        [DisplayName("رقم الدار")]
        public string? FamilyHomeNo { get; set; }
        [DisplayName("نوع الهوية")]
//        //        [Required]
        public DocumentTypes DocumentType { get; set; }
        [DisplayName("رقم السجل")]
        public string? RecordNumber { get; set; }
        [DisplayName("رقم الصفحة")]
        public string? PageNumber { get; set; }
        [DisplayName(" دائرة الاحوال")]
        public string? CivilStatusDirectorate { get; set; }
        [DisplayName("المحافظة")]
   
        public string? GovernorateCivilStatusDirectorate { get; set; }
        [DisplayName("رقم البطاقة للاب او الام")]
        public NationalIdFors NationalIdFor { get; set; }
        [DisplayName("رقم البطاقة الموحدة")]
        public int NationalID { get; set; }
        [DisplayName("رقم جواز السفر")]
        public string? PassportNo { get; set; }
        [DisplayName("اسم المخبر")]
//        //        [Required]
        public string? InformerName { get; set; }
        [DisplayName("عنوانه")]
//        //        [Required]
        public string? InformerJobTitle { get; set; }
        [DisplayName("صلته بالمولود")]
//        //        [Required]
        public string? KinshipOfTheNewborn { get; set; }
        [DisplayName("اسم المولد")]
        //        //        [Required]
        public string? BirthPerformerName { get; set; }
        [DisplayName("عنوانه")]
        //        [Required]
        public string? BirthPerformerWorkingAddress { get; set; }
        [DisplayName("اسم مدير المستشفى")]
        //        [Required]
        public string? HospitalManagerName { get; set; }
        [DisplayName("التوقيع")]
        public string? HospitalManagerSig { get; set; }
        [DisplayName("رقم البطاقة التموينية")]
        //        [Required]
        public int RationCard { get; set; }
        [DisplayName("نسخة الشهادة")]
        public string? ImgBirthCertificate { get; set; }
        [DisplayName("عقد الزواج")]
        public string? ImgMarriageCertificate { get; set; }
        [DisplayName("جنسية الاب/وجه")]
        //        [Required]
        public string? ImgFatherUnifiedNationalIdFront { get; set; }
        [DisplayName("جنسية الاب/ظهر")]
        //        [Required]
        public string? ImgFatherUnifiedNationalIdBack { get; set; }
        [DisplayName("جنسية الام/وجه")]
        //        [Required]
        public string? ImgMotherUnifiedNationalIdFront { get; set; }
        [DisplayName("جنسية الام/ظهر")]
        //        [Required]
        public string? ImgMotherUnifiedNationalIdBack { get; set; }
        [DisplayName("بطاقة السكن/وجه")]
        public string? ImgResidencyCardFront { get; set; }
        [DisplayName("بطاقة السكن/ظهر")]

        public string? ImgResidencyCardBack { get; set; }
        public string? AllPDFs { get; set; }
        public string? QrCode { get; set; }
        public bool FirstStage { get; set; }
        public bool SecondStage { get; set; }
        public bool Approval { get; set; }
        public bool Creator { get; set; }
    }
}
