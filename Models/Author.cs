using System.ComponentModel.DataAnnotations;

namespace Ciurca_Radu_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

 //       [Display(Name ="Author Name")]
  //      public string FullName => $"{FirstName} {LastName}";

        public ICollection<Book>? Books { get; set; }

    }
}
