using System.ComponentModel.DataAnnotations;

namespace Auth_Web.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
