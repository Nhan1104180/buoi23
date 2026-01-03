using System.ComponentModel.DataAnnotations;

public class Register
{
    [Required (ErrorMessage = "Full name must be least 3 character long.")]
    [MinLength (3,ErrorMessage ="Full name must be least 3 character long.")]
    public  string fullname {get;set;}    

    [Required (ErrorMessage = "Please enter a vaild email address")]
    [EmailAddress (ErrorMessage ="Please enter a vaild email address")]
    public  string email {get;set;}

    [Required (ErrorMessage = "Phone number must be 10-12 digits")]
    [Phone]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be 10-12 digits")]
    public string PhoneNumber {get;set;}
    

    [MinLength (5,ErrorMessage ="address must be least 5 character long")]
    public  string address {get;set;}

    [Required (ErrorMessage = "address must be least 10 character long")]
    [MinLength (10,ErrorMessage ="address must be least 10 character long")]
    public  string message {get;set;}

    [Required(ErrorMessage = "Please select a service")]
    public  string SelectService {get;set;} = "";

    [Range(typeof(bool), "true", "true",ErrorMessage = "Your must agree before submitting")]
    public  bool dongY {get;set;}

}