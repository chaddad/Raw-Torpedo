using System.ComponentModel.DataAnnotations;

namespace RawTorpedo.Models.Support
{
    public class Designer
    {
        public int ID { get; set; }

        /// <summary>
        /// Designer's name
        /// </summary>
        [Display(Name = "Designer's Name")]
        public string Name { get; set; }
    }
}
