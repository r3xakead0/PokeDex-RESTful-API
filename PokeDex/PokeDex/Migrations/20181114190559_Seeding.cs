using Microsoft.EntityFrameworkCore.Migrations;

namespace PokeDex.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Code", "ImageUrl", "Name", "Type1", "Type2" },
                values: new object[,]
                {
                    { "001", "https://www.serebii.net/pokemongo/pokemon/001.png", "Bulbasaur", "Grass", "Poison" },
                    { "097", "https://www.serebii.net/pokemongo/pokemon/097.png", "Hypno", "Psychic", "" },
                    { "098", "https://www.serebii.net/pokemongo/pokemon/098.png", "Krabby", "Water", "" },
                    { "099", "https://www.serebii.net/pokemongo/pokemon/099.png", "Kingler", "Water", "" },
                    { "100", "https://www.serebii.net/pokemongo/pokemon/100.png", "Voltorb", "Electric", "" },
                    { "101", "https://www.serebii.net/pokemongo/pokemon/101.png", "Electrode", "Electric", "" },
                    { "102", "https://www.serebii.net/pokemongo/pokemon/102.png", "Exeggcute", "Grass", "Psychic" },
                    { "103", "https://www.serebii.net/pokemongo/pokemon/103.png", "Exeggutor", "Grass", "Psychic" },
                    { "104", "https://www.serebii.net/pokemongo/pokemon/104.png", "Cubone", "Ground", "" },
                    { "105", "https://www.serebii.net/pokemongo/pokemon/105.png", "Marowak", "Ground", "" },
                    { "106", "https://www.serebii.net/pokemongo/pokemon/106.png", "Hitmonlee", "Fighting", "" },
                    { "107", "https://www.serebii.net/pokemongo/pokemon/107.png", "Hitmonchan", "Fighting", "" },
                    { "108", "https://www.serebii.net/pokemongo/pokemon/108.png", "Lickitung", "Normal", "" },
                    { "109", "https://www.serebii.net/pokemongo/pokemon/109.png", "Koffing", "Poison", "" },
                    { "110", "https://www.serebii.net/pokemongo/pokemon/110.png", "Weezing", "Poison", "" },
                    { "111", "https://www.serebii.net/pokemongo/pokemon/111.png", "Rhyhorn", "Ground", "Rock" },
                    { "096", "https://www.serebii.net/pokemongo/pokemon/096.png", "Drowzee", "Psychic", "" },
                    { "112", "https://www.serebii.net/pokemongo/pokemon/112.png", "Rhydon", "Ground", "Rock" },
                    { "095", "https://www.serebii.net/pokemongo/pokemon/095.png", "Onix", "Rock", "Ground" },
                    { "093", "https://www.serebii.net/pokemongo/pokemon/093.png", "Haunter", "Ghost", "Poison" },
                    { "078", "https://www.serebii.net/pokemongo/pokemon/078.png", "Rapidash", "Fire", "" },
                    { "079", "https://www.serebii.net/pokemongo/pokemon/079.png", "Slowpoke", "Water", "Psychic" },
                    { "080", "https://www.serebii.net/pokemongo/pokemon/080.png", "Slowbro", "Water", "Psychic" },
                    { "081", "https://www.serebii.net/pokemongo/pokemon/081.png", "Magnemite", "Electric", "Steel" },
                    { "082", "https://www.serebii.net/pokemongo/pokemon/082.png", "Magneton", "Electric", "Steel" },
                    { "083", "https://www.serebii.net/pokemongo/pokemon/083.png", "Farfetchd", "Normal", "Flying" },
                    { "084", "https://www.serebii.net/pokemongo/pokemon/084.png", "Doduo", "Normal", "Flying" },
                    { "085", "https://www.serebii.net/pokemongo/pokemon/085.png", "Dodrio", "Normal", "Flying" },
                    { "086", "https://www.serebii.net/pokemongo/pokemon/086.png", "Seel", "Water", "" },
                    { "087", "https://www.serebii.net/pokemongo/pokemon/087.png", "Dewgong", "Water", "Ice" },
                    { "088", "https://www.serebii.net/pokemongo/pokemon/088.png", "Grimer", "Poison", "" },
                    { "089", "https://www.serebii.net/pokemongo/pokemon/089.png", "Muk", "Poison", "" },
                    { "090", "https://www.serebii.net/pokemongo/pokemon/090.png", "Shellder", "Water", "" },
                    { "091", "https://www.serebii.net/pokemongo/pokemon/091.png", "Cloyster", "Water", "Ice" },
                    { "092", "https://www.serebii.net/pokemongo/pokemon/092.png", "Gastly", "Ghost", "Poison" },
                    { "094", "https://www.serebii.net/pokemongo/pokemon/094.png", "Gengar", "Ghost", "Poison" },
                    { "077", "https://www.serebii.net/pokemongo/pokemon/077.png", "Ponyta", "Fire", "" },
                    { "113", "https://www.serebii.net/pokemongo/pokemon/113.png", "Chansey", "Normal", "" },
                    { "115", "https://www.serebii.net/pokemongo/pokemon/115.png", "Kangaskhan", "Normal", "" },
                    { "135", "https://www.serebii.net/pokemongo/pokemon/135.png", "Jolteon", "Electric", "" },
                    { "136", "https://www.serebii.net/pokemongo/pokemon/136.png", "Flareon", "Fire", "" },
                    { "137", "https://www.serebii.net/pokemongo/pokemon/137.png", "Porygon", "Normal", "" },
                    { "138", "https://www.serebii.net/pokemongo/pokemon/138.png", "Omanyte", "Rock", "Water" },
                    { "139", "https://www.serebii.net/pokemongo/pokemon/139.png", "Omastar", "Rock", "Water" },
                    { "140", "https://www.serebii.net/pokemongo/pokemon/140.png", "Kabuto", "Rock", "Water" },
                    { "141", "https://www.serebii.net/pokemongo/pokemon/141.png", "Kabutops", "Rock", "Water" },
                    { "142", "https://www.serebii.net/pokemongo/pokemon/142.png", "Aerodactyl", "Rock", "Flying" },
                    { "143", "https://www.serebii.net/pokemongo/pokemon/143.png", "Snorlax", "Normal", "" },
                    { "144", "https://www.serebii.net/pokemongo/pokemon/144.png", "Articuno", "Ice", "Flying" },
                    { "145", "https://www.serebii.net/pokemongo/pokemon/145.png", "Zapdos", "Electric", "Flying" },
                    { "146", "https://www.serebii.net/pokemongo/pokemon/146.png", "Moltres", "Fire", "Flying" },
                    { "147", "https://www.serebii.net/pokemongo/pokemon/147.png", "Dratini", "Dragon", "" },
                    { "148", "https://www.serebii.net/pokemongo/pokemon/148.png", "Dragonair", "Dragon", "" },
                    { "149", "https://www.serebii.net/pokemongo/pokemon/149.png", "Dragonite", "Dragon", "Flying" },
                    { "134", "https://www.serebii.net/pokemongo/pokemon/134.png", "Vaporeon", "Water", "" },
                    { "114", "https://www.serebii.net/pokemongo/pokemon/114.png", "Tangela", "Grass", "" },
                    { "133", "https://www.serebii.net/pokemongo/pokemon/133.png", "Eevee", "Normal", "" },
                    { "131", "https://www.serebii.net/pokemongo/pokemon/131.png", "Lapras", "Water", "Ice" },
                    { "116", "https://www.serebii.net/pokemongo/pokemon/116.png", "Horsea", "Water", "" },
                    { "117", "https://www.serebii.net/pokemongo/pokemon/117.png", "Seadra", "Water", "" },
                    { "118", "https://www.serebii.net/pokemongo/pokemon/118.png", "Goldeen", "Water", "" },
                    { "119", "https://www.serebii.net/pokemongo/pokemon/119.png", "Seaking", "Water", "" },
                    { "120", "https://www.serebii.net/pokemongo/pokemon/120.png", "Staryu", "Water", "" },
                    { "121", "https://www.serebii.net/pokemongo/pokemon/121.png", "Starmie", "Water", "Psychic" },
                    { "122", "https://www.serebii.net/pokemongo/pokemon/122.png", "Mr. Mime", "Psychic", "Fairy" },
                    { "123", "https://www.serebii.net/pokemongo/pokemon/123.png", "Scyther", "Bug", "Flying" },
                    { "124", "https://www.serebii.net/pokemongo/pokemon/124.png", "Jynx", "Ice", "Psychic" },
                    { "125", "https://www.serebii.net/pokemongo/pokemon/125.png", "Electabuzz", "Electric", "" },
                    { "126", "https://www.serebii.net/pokemongo/pokemon/126.png", "Magmar", "Fire", "" },
                    { "127", "https://www.serebii.net/pokemongo/pokemon/127.png", "Pinsir", "Bug", "" },
                    { "128", "https://www.serebii.net/pokemongo/pokemon/128.png", "Tauros", "Normal", "" },
                    { "129", "https://www.serebii.net/pokemongo/pokemon/129.png", "Magikarp", "Water", "" },
                    { "130", "https://www.serebii.net/pokemongo/pokemon/130.png", "Gyarados", "Water", "Flying" },
                    { "132", "https://www.serebii.net/pokemongo/pokemon/132.png", "Ditto", "Normal", "" },
                    { "150", "https://www.serebii.net/pokemongo/pokemon/150.png", "Mewtwo", "Psychic", "" },
                    { "076", "https://www.serebii.net/pokemongo/pokemon/076.png", "Golem", "Rock", "Ground" },
                    { "074", "https://www.serebii.net/pokemongo/pokemon/074.png", "Geodude", "Rock", "Ground" },
                    { "021", "https://www.serebii.net/pokemongo/pokemon/021.png", "Spearow", "Normal", "Flying" },
                    { "022", "https://www.serebii.net/pokemongo/pokemon/022.png", "Fearow", "Normal", "Flying" },
                    { "023", "https://www.serebii.net/pokemongo/pokemon/023.png", "Ekans", "Poison", "" },
                    { "024", "https://www.serebii.net/pokemongo/pokemon/024.png", "Arbok", "Poison", "" },
                    { "025", "https://www.serebii.net/pokemongo/pokemon/025.png", "Pikachu", "Electric", "" },
                    { "026", "https://www.serebii.net/pokemongo/pokemon/026.png", "Raichu", "Electric", "" },
                    { "027", "https://www.serebii.net/pokemongo/pokemon/027.png", "Sandshrew", "Ground", "" },
                    { "028", "https://www.serebii.net/pokemongo/pokemon/028.png", "Sandslash", "Ground", "" },
                    { "029", "https://www.serebii.net/pokemongo/pokemon/029.png", "Nidoran♀", "Poison", "" },
                    { "030", "https://www.serebii.net/pokemongo/pokemon/030.png", "Nidorina", "Poison", "" },
                    { "031", "https://www.serebii.net/pokemongo/pokemon/031.png", "Nidoqueen", "Poison", "Ground" },
                    { "032", "https://www.serebii.net/pokemongo/pokemon/032.png", "Nidoran♂", "Poison", "" },
                    { "033", "https://www.serebii.net/pokemongo/pokemon/033.png", "Nidorino", "Poison", "" },
                    { "034", "https://www.serebii.net/pokemongo/pokemon/034.png", "Nidoking", "Poison", "Ground" },
                    { "035", "https://www.serebii.net/pokemongo/pokemon/035.png", "Clefairy", "Fairy", "" },
                    { "020", "https://www.serebii.net/pokemongo/pokemon/020.png", "Raticate", "Normal", "" },
                    { "036", "https://www.serebii.net/pokemongo/pokemon/036.png", "Clefable", "Fairy", "" },
                    { "019", "https://www.serebii.net/pokemongo/pokemon/019.png", "Rattata", "Normal", "" },
                    { "017", "https://www.serebii.net/pokemongo/pokemon/017.png", "Pidgeotto", "Normal", "Flying" },
                    { "002", "https://www.serebii.net/pokemongo/pokemon/002.png", "Ivysaur", "Grass", "Poison" },
                    { "003", "https://www.serebii.net/pokemongo/pokemon/003.png", "Venusaur", "Grass", "Poison" },
                    { "004", "https://www.serebii.net/pokemongo/pokemon/004.png", "Charmander", "Fire", "" },
                    { "005", "https://www.serebii.net/pokemongo/pokemon/005.png", "Charmeleon", "Fire", "" },
                    { "006", "https://www.serebii.net/pokemongo/pokemon/006.png", "Charizard", "Fire", "Flying" },
                    { "007", "https://www.serebii.net/pokemongo/pokemon/007.png", "Squirtle", "Water", "" },
                    { "008", "https://www.serebii.net/pokemongo/pokemon/008.png", "Wartortle", "Water", "" },
                    { "009", "https://www.serebii.net/pokemongo/pokemon/009.png", "Blastoise", "Water", "" },
                    { "010", "https://www.serebii.net/pokemongo/pokemon/010.png", "Caterpie", "Bug", "" },
                    { "011", "https://www.serebii.net/pokemongo/pokemon/011.png", "Metapod", "Bug", "" },
                    { "012", "https://www.serebii.net/pokemongo/pokemon/012.png", "Butterfree", "Bug", "Flying" },
                    { "013", "https://www.serebii.net/pokemongo/pokemon/013.png", "Weedle", "Bug", "Poison" },
                    { "014", "https://www.serebii.net/pokemongo/pokemon/014.png", "Kakuna", "Bug", "Poison" },
                    { "015", "https://www.serebii.net/pokemongo/pokemon/015.png", "Beedrill", "Bug", "Poison" },
                    { "016", "https://www.serebii.net/pokemongo/pokemon/016.png", "Pidgey", "Normal", "Flying" },
                    { "018", "https://www.serebii.net/pokemongo/pokemon/018.png", "Pidgeot", "Normal", "Flying" },
                    { "075", "https://www.serebii.net/pokemongo/pokemon/075.png", "Graveler", "Rock", "Ground" },
                    { "037", "https://www.serebii.net/pokemongo/pokemon/037.png", "Vulpix", "Fire", "" },
                    { "039", "https://www.serebii.net/pokemongo/pokemon/039.png", "Jigglypuff", "Normal", "Fairy" },
                    { "059", "https://www.serebii.net/pokemongo/pokemon/059.png", "Arcanine", "Fire", "" },
                    { "060", "https://www.serebii.net/pokemongo/pokemon/060.png", "Poliwag", "Water", "" },
                    { "061", "https://www.serebii.net/pokemongo/pokemon/061.png", "Poliwhirl", "Water", "" },
                    { "062", "https://www.serebii.net/pokemongo/pokemon/062.png", "Poliwrath", "Water", "Fighting" },
                    { "063", "https://www.serebii.net/pokemongo/pokemon/063.png", "Abra", "Psychic", "" },
                    { "064", "https://www.serebii.net/pokemongo/pokemon/064.png", "Kadabra", "Psychic", "" },
                    { "065", "https://www.serebii.net/pokemongo/pokemon/065.png", "Alakazam", "Psychic", "" },
                    { "066", "https://www.serebii.net/pokemongo/pokemon/066.png", "Machop", "Fighting", "" },
                    { "067", "https://www.serebii.net/pokemongo/pokemon/067.png", "Machoke", "Fighting", "" },
                    { "068", "https://www.serebii.net/pokemongo/pokemon/068.png", "Machamp", "Fighting", "" },
                    { "069", "https://www.serebii.net/pokemongo/pokemon/069.png", "Bellsprout", "Grass", "Poison" },
                    { "070", "https://www.serebii.net/pokemongo/pokemon/070.png", "Weepinbell", "Grass", "Poison" },
                    { "071", "https://www.serebii.net/pokemongo/pokemon/071.png", "Victreebel", "Grass", "Poison" },
                    { "072", "https://www.serebii.net/pokemongo/pokemon/072.png", "Tentacool", "Water", "Poison" },
                    { "073", "https://www.serebii.net/pokemongo/pokemon/073.png", "Tentacruel", "Water", "Poison" },
                    { "058", "https://www.serebii.net/pokemongo/pokemon/058.png", "Growlithe", "Fire", "" },
                    { "038", "https://www.serebii.net/pokemongo/pokemon/038.png", "Ninetales", "Fire", "" },
                    { "057", "https://www.serebii.net/pokemongo/pokemon/057.png", "Primeape", "Fighting", "" },
                    { "055", "https://www.serebii.net/pokemongo/pokemon/055.png", "Golduck", "Water", "" },
                    { "040", "https://www.serebii.net/pokemongo/pokemon/040.png", "Wigglytuff", "Normal", "Fairy" },
                    { "041", "https://www.serebii.net/pokemongo/pokemon/041.png", "Zubat", "Poison", "Flying" },
                    { "042", "https://www.serebii.net/pokemongo/pokemon/042.png", "Golbat", "Poison", "Flying" },
                    { "043", "https://www.serebii.net/pokemongo/pokemon/043.png", "Oddish", "Grass", "Poison" },
                    { "044", "https://www.serebii.net/pokemongo/pokemon/044.png", "Gloom", "Grass", "Poison" },
                    { "045", "https://www.serebii.net/pokemongo/pokemon/045.png", "Vileplume", "Grass", "Poison" },
                    { "046", "https://www.serebii.net/pokemongo/pokemon/046.png", "Paras", "Bug", "Grass" },
                    { "047", "https://www.serebii.net/pokemongo/pokemon/047.png", "Parasect", "Bug", "Grass" },
                    { "048", "https://www.serebii.net/pokemongo/pokemon/048.png", "Venonat", "Bug", "Poison" },
                    { "049", "https://www.serebii.net/pokemongo/pokemon/049.png", "Venomoth", "Bug", "Poison" },
                    { "050", "https://www.serebii.net/pokemongo/pokemon/050.png", "Diglett", "Ground", "" },
                    { "051", "https://www.serebii.net/pokemongo/pokemon/051.png", "Dugtrio", "Ground", "" },
                    { "052", "https://www.serebii.net/pokemongo/pokemon/052.png", "Meowth", "Normal", "" },
                    { "053", "https://www.serebii.net/pokemongo/pokemon/053.png", "Persian", "Normal", "" },
                    { "054", "https://www.serebii.net/pokemongo/pokemon/054.png", "Psyduck", "Water", "" },
                    { "056", "https://www.serebii.net/pokemongo/pokemon/056.png", "Mankey", "Fighting", "" },
                    { "151", "https://www.serebii.net/pokemongo/pokemon/151.png", "Mew", "Psychic", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "001");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "002");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "003");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "004");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "005");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "006");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "007");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "008");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "009");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "010");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "011");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "012");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "013");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "014");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "015");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "016");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "017");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "018");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "019");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "020");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "021");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "022");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "023");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "024");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "025");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "026");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "027");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "028");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "029");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "030");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "031");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "032");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "033");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "034");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "035");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "036");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "037");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "038");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "039");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "040");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "041");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "042");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "043");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "044");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "045");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "046");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "047");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "048");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "049");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "050");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "051");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "052");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "053");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "054");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "055");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "056");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "057");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "058");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "059");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "060");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "061");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "062");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "063");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "064");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "065");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "066");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "067");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "068");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "069");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "070");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "071");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "072");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "073");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "074");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "075");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "076");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "077");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "078");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "079");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "080");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "081");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "082");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "083");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "084");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "085");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "086");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "087");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "088");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "089");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "090");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "091");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "092");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "093");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "094");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "095");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "096");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "097");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "098");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "099");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "100");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "101");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "102");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "103");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "104");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "105");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "106");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "107");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "108");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "109");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "110");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "111");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "112");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "113");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "114");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "115");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "116");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "117");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "118");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "119");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "120");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "121");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "122");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "123");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "124");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "125");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "126");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "127");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "128");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "129");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "130");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "131");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "132");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "133");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "134");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "135");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "136");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "137");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "138");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "139");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "140");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "141");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "142");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "143");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "144");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "145");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "146");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "147");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "148");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "149");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "150");

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "Code",
                keyValue: "151");
        }
    }
}
