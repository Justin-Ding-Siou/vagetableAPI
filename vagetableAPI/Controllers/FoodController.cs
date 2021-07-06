using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vagetableAPI.Models;
namespace vagetableAPI.Controllers
{
    public class FoodController : ApiController
    {
        // GET: api/Food
        dbVagetableBasketEntities db = new dbVagetableBasketEntities();
        // GET: api/Food
        public List<Food> Get()
        {
            var foods = db.Food;
            return foods.ToList();
        }

        // GET: api/Food/5
        public Food Get(int fridge_id)
        {
            var foods = db.Food
                .Where(m => m.fridge_id == fridge_id).FirstOrDefault();
            return foods;
        }

        // POST: api/Food
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Food/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Food/5
        public void Delete(int id)
        {
        }
    }
}
