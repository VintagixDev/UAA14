using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAA14_I4_ClaudeMael
{
    public struct Methodes
    {
        /// <summary>
        /// Permet de remplir un tableau d'entiers de 8 places à partir d'un string de longueur <= 7
        /// si le string est de taille < 7, on place des 0 en tête de tableau
        /// On obtient ainsi un octet 
        /// </summary>
        /// <param name="nombreBinaire">non vide de taille <= 7 contenant des 0 et des 1 uniquement</param>
        /// <returns></returns>
        public ushort[] RemplirTableau(string nombreBinaire)
        {
            ushort[] TabBin = new ushort[8];
            for (int i = 0; i < TabBin.Length; i++)
            {
                TabBin[i] = 0;
            }
            for (int i = 0; i < nombreBinaire.Length; i++)
            {
                TabBin[7 - i] = ushort.Parse(nombreBinaire[nombreBinaire.Length - 1 - i].ToString());
            }
            return TabBin;
        }
        /// <summary>
        /// Réalise l'addition binaire de deux octets sans dépassement
        /// </summary>
        /// <param name="t1">tableau de taille 8 contenant un octet (0 et 1 uniquement) non vide</param>
        /// <param name="t2">tableau de taille 8 contenant un octet (0 et 1 uniquement) non vide</param>
        /// <param name="tRes">tableau de taille 8 contenant un octet (0 et 1 uniquement) somme binaire des deux précédents</param>
        /// <param name="ok">vrai si l'opération a pu se réaliser, faux si dépassement de l'octet</param>
        public void Additionne(ushort[] t1, ushort[] t2, out ushort[] tRes, out bool ok)
        {
            ok = true;
            ushort report = 0;
            ushort res;
            tRes = new ushort[8];
            for (int i = 7; i >= 0; i--)
            {
                res = (ushort)(t1[i] + t2[i] + report);
                if ((int)(res / 2) == 0)
                {
                    report = 0;
                }
                else
                {
                    report = 1;
                }
                if (res == 1)
                {
                    tRes[i] = 1;
                }
                else
                {
                    if (res % 2 == 1)
                    {
                        tRes[i] = 1;
                    }
                    else
                    {
                        tRes[i] = 0;
                    }
                }

            }
            if (report == 1)
            {
                ok = false;
            }
        }
        /// <summary>
        /// Réalise la soustraction binaire de deux octets sans dépassement
        /// </summary>
        /// <param name="t1">tableau de taille 8 contenant un octet (0 et 1 uniquement) non vide le plus grand des deux nombres binaires</param>
        /// <param name="t2">tableau de taille 8 contenant un octet (0 et 1 uniquement) non vide</param>
        /// <param name="tRes">tableau de taille 8 contenant un octet (0 et 1 uniquement) addition binaire des deux précédents</param>
        /// <returns></returns>
        public bool Soustrait(ushort[] t1, ushort[] t2, out ushort[] tRes)
        {
            int[] tTemp = new int[8];
            tRes = new ushort[8];
            bool ok = true;

            for (int i = 0; i <= 7; i++)
            {
                tTemp[i] = t1[i] - t2[i];
            }
            for (int i = 7; i >= 1; i--)
            {
                if (tTemp[i] == -1)
                {
                    t2[i - 1] = (ushort)(t2[i - 1] + 1);
                    t1[i] = (ushort)(t1[i] + 2);
                }
                if (t1[i] < t2[i])
                {
                    t2[i - 1] = (ushort)(t2[i - 1] + 1);
                    t1[i] = (ushort)(t1[i] + 2);
                }
                tRes[i] = (ushort)(t1[i] - t2[i]);
            }
            if (t1[0] >= t2[0])
            {
                tRes[0] = (ushort)(t1[0] - t2[0]);
            }
            else
            {
                ok = false;
            }
            return ok;
        }
        /// <summary>
        /// construit une chaine de caractères reprenant le contenu d'un tableau d'entiers, tous placés à côté des autres sans séparateur
        /// </summary>
        /// <param name="t">non vide</param>
        /// <returns></returns>
        public string Concatene(ushort[] t)
        {
            string chaine = "";
            for (int i = 0; i < t.Length; i++)
            {
                chaine += t[i];
            }
            return chaine;
        }
    }
}