using System.ComponentModel.DataAnnotations.Schema;

namespace dashbord.Models;
using System.ComponentModel.DataAnnotations;
public class Doctor
{
    
    

        [Key]
        public int doctorId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

    

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
      
        public string idNumber { get; set; }

        [Required]
        
        [StringLength(11, MinimumLength = 11)]
        public string phone { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string docSpecialization { get; set; }

      


    
    
    
    
}