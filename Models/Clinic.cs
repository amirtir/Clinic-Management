using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Microsoft.Build.Framework;
namespace dashbord.Models;

public class Clinic
{


    [Key] public int ClinicId { get; set; }

    [System.ComponentModel.DataAnnotations.Required]
    [MaxLength(50)]
    [MinLength(2)]
    //[StringLength(50)]
    public string? nameClinic { get; set; }

    [System.ComponentModel.DataAnnotations.Required]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public int namberRoom { get; set; }

    [System.ComponentModel.DataAnnotations.Required]
    [StringLength(50, MinimumLength = 2)]
    public string nurse { get; set; }

    public Doctor? doctor { get; set; }
    public int? doctorId { get; set; }
}
      


   