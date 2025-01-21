using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I5_6TTIUAA14_ClaudeMael.Objets
{
    internal class PaintBallGun
    {

        private byte _nbBallesChargeur; // Nombre de cartouche dans le chargeur
        private byte _tailleChargeur; // Capacité du chargeur

        public byte NbBallesChargeur { get { return _nbBallesChargeur;} set { _nbBallesChargeur = value; } }
        public byte TailleChargeur { get { return _tailleChargeur; } }

        public PaintBallGun()
        {
            _nbBallesChargeur = 0;
            _tailleChargeur = 16;
        }

        /// <summary>
        /// Vérifier si le chargeur est vide
        /// </summary>
        /// <returns></returns>
        public bool ChargeurEstVide()
        {
            if (_nbBallesChargeur == 0) return true;
            return false;
        }

    }
}
