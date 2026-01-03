using System.ComponentModel.DataAnnotations;

public class Register
{
    [Required (ErrorMessage ="Full name must be least 3 character long.")]
    [MinLength (3,ErrorMessage ="Full name must be least 3 character long.")]
    public string fullname{get;set;}

    [Required (ErrorMessage = "Please enter a vaild email address")]
    [EmailAddress (ErrorMessage ="Please enter a vaild email address")]
    public string email {get;set;}

    [Required (ErrorMessage = "Phone number must be 10-12 digits")]
    [Phone]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits")]
    public string phonenumber {get;set;}

    [Required (ErrorMessage = "Please select a course")]
    public string SelectCourse {get;set;} = "";

    public string study {get;set;} = "online";

    [Required (ErrorMessage ="Please select a start date")]
    public string SelectedDate { get; set; }

    public string comments{get;set;}

    [Range(typeof(bool), "true", "true",ErrorMessage = "Your must agree before submitting")]
    public  bool dongY {get;set;}

}