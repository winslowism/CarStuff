namespace CarStuff.Models
{
    public class ExtraItem
    {
        public int Id { get; set; }
        public Extra Name { get; set; }
        
        public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
