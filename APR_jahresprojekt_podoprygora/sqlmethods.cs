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
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.login WHERE username LIKE '" + username + "' AND password LIKE '" + password + "'", con);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                    return count > 0;
                
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
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.login WHERE username LIKE '" + username + "'", con);
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

        public static void password_change(string username, string password, string sqlconnection)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE login SET password ='"+password+"' WHERE username = '"+username+"';", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void signup(string username, string password, string sqlconnection)
        {
            SqlConnection con = new SqlConnection(sqlconnection);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO login (username, password) VALUES (username ='"+username+"', password = '"+password+"';", con);
        }
    }
}
