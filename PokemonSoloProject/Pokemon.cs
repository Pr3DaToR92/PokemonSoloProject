using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSoloProject
{
    internal class Pokemon
    {
        public string _name { get; private set; }
        private string _type;
        private int _hp;
        private int _stamina;
        private int _lvl;
        private int _strength;

        public Pokemon(string name, string type, int hp, int lvl)
        {
            _name = name;
            _type = type;
            _hp  = hp;
            _lvl = lvl;
        }
    }
}
