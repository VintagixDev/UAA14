using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6TTI_ClaudeMael_IntroPOO
{
    internal class Chien
    {

        private int _age;
        private string _name;
        private string _race;
        private double _taille;
        private double _poids;
        private string _etat;
        private bool _puce;
        public Chien(int age, string name, string race, double taille, double poids, string etat, bool puce)
        {
            _age = age;
            _name = name;
            _race = race;
            _taille = taille;
            _poids = poids;
            _etat = etat;
            _puce = puce;
        }


       

        public string Name
        {
            get { return _name; }
            set {  _name = value; }
        }


        public int Age
        {
            get { return _age; }
            set { _age++; }
        }

        public string Manger()
        {
            return "Le chien a mangé";
        }

        public string Boire()
        {
            return "Le chien a bu";
        }


        public string SeBlesser() 
        {
            return "Le chien s'est blessé :(";
        }

        public string FaireSesBesoins()
        {
            return "Le chien a fait ses besoins";
        }

        public string Mourir()
        {
            return "Le chien est mort rip";
        }



    }
}
