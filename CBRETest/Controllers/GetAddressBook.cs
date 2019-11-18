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
            AddressBook abook = new AddressBook();
            return abook.AddAddressFile("data/AddressBook");
        }

        public class AddressBook
        {
            private List<AddressDetails> arrAddress = new List<AddressDetails>();

            public IEnumerable<AddressDetails> AddAddressFile(string filename)
            {
                AddressBook ab = new AddressBook();

                var lines = System.IO.File.ReadAllLines(filename);
                var coll = lines.Select(a => a.Split(','));

                foreach(string[] arr in coll)
                {
                    AddressDetails ad = new AddressDetails { Name = arr[0], Sex = arr[1], Dob = DateTime.Parse(arr[2]) };
                    arrAddress.Add(ad);
                }

                return arrAddress;
            }
        }

        public class AddressDetails
        {
            public string Name { get; set; }
            public string Sex { get; set; }
            public DateTime Dob { get; set; }
        }
    }
}
