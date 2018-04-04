using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace burger_shack.Models
{
  public class User
  {
    [Key]
    [Required]
    public string Id { get; set; }
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
  }


  public class UserCreateModel
  {
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
  }
  public class UserReturnModel
  {
    [Required]
    public string Id { get; set; }
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    public ClaimsPrincipal SetClaims()
    {
      var claims = new List<Claim>{
        new Claim(ClaimTypes.Email, Email),
        new Claim(ClaimTypes.Name, Id)
      };
      var userIdentity = new ClaimsIdentity(claims, "login");
      var principal = new ClaimsPrincipal(userIdentity);
      return principal;
    }

  }

  public class UserLoginModel
  {
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
  }
  public class UserPublicModel
  {
    public string Name { get; set; }

  }

}