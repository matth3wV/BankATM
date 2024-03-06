using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data.Common;
using System.Data.Entity;


namespace ATMApp
{
    class atmUsers
    {
        public int id { get; set; }
        public string login { get; set; }
        public string pincode { get; set; }
        public string userType { get; set; }

    }


    public class ATMContext : DBContext
    {
        static readonly string connectionString = "Server=localhost;User ID=root;Password=password321; Database=atm_users";
        public DbSet<atmUsers> atm_users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    
    }

}
