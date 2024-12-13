using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSoloProject
{
    internal class Pokemon
    {
        private string _name = "";
        private string _type = "";
        private int _hp;
        private int _stamina;
        private int _lvl;
        private int _strength;

        public Pokemon(string name, string type)
        {
            _name = name;
            _type = type;
        }
    }
}
