using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ClassWork_02_09_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    db.Database.EnsureDeleted();
            //    db.Database.EnsureCreated();

            //    List<Company> companies = new List<Company> { 

            //        new Company { Name = "111" },
            //        new Company { Name = "222" },
            //        new Company { Name = "333" }


            //    };


            //    var shop1 = new Shop { Name = "11", CountOfEmployee = 1,Company = companies[0] };
            //    var shop2 = new Shop { Name = "22", CountOfEmployee = 2,Company = companies[1] };
            //    var shop3 = new Shop { Name = "33", CountOfEmployee = 3,Company = companies[2] };


            //    var user1 = new Buyer { Name = "Tom" };
            //    var user2 = new Buyer { Name = "Dom" };
            //    var user3 = new Buyer { Name = "Test" };

            //    db.Companies.AddRange(companies);
            //    db.Shops.AddRange(shop1, shop2, shop3);
            //    db.Buyers.AddRange(user1, user2, user3);

            //    db.SaveChanges();

            //}


            //Company info + Shop List + Buyer List
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Companies.Include(c => c.shops).ThenInclude(s => s.Custumers);
            }


        }




    }


    public class DBManager()
    {

        
        public void ShowFullCompanyInfo()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Companies.Include(c => c.shops).ThenInclude(s => s.Custumers);
            }
        }

    }
}
