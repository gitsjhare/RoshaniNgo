using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Roshani.data.model;
using Roshani.data.Contract;
using Roshani.Provider.Contract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        IUserDetailProvider userDetailProvider;
        public ValuesController(IUserDetailProvider _detailProvider){
          userDetailProvider=_detailProvider;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            //throw new Exception();
            return userDetailProvider.GetUserDetails();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public UserModel Get(int id)
        {
            return userDetailProvider.GetUserDetails().Where(x=>x.idRos_User==id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
    public class NewDemocls{
        
    }
}
