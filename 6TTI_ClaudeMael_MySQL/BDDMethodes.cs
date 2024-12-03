using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;


namespace _6TTI_ClaudeMael_MySQL
{
    public struct BDDMethodes
    {

        static string DefinirCheminBD() // détermine la chaîne de connexion
        {
            return "server=10.10.51.98;database=mael;port=3306;User Id=mael;password=root";
        }

        public bool GetAllBiens(out DataSet infos)
        {
                MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());

                string query = "SELECT * from biens";
                infos = new DataSet();
            try
            {
                maConnexion.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnexion);

                da.Fill(infos, "mesDonnees");
                maConnexion.Close();
                if (infos.Tables[0].Rows.Count > 0 )
                {
                    return true;
                }
                return false;
            }catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool GetBienFromID(out DataSet infos, int bienId)
        {
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());

            string query = "SELECT * from biens WHERE bienId ="+bienId+";";
            infos = new DataSet();
            try
            {
                maConnexion.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnexion);

                da.Fill(infos, "mesDonnees");
                maConnexion.Close();
                if (infos.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public string ConcateneDataSet(DataSet ds)
        {
            string msg = "";
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++) 
            {
                msg += ds.Tables[0].Rows[i]["bienId"].ToString() + " | " + ds.Tables[0].Rows[i]["taille"].ToString() + " | " + ds.Tables[0].Rows[i]["prix"].ToString() + " | " + ds.Tables[0].Rows[i]["ville"].ToString() + "\n";
            }
            return msg;
        }

        public bool UpdateBien(int bienId, string nom)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "UPDATE biens SET nom=@parametre WHERE bienId =" + bienId + ";";
            MySqlCommand upDateCommand = new MySqlCommand(query, maConnexion);
            try
            {
                maConnexion.Open();
                upDateCommand.Parameters.AddWithValue("@parametre", nom);
                if(upDateCommand.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Table modifiée");
                    ok = true;
                }
                maConnexion.Close();
                return ok;
                
                
            }catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool AddBien(string nom, int taille, int prix, string ville)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "INSERT INTO biens(nom, taille, prix, ville, userId) VALUES(@nom, @taille, @prix, @ville, @userId)";
            MySqlCommand addCommand = new MySqlCommand(query, maConnexion);
            try
            {
                maConnexion.Open();
                addCommand.Parameters.AddWithValue("@nom", nom);
                addCommand.Parameters.AddWithValue("@taille", taille);
                addCommand.Parameters.AddWithValue("@prix", prix);
                addCommand.Parameters.AddWithValue("@ville", ville);
                addCommand.Parameters.AddWithValue("@userId", 1);

                if (addCommand.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Ajout effectué");
                    ok = true;
                }
                maConnexion.Close();
                return ok;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }

        }

        public bool RemoveBien(int bienId)
        {
            bool ok = false;
            MySqlConnection maConnexion = new MySqlConnection(DefinirCheminBD());
            string query = "DELETE FROM biens WHERE bienId=" + bienId + ";";
            MySqlCommand removeCommand = new MySqlCommand(query, maConnexion);
            try
            {
                maConnexion.Open();
                if(removeCommand.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("Suppression effectuée");
                    ok = true;
                }
                maConnexion.Close();
                return ok;
            }catch(Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

    }
}
