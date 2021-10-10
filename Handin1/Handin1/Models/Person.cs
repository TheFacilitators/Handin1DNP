using System.ComponentModel.DataAnnotations;

namespace Models {
public class Person {
    
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
}


}