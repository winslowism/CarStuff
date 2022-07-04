using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarStuff.Models;

public class Car
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public Make Make { get; set; }
    public Model Model { get; set; }
    public Color Color { get; set; }
    public float RecommendedPrice { get; set; }
    public virtual List<ExtraItem> Extras { get; set; } = new();
}

public enum Make
{
    Kia,
    Nissan,
    Ford,
    Hyundai
}

public enum Model
{
    One,
    Two,
    Three,
    Four,
    Five
}

public enum Color
{
    Black,
    Pink,
    Yellow,
    Blue,
}

public enum Extra
{
    Fast,
    ReallyFast,
    Slow,
    Awesome,
    Loud
}