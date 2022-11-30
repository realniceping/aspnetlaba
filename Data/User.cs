using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace aspnetlab;

public class User {

    [Key]
    public int Id {get;set;}

    [MaxLength(50)]
    public string Email {get;set;} =  string.Empty;
}