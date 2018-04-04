using System;
using System.Collections.Generic;
using System.Data;
using burger_shack.Models;
using Dapper;

namespace burger_shack.Repositories
{
  public class UserRepository
  {
    private readonly IDbConnection _db;

    public UserRepository(IDbConnection db)
    {
      _db = db;
    }

    public UserReturnModel Register(UserCreateModel userData)
    {
      Guid g;
      g = Guid.NewGuid();
      string id = g.ToString();
      User user = new User()
      {
        Id = id,
        Name = userData.Name,
        Email = userData.Email,
        Password = BCrypt.Net.BCrypt.HashPassword(userData.Password)
      };
      int success = _db.Execute(@"
      INSERT INTO users (
          id,
          name,
          email,
          password
              ) 
          VALUES (@Id, @Name, @Email, @Password)", user);
      if (success < 1)
      {
        throw new Exception("Email already in use");
      }
      return new UserReturnModel()
      {
        Id = user.Id,
        Name = user.Name,
        Email = user.Email
      };
    }

    public UserReturnModel Login(UserLoginModel userData)
    {
      User user = _db.QueryFirstOrDefault<User>(@"
      SELECT * FROM users WHERE email = @Email
      ", userData);

      Boolean valid = BCrypt.Net.BCrypt.Verify(userData.Password, user.Password);
      if (valid)
      {
        return new UserReturnModel()
        {
          Id = user.Id,
          Name = user.Name,
          Email = user.Email
        };
      }
      throw new Exception("Invalid Credentials");
    }

    public UserReturnModel GetUserById(string id)
    {
      User user = _db.QueryFirstOrDefault<User>(@"
      SELECT * FROM users WHERE id = @Id
      ", new { Id = id });

      if (user == null) { throw new Exception("Oh Boy, something very bad happened. Hacking in session"); }
      return new UserReturnModel()
      {
        Id = user.Id,
        Name = user.Name,
        Email = user.Email
      };
    }

    public UserReturnModel UpdateAccount(UserReturnModel user, UserReturnModel userData)
    {
      var i = _db.Execute(@"
      UPDATE users SET
      email = @Email
      name = @Name
      WHERE id = @Id
      ", userData);
      if (i > 0)
      {
        return user;
      }
      return null;

    }
    // public string ChangeUserPassword(ChangeUserPasswordModel user)
    // {
    //   user savedUser = _db.QueryFirstOrDefault<User>(@"
    //   SELECT * FROM users WHERE id = @Id
    //   ", user);
    // }
  }
}