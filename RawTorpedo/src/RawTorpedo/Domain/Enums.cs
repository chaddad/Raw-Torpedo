using System.ComponentModel.DataAnnotations;

namespace RawTorpedo.Domain
{
    public class Enums
    {
        public enum Playtime
        {
            [Display(Name = "Less than 15 minutes")]
            Quick,

            [Display(Name = "15 to 30 minutes")]
            Short,

            [Display(Name = "30 to 60 minutes")]
            Medium,

            [Display(Name = "1 to 2 hours")]
            Long,

            [Display(Name = "2 to 4 hours")]
            WickedLong,

            [Display(Name = "4 to 8 hours")]
            AllDamnDay,

            [Display(Name = "Over 8 hours")]
            SeriouslyTwoFuckingDays
        };
    }
}
