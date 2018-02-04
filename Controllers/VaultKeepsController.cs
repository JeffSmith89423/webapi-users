using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Keepr.Models;
using Keepr.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Keepr.Controllers
{
    [Route("api/[controller]")]
    public class VaultKeepsController : Controller
    {
        private readonly VaultKeepRepository db;
        public VaultKeepsController(VaultKeepRepository vaultKeepRepo)
        {
            db = vaultKeepRepo;
        }

        // GET api/values
        [HttpGet("{id}")]
        public IEnumerable<Keep> GetAllByVaultId(int id)
        {
            return db.GetAll(id);
        }

        // GET api/values/
        // [HttpGet("{id}")]
        // public VaultKeep Get(int id)
        // {
        //     return db.GetById(id);
        // }

        // POST api/values
        [Authorize]
        [HttpPost]
        public VaultKeep Post([FromBody]VaultKeep vaultkeep)
        {
            var user = HttpContext.User.Identity.Name; 
            int Id;
            int.TryParse( user, out Id);
            vaultkeep.UserId = Id;
            return db.Add(vaultkeep);
        }

        // PUT api/values/5
        // [HttpPut("{id}")]
        // public VaultKeep Put(int id, [FromBody]VaultKeep vaultkeep)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         return db.GetOneByIdAndUpdate(id, vaultkeep);
        //     }
        //     return null;
        // }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return db.FindByIdAndRemove(id);
        }
    }
}