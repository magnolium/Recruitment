using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CBRETest.Controllers
{
    [Route("api/[controller]")]
    public class GetAddressBook : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<AddressDetails> Addressbook()
        {
            return new List<AddressDetails>();
        }

        public class AddressDetails
        {
            public string Name { get; set; }
            public int Sex { get; set; }
            public DateTime Dob { get; set; }

            public AddressDetails()
            {

            }
        }
    }
}
