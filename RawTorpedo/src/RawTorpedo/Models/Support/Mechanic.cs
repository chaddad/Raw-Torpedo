using System.ComponentModel.DataAnnotations;

namespace RawTorpedo.Models.Support
{
    public class Mechanic
    {
        public int ID { get; set; }

        /// <summary>
        /// Mechanic's Name
        /// </summary>
        [Display(Name = "Mechanic's Name")]
        public string Name { get; set; }
    }
}
