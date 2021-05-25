using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennisverwaltungssystem.BL;
using Tennisverwaltungssystem.PL.frm_Menü_m.UserControls;

namespace Tennisverwaltungssystem.DAL
{
    class DAL_Buchen
    {

        public static bool  Doppelbuchung = false;
        public static bool IsOccupied(Daypanel f1)
        {
            int Anfangszeit;
            int Endzeit;
            string query = $"SELECT * FROM user_bucht_tennisplatz WHERE Tennisplatz_id_Platznummer='{f1.Platznummer}' " +
                $"AND Datum='{f1.Date.Date.ToString("yyyy-MM-dd HH:mm:ss")}' AND (Beginn='{f1.Anfangszeit}' " +
                $"OR (Beginn<'{f1.Anfangszeit}' AND Ende>'{f1.Anfangszeit}'));";

            if (DAL_Main.Connect())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, DAL.DAL_Main.conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //Endzeit = Convert.ToInt32(reader["Ende"]);
                            //Anfangszeit = Convert.ToInt32(reader["Beginn"]);
                            //if (Endzeit - Anfangszeit == 2)
                            //{
                            //    Doppelbuchung = true;
                            //}
                            //else
                            //{
                            //    Doppelbuchung = false;
                            //}

                            reader.Close();
                            DAL.DAL_Main.conn.Close();
                            return true;
                        }
                        else
                        {
                            reader.Close();
                            DAL.DAL_Main.conn.Close();
                            return false;
                        }
                    }

                }

            }
            else
            {
                DAL.DAL_Main.conn.Close();
                return false;
            }
        }

       

        public static bool IsBookingNumberUsed(string bookingnumber)
        {
            string query = $"SELECT * FROM user_bucht_tennisplatz WHERE ID_Buchungsnummer={bookingnumber};";
            return DAL.DAL_Main.ReadData(query);
        }

        public static bool IsInserted(Buchung buchung)
        {
      
            string query = $"INSERT INTO user_bucht_tennisplatz(ID_Buchungsnummer,User_idUser, Tennisplatz_id_Platznummer, Anmerkung,Datum,Beginn,Ende,Personenanzahl,isMitglied) VALUES(?id_buchungsnummer, ?user_userid, ?tennisplatz_id_platznummer, ?anmerkung, ?datum, ?beginn, ?ende,?personenanzahl, ?ismitglied)";
            if (DAL_Main.Connect())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, DAL_Main.conn))
                {


                    cmd.Parameters.Add(new MySqlParameter("id_buchungsnummer",
                    MySqlDbType.VarChar, 30)
                    { Value = buchung.Buchungsnummer });

                    cmd.Parameters.Add(new MySqlParameter("user_userid",
                    MySqlDbType.Int32)
                    { Value = buchung.Buchender.ID });

                    cmd.Parameters.Add(new MySqlParameter("tennisplatz_id_platznummer",
                    MySqlDbType.Int32)
                    { Value = buchung.Platznummer });

                    cmd.Parameters.Add(new MySqlParameter("anmerkung",
                    MySqlDbType.VarChar, 30)
                    { Value = buchung.Anmerkung });


                    cmd.Parameters.Add(new MySqlParameter("datum",
                    MySqlDbType.DateTime)
                    { Value = buchung.Datum});

                    cmd.Parameters.Add(new MySqlParameter("beginn",
                    MySqlDbType.VarChar, 30)
                    { Value = buchung.Anfangszeit });

                    
                   
                    cmd.Parameters.Add(new MySqlParameter("ende",
                    MySqlDbType.VarChar, 30)
                    { Value = buchung.Endzeit });

                    cmd.Parameters.Add(new MySqlParameter("personenanzahl",
                    MySqlDbType.Int32)
                    { Value = buchung.AnzahlPersonen });

                    cmd.Parameters.Add(new MySqlParameter("ismitglied",
                    MySqlDbType.Int32)
                    { Value = buchung.isMitglied });
                    return DAL.DAL_Main.TryToExecute(cmd);
                }


            }
            else
            {
                DAL_Main.conn.Close();
                return false;
            }










        }


    }
        
    }

