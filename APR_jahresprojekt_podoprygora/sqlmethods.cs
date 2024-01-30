﻿using System.Data.SqlClient;

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
                    "[password] VARCHAR (16) NULL," +
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
                SqlCommand cmd = new SqlCommand("UPDATE login SET password ='" + password + "' WHERE username = '" + username + "';", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void signup(string username, string password, string sqlconnection)
        {
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO login (username, password) VALUES('" + username + "', '" + password + "');", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void highscore(string username, Label label, string sqlconnection)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(sqlconnection);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT score FROM highscore where username = '"+username+"';", con);
                SqlDataReader reader = cmd.ExecuteReader();
                string? highscore = "";
                while (reader.Read())
                {
                    highscore = reader[0].ToString();
                }
                label.Text = label.Text + highscore;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
