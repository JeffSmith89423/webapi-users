using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Keepr.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace Keepr.Repositories
{
    public class VaultKeepRepository
    {
        private readonly IDbConnection _db;

        public VaultKeepRepository(IDbConnection db)
        {
            _db = db;
        }

        // Find One Find Many add update delete
        public IEnumerable<Keep> GetAll(int id)
        {
            return _db.Query<Keep>($@"SELECT * FROM vaultkeeps vk
                                                    INNER JOIN keeps k ON k.id = vk.keepId
                                                    WHERE (vaultID = {id}", id);
        }

        // public VaultKeep GetById(int id)
        // {
        //     return _db.QueryFirstOrDefault<VaultKeep>($"SELECT * FROM vaultkeeps WHERE id = @id", id);
        // }

        public VaultKeep Add(VaultKeep vaultkeep)
        {

            int id = _db.ExecuteScalar<int>("INSERT INTO vaultkeeps (VaultId, KeepId, UserId)" 
                        + " VALUES(@VaultId, @KeepId, @UserId); SELECT LAST_INSERT_ID()", new
                        {
                            vaultkeep.VaultId,
                            vaultkeep.KeepId,
                            vaultkeep.UserId                            
                        });
            vaultkeep.Id = id;
            return vaultkeep;

        }

        public VaultKeep GetOneByIdAndUpdate(int id, VaultKeep vaultKeep)
        {
            return _db.QueryFirstOrDefault<VaultKeep>($@"
                UPDATE VaultKeeps SET  
                    VaultId = @VaultId,
                    KeepId = @Description,
                    UserId  = @UserId 
                WHERE Id = {id};
                SELECT * FROM VaultKeeps WHERE id = {id};", vaultKeep);
        }

        public string FindByIdAndRemove(int id)
        {
            var success = _db.Execute(@"
                DELETE FROM VaultKeeps WHERE Id = @id
            ", id);
            return success > 0 ? "success" : "umm that didnt work";
        }
    }
}