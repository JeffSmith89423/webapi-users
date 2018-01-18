using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Keepr.Models;
using Keepr.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Keepr.Controllers
{
    [Route("api/[controller]")]
    public class VaultKeepController : Controller
    {
        private readonly VaultKeepRepository db;
        public VaultKeepController(VaultKeepRepository vaultKeepRepo)
        {
            db = vaultKeepRepo;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<VaultKeep> GetAll()
        {
            return db.GetAll();
        }

        // GET api/values/
        [HttpGet("{id}")]
        public VaultKeep Get(int id)
        {
            return db.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public VaultKeep Post([FromBody]VaultKeep vaultKeep)
        {
            return db.Add(vaultKeep);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public VaultKeep Put(int id, [FromBody]VaultKeep vaultKeep)
        {
            if (ModelState.IsValid)
            {
                return db.GetOneByIdAndUpdate(id, vaultKeep);
            }
            return null;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return db.FindByIdAndRemove(id);
        }
    }
}