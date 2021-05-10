using BarsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarsAPI.Migrations
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BarDetails> BarDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BarDetails>().HasData(
                new BarDetails { BarId = 1, Name = "Gharb Rangers Football Club", Address = "Triq il-Knisja, Għarb", Phone = 21565666, Website = "https://gharb-rangers-bar-restaurant.business.site/", image= "https://lh3.googleusercontent.com/p/AF1QipPt_KIvv06p72QaiwV7KYrhB8mMz-OIbjg5NJTr=w600-h0", Deposit = 2.00M },
                new BarDetails { BarId = 2, Name = "TaPie", Address = "Enrico Mizzi, Victoria Għawdex", Phone = 21535455, Website = "https://artzid.com/artwork/tapies-bar-gozo/", image = "https://content.visitgozo.com/content/2016/09/1-50e296df877544ddaacf302d7867bee7.jpg", Deposit = 1.50M },
                new BarDetails { BarId = 3, Name = "Rizzles Cafe", Address = "Enrico Mizzi, Victoria Għawdex", Phone = 21552464, Website = "https://timetoeat.com.mt/rizzles-cafe/menu", image = "https://maltamenu.com.mt/images/restaurants/rizzles-cafe-dolceria-gozo-0.jpg", Deposit = 3.00M },
                new BarDetails { BarId = 4, Name = "Glory of England Bar", Address = "Triq Victoria, Għawdex", Phone = 21552659, Website = "https://www.visitgozo.com/directory/bars/glory-of-england-bar/", image = "https://c8.alamy.com/comp/F2CFGE/malta-31-december-2014-on-the-smaller-island-of-gozo-even-here-the-F2CFGE.jpg", Deposit = 1.00M },
                new BarDetails { BarId = 5, Name = "La Grotta", Address = "Triq tal-Ghajn, Il-Munxar", Phone = 99007070, Website = "https://www.lonelyplanet.com/malta/xlendi/nightlife/la-grotta/a/poi-dri/1136243/1316072", image = "https://scontent.fmla2-1.fna.fbcdn.net/v/t31.18172-8/23000092_1530772327016007_2975362536196116889_o.jpg?_nc_cat=109&ccb=1-3&_nc_sid=09cbfe&_nc_ohc=_uq44o1bVY8AX8XkTok&_nc_oc=AQki83syHeVUTOOYR1ARMiBR2I5kPLb-q7a8d8A-BK5pXxxlVfzUFmRiCZ9TucfCeaY&_nc_ht=scontent.fmla2-1.fna&oh=8b40d688ce5413c5c340f8b115724589&oe=60BB7622", Deposit = 5.00M },
                new BarDetails { BarId = 6, Name = "Gleneagles", Address = "10, Triq Il-Vittorja, Mgarr", Phone = 21556543, Website = "https://gleneagles.com/", image = "https://restaurantguidemalta.com/wp-content/uploads/2019/09/The-Gleneagles-Bar-10-Victoria-Road-Mgarra-Gozo-2.jpg", Deposit = 4.50M },
                new BarDetails { BarId = 7, Name = "Gebuba", Address = "St. Peter & St. Paul Square, Nadur", Phone = 79470141, Website = "https://www.visitgozo.com/directory/bars/gebuba-bar/", image = "https://brewhaus.com.mt/wp-content/uploads/2018/02/Gebuba-Bar.jpg", Deposit = 2.20M },
                new BarDetails { BarId = 8, Name = "Coronation Bar", Address = "Triq Il Knisja, Xagħra", Phone = 27440867, Website = "https://business.google.com/v/coronation-bar-coronations/010526285549816301694/323c/_?caid=12095768560&agid=118149983404&gclid=Cj0KCQjwvr6EBhDOARIsAPpqUPHJSgZ8Cj7smlhxSOL-UQx2T1yckTPYrdhA9pINQeytXCxqteOocJkaAld2EALw_wcB&gclid=Cj0KCQjwvr6EBhDOARIsAPpqUPHJSgZ8Cj7smlhxSOL-UQx2T1yckTPYrdhA9pINQeytXCxqteOocJkaAld2EALw_wcB", image = "https://www.maltaphotos.com/wp-content/uploads/2017/10/349-Gozo-Xaghra-Tradition-Coronation-Bar-British-.jpg", Deposit = 3.70M },
                new BarDetails { BarId = 9, Name = "Ritz Snack Bar", Address = "Triq ir-Repubblika, Victoria", Phone = 21333444, Website = "https://www.facebook.com/ritzbarvictoria/", image= "https://content.visitgozo.com/content/2016/09/13962581_1643113649332592_7674823205499219512_n.jpg", Deposit = 1.15M },
                new BarDetails { BarId = 10, Name = "Flamingo Bar", Address = "Pjazza President J.F. Kennedy, Victoria", Phone = 21553704, Website = "https://www.visitgozo.com/directory/bars/flamingo-bar/", image = "https://scontent.fmla2-1.fna.fbcdn.net/v/t31.18172-8/12493763_956092074446027_7567742160996404046_o.png?_nc_cat=109&ccb=1-3&_nc_sid=09cbfe&_nc_ohc=JnqOBKwjxOAAX_ecHmN&_nc_ht=scontent.fmla2-1.fna&oh=1f82b707f54c0efe411d635c26b3e3c8&oe=60BAAD14", Deposit = 3.35M }
                );
        }
    }
}
