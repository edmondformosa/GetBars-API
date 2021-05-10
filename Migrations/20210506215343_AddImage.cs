using Microsoft.EntityFrameworkCore.Migrations;

namespace BarsAPI.Migrations
{
    public partial class AddImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BarDetails",
                columns: table => new
                {
                    BarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deposit = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarDetails", x => x.BarId);
                });

            migrationBuilder.InsertData(
                table: "BarDetails",
                columns: new[] { "BarId", "Address", "Deposit", "Name", "Phone", "Website", "image" },
                values: new object[,]
                {
                    { 1, "Triq il-Knisja, Għarb", 2.00m, "Gharb Rangers Football Club", 21565666, "https://gharb-rangers-bar-restaurant.business.site/", "https://lh3.googleusercontent.com/p/AF1QipPt_KIvv06p72QaiwV7KYrhB8mMz-OIbjg5NJTr=w600-h0" },
                    { 2, "Enrico Mizzi, Victoria Għawdex", 1.50m, "TaPie", 21535455, "https://artzid.com/artwork/tapies-bar-gozo/", "https://content.visitgozo.com/content/2016/09/1-50e296df877544ddaacf302d7867bee7.jpg" },
                    { 3, "Enrico Mizzi, Victoria Għawdex", 3.00m, "Rizzles Cafe", 21552464, "https://timetoeat.com.mt/rizzles-cafe/menu", "https://maltamenu.com.mt/images/restaurants/rizzles-cafe-dolceria-gozo-0.jpg" },
                    { 4, "Triq Victoria, Għawdex", 1.00m, "Glory of England Bar", 21552659, "https://www.visitgozo.com/directory/bars/glory-of-england-bar/", "https://c8.alamy.com/comp/F2CFGE/malta-31-december-2014-on-the-smaller-island-of-gozo-even-here-the-F2CFGE.jpg" },
                    { 5, "Triq tal-Ghajn, Il-Munxar", 5.00m, "La Grotta", 99007070, "https://www.lonelyplanet.com/malta/xlendi/nightlife/la-grotta/a/poi-dri/1136243/1316072", "https://scontent.fmla2-1.fna.fbcdn.net/v/t31.18172-8/23000092_1530772327016007_2975362536196116889_o.jpg?_nc_cat=109&ccb=1-3&_nc_sid=09cbfe&_nc_ohc=_uq44o1bVY8AX8XkTok&_nc_oc=AQki83syHeVUTOOYR1ARMiBR2I5kPLb-q7a8d8A-BK5pXxxlVfzUFmRiCZ9TucfCeaY&_nc_ht=scontent.fmla2-1.fna&oh=8b40d688ce5413c5c340f8b115724589&oe=60BB7622" },
                    { 6, "10, Triq Il-Vittorja, Mgarr", 4.50m, "Gleneagles", 21556543, "https://gleneagles.com/", "https://restaurantguidemalta.com/wp-content/uploads/2019/09/The-Gleneagles-Bar-10-Victoria-Road-Mgarra-Gozo-2.jpg" },
                    { 7, "St. Peter & St. Paul Square, Nadur", 2.20m, "Gebuba", 79470141, "https://www.visitgozo.com/directory/bars/gebuba-bar/", "https://brewhaus.com.mt/wp-content/uploads/2018/02/Gebuba-Bar.jpg" },
                    { 8, "Triq Il Knisja, Xagħra", 3.70m, "Coronation Bar", 27440867, "https://business.google.com/v/coronation-bar-coronations/010526285549816301694/323c/_?caid=12095768560&agid=118149983404&gclid=Cj0KCQjwvr6EBhDOARIsAPpqUPHJSgZ8Cj7smlhxSOL-UQx2T1yckTPYrdhA9pINQeytXCxqteOocJkaAld2EALw_wcB&gclid=Cj0KCQjwvr6EBhDOARIsAPpqUPHJSgZ8Cj7smlhxSOL-UQx2T1yckTPYrdhA9pINQeytXCxqteOocJkaAld2EALw_wcB", "https://www.maltaphotos.com/wp-content/uploads/2017/10/349-Gozo-Xaghra-Tradition-Coronation-Bar-British-.jpg" },
                    { 9, "Triq ir-Repubblika, Victoria", 1.15m, "Ritz Snack Bar", 21333444, "https://www.facebook.com/ritzbarvictoria/", "https://content.visitgozo.com/content/2016/09/13962581_1643113649332592_7674823205499219512_n.jpg" },
                    { 10, "Pjazza President J.F. Kennedy, Victoria", 3.35m, "Flamingo Bar", 21553704, "https://www.visitgozo.com/directory/bars/flamingo-bar/", "https://scontent.fmla2-1.fna.fbcdn.net/v/t31.18172-8/12493763_956092074446027_7567742160996404046_o.png?_nc_cat=109&ccb=1-3&_nc_sid=09cbfe&_nc_ohc=JnqOBKwjxOAAX_ecHmN&_nc_ht=scontent.fmla2-1.fna&oh=1f82b707f54c0efe411d635c26b3e3c8&oe=60BAAD14" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarDetails");
        }
    }
}
