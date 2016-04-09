using System.ComponentModel.DataAnnotations;

namespace RawTorpedo.Models.Support
{
    public class Publisher
    {
        public int ID { get; set; }

        /// <summary>
        /// Publisher's Name
        /// </summary>
        [Display(Name = "Publisher's Name")]
        public string Name { get; set; }
    }
}
