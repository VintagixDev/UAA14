using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I5_6TTIUAA14_ClaudeMael.Objets
{
    internal class Joueur
    {

        private string _pseudo; // Pseudonyme du joueur
        private byte _nbCartouchesEnPoche; // Nombre de cartouche en poche
        private PaintBallGun _myPaintBallGun; // L'arme utilisée

        public string Pseudo {  get { return _pseudo; } }
        public byte NbCartouchesEnPoche { get { return _nbCartouchesEnPoche; } set { _nbCartouchesEnPoche = value; } }

        public PaintBallGun MyPaintBallGun { get { return _myPaintBallGun; } set { _myPaintBallGun = value; } }

        public Joueur(string pseudo, PaintBallGun myPaintBallGun)
        {
            _pseudo = pseudo;
            _myPaintBallGun = myPaintBallGun;
            _nbCartouchesEnPoche = 30;
        }

        /// <summary>
        /// Tirer avec l'arme
        /// </summary>
        /// <returns></returns>
        public string Tire()
        {
            if (_myPaintBallGun.ChargeurEstVide())
            {
                return "Rechargez votre arme afin de pouvoir tirer.";
            }
            _myPaintBallGun.NbBallesChargeur--;
            return "Pew pew! Vous venez de tirer";
        }
        /// <summary>
        /// Recharger l'arme
        /// </summary>
        /// <returns></returns>
        public string Recharge()
        {
            if (_nbCartouchesEnPoche == 0) // Si pas de cartouche en poche
            {
                return "Vous n'avez pas de cartouche dans votre poche...";
            }
            if(_myPaintBallGun.NbBallesChargeur == _myPaintBallGun.TailleChargeur) // Si le chargeur est déjà plein
            {
                return "Votre chargeur est déjà plein. (" + _myPaintBallGun.TailleChargeur + " cartouches)";
            }


            byte cartouchesARecharger = (byte)(_myPaintBallGun.TailleChargeur - _myPaintBallGun.NbBallesChargeur); // Récupérer le nombre manquant de cartouche dans le chargeur
            if(_nbCartouchesEnPoche >= cartouchesARecharger) // Si + de cartouche en poche que de cartouches à recharger
            {
                _nbCartouchesEnPoche -= cartouchesARecharger;
                _myPaintBallGun.NbBallesChargeur += cartouchesARecharger;
            }
            else // Si - de cartouche en poche que de cartouches à recharger
            {
                _myPaintBallGun.NbBallesChargeur += _nbCartouchesEnPoche;
                _nbCartouchesEnPoche = 0;
            }
            return "Vous venez de recharger votre arme. Cartouche(s) dans votre poche restante : " + _nbCartouchesEnPoche;
        }

        /// <summary>
        /// Vérifier son inventaire
        /// </summary>
        /// <returns></returns>
        public string VerifiePoche()
        {
            return "Vous avez " + _nbCartouchesEnPoche + " cartouches en poche.\nLe chargeur de votre arme a " + _myPaintBallGun.NbBallesChargeur + " cartouche(s).";
        }

        /// <summary>
        /// Reprendre des cartouches
        /// </summary>
        /// <returns></returns>
        public string ReprendreCartouches()
        {
            _nbCartouchesEnPoche += 30;
            return "Vous venez de prendre 30 cartouches à l'armurerie. Vous avez maintenant " + _nbCartouchesEnPoche + " cartouche(s) en poche.";
        }

    }
}
