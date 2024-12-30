using Microsoft.AspNetCore.Mvc.Rendering;

namespace dashbord.Models.ViewModels;

public class DoctorViewModel
{
    public string SelectedDoctor { get; set; }
  public  List<SelectListItem> DoctorsListItems { get; set; }
    
    
}