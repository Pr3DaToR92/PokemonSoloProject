using PokemonSoloProject;

Pokemon starter1 = new Pokemon("Pikachu", "lightning", 100, 5);
Pokemon starter2 = new Pokemon("Bulbasaur", "Grass", 100, 5);
Pokemon starter3 = new Pokemon("Charmander", "Fire", 100, 5);

Meny();
void Meny()
{
    var userInput = "";
    Console.WriteLine("Velkommen skal det være!");
    Console.WriteLine("Trykk 1 for å velge din første Pokemon");
    Console.WriteLine("Trykk 5 for å gå tilbake til Meny");
    userInput = Console.ReadLine();
    //Meny
    while (userInput != null)
        switch (userInput)
        {
            case "1": ChooseStartPokemon();
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            case "5": 
                Meny(); 
                Console.Clear();
                break;
        }
}

void ChooseStartPokemon()
{
    string input;

    Console.WriteLine("Trykk 1 for å velge " + starter1._name);
    
    Console.WriteLine("Trykk 2 for å velge " + starter2._name);
    
    Console.WriteLine("Trykk 3 for å velge " + starter3._name);
    
    Console.WriteLine("Trykk 4 for å gå til Meny");
    input = Console.ReadLine();
    Console.Clear();

    if (input == "4")
    {
        Meny();
        Console.Clear();
    }
}