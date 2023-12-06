using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Collections;

namespace APR_jahresprojekt_podoprygora
{
    internal static class Sqlmethods
    {
        public static readonly string constring = "Server = (localdb)\\MSSQLLocalDB; Initial Catalog = jahresprojektDB; Integrated Security = true;";

        public static void sqlconnection(string sqlconnection)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                con.Close();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        public static bool validation(string username, string password, string sqlconnection)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                string cmdstring = "SELECT COUNT(*) FROM dbo.login WHERE username LIKE '" + username + "' AND password LIKE '" + password + "'";
                using (SqlCommand cmd = new SqlCommand(cmdstring, con)
                {
                })
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
                return false;
            }
        }

        public static bool usernameValidation(string username, string sqlconnection)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                string cmdstring = "SELECT COUNT(*) FROM dbo.login WHERE username LIKE '" + username + "'";
                SqlCommand cmd = new SqlCommand(cmdstring, con);
                    cmd.Parameters.AddWithValue("username", username);
                    int count = (int)cmd.ExecuteScalar();
                    con.Close();
                    return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
