using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace dashbord.Models
{
    public class Clinic
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        //[StringLength(50)]
        public string? nameClinic { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public int namberRoom { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string nurse { get; set; }


        public Doctor doctor { get; set; }
        public int doctorId { get; set; }
      


    } // ENd class ckinic

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
        [StringLength(10, MinimumLength = 10)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public int idNumber { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [StringLength(10, MinimumLength = 10)]
        public int phone { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string docSpecialization { get; set; }




    }

}