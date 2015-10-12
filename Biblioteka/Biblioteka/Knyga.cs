using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Knyga //Klase
    {
        public string Pavadinimas { get; set; } //Auto-implemented property
        private string[] _autoriai;
        private int _isbn;

        public Knyga(string pavadinimas, int isbn, int autoriuKiekis = 0) //Neprivalomas argumentas
        {
            _autoriai = new string[autoriuKiekis];
            _isbn = isbn;
        }

        public string this[int index] //Indexed property
        {
            get
            {
                return _autoriai[index];
            }
            set
            {
                _autoriai[index] = value;
            }
        }
    }
}
