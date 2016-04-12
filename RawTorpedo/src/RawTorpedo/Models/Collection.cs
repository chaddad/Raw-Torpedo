namespace RawTorpedo.Models
{
    public class Collection
    {
        public int ID { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Game Game { get; set; }
        public Domain.Enums.CollectionType CollectionType { get; set; }
    }
}
