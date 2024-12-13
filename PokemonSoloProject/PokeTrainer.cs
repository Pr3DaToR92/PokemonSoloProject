using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSoloProject
{
    internal class PokeTrainer
    {
        private string _name;
        private string _startPokemon;
        private int _cash;
        private int _pokeBalls;
        private int _potion;

        public PokeTrainer(string name, string startPokemon)
        {
            _name = name;
            _startPokemon = startPokemon;
        }
    }
}
