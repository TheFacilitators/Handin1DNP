using System.ComponentModel.DataAnnotations;

namespace Models {
public class Person {
    
    public int Id { get; set; }
    [Required, MinLength(2), MaxLength(100)]
    public string FirstName { get; set; }
    [Required, MinLength(1), MaxLength(100)]
    public string LastName { get; set; }
    // public string HairColor { get; set; }
    // public string EyeColor { get; set; }
    public int Age { get; set; }
    // public float Weight { get; set; }
    // public int Height { get; set; }
    // public string Sex { get; set; }
}


}