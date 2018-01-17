using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Keepr.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace Keepr.Repositories
{
    public class KeepRepository
    {
        private readonly IDbConnection _db;

        public KeepRepository(IDbConnection db)
        {
            _db = db;
        }

        // Find One Find Many add update delete
        public IEnumerable<Keep> GetAll()
        {
            return _db.Query<Keep>("SELECT * FROM keeps");
        }

        public Keep GetById(int id)
        {
            return _db.QueryFirstOrDefault<Keep>($"SELECT * FROM Keeps WHERE id = @id", id);
        }

        public Keep Add(Keep keep)
        {

            int id = _db.ExecuteScalar<int>("INSERT INTO keeps (Imageurl, Name, Description, UserId, Saves, Viewed)" //change these 
                        + " VALUES(@Imageurl, @Name, @Description, @UserId, @Saves, @Viewed); SELECT LAST_INSERT_ID()", new
                        {
                            keep.Imageurl,
                            keep.Name,
                            keep.Description,
                            keep.UserId,
                            keep.Saves,
                            keep.Viewed
                        });
            keep.Id = id;
            return keep;

        }

        public Keep GetOneByIdAndUpdate(int id, Keep keep)
        {
            return _db.QueryFirstOrDefault<Keep>($@"
                UPDATE Keeps SET  
                    Name = @Name,
                    Description = @Description,
                    Price = @Price
                WHERE Id = {id};
                SELECT * FROM Keeps WHERE id = {id};", keep);
        }

        public string FindByIdAndRemove(int id)
        {
            var success = _db.Execute(@"
                DELETE FROM Keeps WHERE Id = @id
            ", id);
            return success > 0 ? "success" : "umm that didnt work";
        }
    }
}