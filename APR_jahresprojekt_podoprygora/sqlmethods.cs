﻿using StudioManager;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace APR_jahresprojekt_podoprygora
{
    internal static class Sqlmethods
    {
        public static string constring = "Server = (localdb)\\MSSQLLocalDB; Integrated Security = true;";
        public static string session_username = "";
        public static void create_database_jahresprojektDB(string sqlconnection)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'jahresprojektDB')" +
                    "CREATE DATABASE jahresprojektDB;", con);
                cmd.ExecuteNonQuery();
                constring = constring + "Initial Catalog = jahresprojektDB;";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void create_table_login(string sqlconnection)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS(SELECT * FROM sysobjects WHERE name = 'login') CREATE TABLE login(" +
                    "[Id] INT IDENTITY (1, 1) NOT NULL," +
                "[username] VARCHAR (16) NULL," +
                    "[password] VARCHAR (120) NULL," +
                    "PRIMARY KEY CLUSTERED ([Id] ASC));", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }
        public static void create_table_highscore(string sqlconnection)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='highscore') CREATE TABLE highscore("+
                    "[Id] INT IDENTITY (1, 1) NOT NULL," +
                    "[score] INT NULL ," +
                    "[username] VARCHAR (16) NULL," +
                    "PRIMARY KEY ([Id] ASC));", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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
            string hashedPassword = "";
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.login WHERE username LIKE '" + username + "'", con);
                cmd.Parameters.AddWithValue("username", username);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    cmd.CommandText = "SELECT password FROM dbo.login WHERE username LIKE '" + username + "';";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        hashedPassword = reader.GetString(0);
                    }
                    bool result = BCrypt.CheckPassword(password, hashedPassword);
                    con.Close();
                    return result;
                }
                else
                {
                    con.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void password_change(string username, string password, string sqlconnection)
        {
            string hashedPassword = BCrypt.HashPassword(password, BCrypt.GenerateSalt());
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE login SET password ='" + hashedPassword + "' WHERE username = '" + username + "';", con);
                cmd.ExecuteNonQuery();
                con.Close();
                DialogResult dr = MessageBox.Show("Password was successfully changed!", "Password change", MessageBoxButtons.OK);
                //if (dr == DialogResult.OK)
                //{
                //    form_login form_Login = new form_login();
                //    form_Login.ShowDialog();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool signup(string username, string password, string sqlconnection)
        {
            string hashedPassword = BCrypt.HashPassword(password, BCrypt.GenerateSalt());
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO login (username, password) VALUES('" + username + "', '" + hashedPassword + "');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                DialogResult dr = MessageBox.Show("User successfully created!", "Sign Up", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void setHighscore(string username, int score, string sqlconnection)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE dbo.highscore set score = '"+score+"' WHERE username = '"+username+"' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string getHighscore(string username, string sqlconnection)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT score FROM dbo.highscore where username = '" + username + "';", con);
                SqlDataReader reader = cmd.ExecuteReader();
                string highscore = "";
                while (reader.Read())
                {
                    highscore = reader[0].ToString();
                }
                con.Close();
                return highscore;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        public static void User_highscoreSetup(string username, string sqlconnection)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.highscore WHERE username LIKE '" + username + "'", con);
                cmd.Parameters.AddWithValue("username", username);
                int count = (int)cmd.ExecuteScalar();
                con.Close();
                if (count == 0)
                {
                    con.Open();
                    cmd.CommandText = "INSERT INTO highscore (username, score) values ('"+username+"', 0)";
                    cmd.ExecuteNonQuery();
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public static void getHighscoreUsernameList(Label label, string sqlconnection)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 10 username, score FROM dbo.highscore ORDER BY score DESC;", con);
                SqlDataReader reader = cmd.ExecuteReader();
                label.Text = "Username\n";
                int i = 1;
                while (reader.Read())
                {
                    label.Text =""+label.Text+" "+i+" "+reader[0].ToString()+"\n";
                    i++;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void getHighscoreList(Label label, string sqlconnection)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 10 score FROM dbo.highscore ORDER BY score DESC;", con);
                SqlDataReader reader = cmd.ExecuteReader();
                label.Text = "Score\n";
                while (reader.Read())
                {
                    label.Text = label.Text + reader[0].ToString() + "\n";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   
    }
}
