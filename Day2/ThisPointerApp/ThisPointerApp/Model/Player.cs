using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisPointerApp.Model
{
    internal class Player
    {
        private int _age;
        private string _name;
        private GenderType _gender;

        public Player(string _name, int _age)

        {
            this._age = _age;
            this._name = _name;
            this._gender = GenderType.Female;
          //  Console.WriteLine("constructor with 2 params");
        }

        public Player(string _name, int _age, GenderType _gender) : this(_name, _age)
        {

            this._gender = _gender;
           // Console.WriteLine("constructor with 3 params");
        }

        public Player WhoIsElder(Player secondPlayer) {

            if (this._age > secondPlayer._age) {
                return this;
            }
            else
                return secondPlayer;
        }
        public int Age
        {
            get
            {
                return _age;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public GenderType Gender
        {
            get
            {
                return _gender;
            }
        }
    }
}
