using System.Collections.Generic;
using System.Data;
using burger_shack.Models;
using Dapper;
using static burger_shack.Models.Burger;

namespace burger_shack.Repositories
{
  public class BurgerRepository
  {

    private readonly IDbConnection _db;

    public BurgerRepository(IDbConnection db)
    {
      _db = db;
    }

    //CREATEONE
    public Burger Add(Burger burger)
    {
      int id = _db.ExecuteScalar<int>(@"
      INSERT INTO burgers (
          name,
  description,
  price,
  kcal
) VALUES (@Name, @Description, @Price, @Kcal)", burger);
      burger.Id = id;
      return burger;
    }
    //FINDONE FINDALL FINDMANY
    public Burger GetById(int id)
    {
      return _db.QueryFirstOrDefault<Burger>(@"
      SELECT * FROM burgers WHERE id = @id
      ", new {id});
    }
    public IEnumerable<Burger> GetBurgers()
    {
      return _db.Query<Burger>("SELECT * FROM burgers");
    }

    //EDITONE
    public Burger Update(Burger burger)
    {
      return _db.QuerySingleOrDefault<Burger>(@"
      UPDATE burgers SET
      name = @Name,
      description = @Description,
      price = @Price,
      kcal = @Kcal
      WHERE id = @id
      ", burger);
    }

    public IEnumerable<UserBurgerOrderReport> GetUserBurgerReport(string userId)
    {
      return _db.Query<UserBurgerOrderReport>(@"
        SELECT
          u.name username,
          u.email,
          ob.burgerId,
          ob.quantity,
          ob.orderId,
          b.name burger,
          b.kcal
        FROM orderburgers ob
        JOIN users u ON u.id = ob.userId
        JOIN burgers b ON b.id = ob.burgerId
        WHERE userId = @id;
      ", new { id = userId });
    }
    //DELETEONE
    public void Delete(Burger burger)
    {
      _db.QuerySingleOrDefault<Burger>(@"
      DELETE FROM burgers WHERE id = @id
      ", burger);
      System.Console.WriteLine("Burger Deleted");
    }

  }
}