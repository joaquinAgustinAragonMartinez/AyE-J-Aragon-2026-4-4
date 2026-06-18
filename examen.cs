//ejercicio 2
int num = 0;
int Recursiva(int num)
{
    if (num == 0)
    {
        return 0;
    }
    else
    {
        Console.WriteLine(num);
        num = num - 5;
        return Recursiva(num);
    }
}
Console.WriteLine(Recursiva(50));

//ejercicio 1
Random random = new Random();
string[] pokemones = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" };
string[] tipos = { "Grass", "Grass", "Grass", "Fire", "Fire", "Fire", "Water", "Water", "Water", "Bug", "Bug", "Bug", "Bug", "Bug", "Bug", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Poison", "Poison", "Electric", "Electric", "Ground", "Ground", "Poison", "Poison", "Poison", "Poison", "Poison", "Poison", "Fairy", "Fairy", "Fire", "Fire", "Normal", "Normal", "Poison", "Poison", "Grass", "Grass", "Grass", "Bug", "Bug", "Bug", "Bug", "Ground", "Ground", "Normal", "Normal", "Water", "Water", "Fighting", "Fighting", "Fire", "Fire", "Water", "Water", "Water", "Psychic", "Psychic", "Psychic", "Fighting", "Fighting", "Fighting", "Grass", "Grass", "Grass", "Water", "Water", "Rock", "Rock", "Rock", "Fire", "Fire", "Water", "Water", "Electric", "Electric", "Normal", "Normal", "Normal", "Water", "Water", "Poison", "Poison", "Water", "Water", "Ghost", "Ghost", "Ghost", "Rock", "Psychic", "Psychic", "Water", "Water", "Electric", "Electric", "Grass", "Grass", "Ground", "Ground", "Fighting", "Fighting", "Normal", "Poison", "Poison", "Ground", "Ground", "Normal", "Grass", "Normal", "Water", "Water", "Water", "Water", "Water", "Water", "Psychic", "Bug", "Ice", "Electric", "Fire", "Bug", "Normal", "Water", "Water", "Water", "Normal", "Normal", "Water", "Electric", "Fire", "Normal", "Rock", "Rock", "Rock", "Rock", "Rock", "Normal", "Ice", "Electric", "Fire", "Dragon", "Dragon", "Dragon", "Psychic", "Psychic" };

int[,] red = new int[6,6];
int[,] green = new int[6, 6];
int[,] blue = new int[6, 6];
int[,] yellow = new int[6, 6];

int totalred = 0;
int totalgreen = 0;
int totalblue = 0;
int totalyellow = 0;
int equipof1 = 0;
int equipof2 = 0;

for (int i = 0; i < 6; i++)
{
    red[i, 0] = pokemones[random.Next(pokemones.Length)];
    green[i, 0] = pokemones[random.Next(pokemones.Length)];
    blue[i, 0] = pokemones[random.Next(pokemones.Length)];
    yellow[i, 0] = pokemones[random.Next(pokemones.Length)];

    red[i, 1] = tipos[random.Next(tipos.Length)];
    red[i, 1] = tipos[random.Next(tipos.Length)];
    red[i, 1] = tipos[random.Next(tipos.Length)];
    red[i, 1] = tipos[random.Next(tipos.Length)];
}


for (int i = 0; i < 6; i++)
{
    red[i,2] = random.Next(50,81);
    totalred = totalred + yellow[i,2];
}
for (int i = 0; i < 6; i++)
{
    green[i,2] = random.Next(50, 81);
    totalgreen = totalgreen + yellow[i,2];
}
for (int i = 0; i < 6; i++)
{
    blue[i,2] = random.Next(50, 81);
    totalblue = totalblue + yellow[i,2];
}
for (int i = 0; i < 6; i++)
{
    yellow[i,2] = random.Next(50, 81);
    totalyellow = totalyellow + yellow[i,2];
}

Console.WriteLine("equipo rojo");
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(red[i,0]+ " " + red[i,1] + " "+ red[i,2]);
}
Console.WriteLine("equipo verde");
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(green[i, 0] + " " + green[i,1] + " "+ green[i,2]);
}
Console.WriteLine("equipo azul");
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(blue[i, 0] + " " + blue[i,1] + " "+ blue[i,2]);
}
Console.WriteLine("equipo amarillo");
for (int i = 0; i < 6; i++)
{
    Console.WriteLine(yellow[i, 0] + " " + yellow[i,1] + " "+ yellow[i,2]);
}

if (totalred > totalgreen)
{
    Console.WriteLine("gana el equipo rojo, pasa a la final como equipo finalista 1!");
    equipof1 = totalred;
}
if(totalgreen > totalred)
{
    Console.WriteLine("gana el equipo verde, pasa a la final como equipo finalista 1!");
    equipof1 = totalgreen;
}
if (totalblue > totalyellow)
{
    Console.WriteLine("gana el equipo azul, pasa a la final como equipo finalista 2!");
    equipof2 = totalblue;
}
if (totalyellow > totalblue)
{
    Console.WriteLine("gana el equipo amarillo, pasa a la final como equipo finalista 2!");
    equipof2 = totalyellow;
}



if (equipof1 > equipof2)
{
    Console.WriteLine("felicidades, el equipo finalista 1 gano el torneo!");
}
if (equipof2 > equipof1)
{
    Console.WriteLine("felicidades, el equipo finalista 2 gano el torneo!");
}
if (equipof1 == equipof2)
{
    Console.WriteLine("EMPATE");
}
