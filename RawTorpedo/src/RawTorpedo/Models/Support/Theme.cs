using System.ComponentModel.DataAnnotations;

namespace RawTorpedo.Models.Support
{
    public class Theme
    {
        public int ID { get; set; }

        /// <summary>
        /// Theme's Name
        /// </summary>
        [Display(Name= "Theme's Name")]
        public string Name { get; set; }
    }
}
