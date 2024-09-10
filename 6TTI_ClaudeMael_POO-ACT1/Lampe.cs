using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_POO_ACT1
{
    internal class Lampe
    {

        private string _code;
        private string _color;
        private bool _state;
        public Lampe(string code, string color)
        {
            _code = code;
            _color = color;
            _state = false;
        }

        public string getCode()
        {
            return _code;
        }

        public string getColor()
        {
            return _color;
        }

        public bool getState()
        {
            return _state;
        }

        public void switchState()
        {
            _state = !_state;
        }
    }
}
