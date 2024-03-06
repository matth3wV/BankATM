using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add a user to db
            using (ATMContext context = new ATMContext())
            {
                var x = new atmUsers(login = "JimF", pincode = "12345", type = "admin");
                context.Atm_users.Add(x);
                context.SaveChanges();
            }
        }
    }
}
