using static System.Net.Mime.MediaTypeNames;
using Microsoft.EntityFrameworkCore;
using gitKovaNaal.Models;


namespace gitKovaNaal.DAL
{

        public class DataLayer : DbContext
        {
            public DataLayer(string ConnectionString) : base(GetOptions(ConnectionString))
            {
                Database.EnsureCreated();
                Seed();
            }
            private void Seed()
            {
            if (Hats.Any()) return;
            Hat newHata = new Hat("Nike", "blue", "Large", "https://anime-market.co.il/products/%D7%A6%D7%A4%D7%A8%D7%93%D7%A2-%D7%9B%D7%95%D7%91%D7%A2-%D7%98%D7%9E%D7%91%D7%9C?variant=47285394374956&currency=ILS&utm_medium=product_sync&utm_source=google&utm_content=sag_organic&utm_campaign=sag_organic&gad_source=1&gclid=Cj0KCQjw8MG1BhCoARIsAHxSiQmPNNrHbMrfUNm10cLKGB2g6VjMO1psynlnNjiW6NImIk0Zsa2-he0aAoCGEALw_wcB");
            Hats.Add(newHata);

            if(Shoes.Any())return;
            Shoe newShoe = new Shoe(43, "Black", "Adidas", "https://www.omall.co.il/items/6080703-adidas?gad_source=1&gclid=Cj0KCQjw8MG1BhCoARIsAHxSiQlpXIDzLTSNecw1tmWBaedQ-QO08WM3wj-_R4L_WGl5EBE1Px7JehEaAviiEALw_wcB");
            Shoes.Add(newShoe);
                SaveChanges();
            }


            private static DbContextOptions GetOptions(string ConnectionString)
            {
                return new DbContextOptionsBuilder().UseSqlServer(ConnectionString).Options;
            }

            public DbSet<Hat> Hats { get; set; }
            public DbSet<Shoe> Shoes { get; set; }
           
        }
    }


