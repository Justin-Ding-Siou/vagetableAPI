using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vagetableAPI.Models;

namespace vagetableAPI.Controllers
{
    public class RecipeController : ApiController
    {
        dbVagetableBasketEntities db = new dbVagetableBasketEntities();
        // GET: api/Recipe
        public List<Recipe> Get()
        {
            var customers = db.Recipe;
            return customers.ToList();
        }

        // GET: api/Recipe/5
        public Recipe Get(int recipe_id)
        {
            var customer = db.Recipe
                .Where(m => m.recipe_id == recipe_id).FirstOrDefault();
            return customer;
        }

        // POST: api/Recipe
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Recipe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Recipe/5
        public void Delete(int id)
        {
        }
    }
}
