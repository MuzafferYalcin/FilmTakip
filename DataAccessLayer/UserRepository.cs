using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static  class UserRepository
    {
        public static List<User> getUsers() // 
        {
            List<User> users = new List<User>();
            SqlCommand cmd = new SqlCommand("Select * from Users",ConnectionString.connection);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User user = new User();
                user.Id = int.Parse(reader["Id"].ToString());
                user.Ad = reader["Ad"].ToString();
                user.Email = reader["Email"].ToString();
                user.Username = reader["Username"].ToString();
                user.Password = "******";
                user.IsAdmin =bool.Parse(reader["isAdmin"].ToString()); 
                users.Add(user);

            }
            reader.Close();
            return users;
        }

        public static bool Remove(User user) // user silen fonk
        {
            SqlCommand cmd = new SqlCommand("delete from Users where Id = @ıd", ConnectionString.connection);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();

            cmd.Parameters.AddWithValue("@ıd", user.Id);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static int Add(User user) // user ekleyen fonksiyon
        {
            SqlCommand cmd = new SqlCommand("insert into Users (Ad,Username,Email,Password,isAdmin) VALUES (@ad,@username,@email,@password,0)", ConnectionString.connection);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();

            cmd.Parameters.AddWithValue("@ad", user.Ad);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@email",user.Email);
            return cmd.ExecuteNonQuery();

        }

        public static User GetUser(string username,string password)// belirli bir kullanıcıyı buluyorum
        {
            SqlCommand cmd = new SqlCommand("Select * from Users where Username=@username and Password=@password",ConnectionString.connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            User user = new User();
            if (reader.Read())
            {
                user.Id = int.Parse(reader["Id"].ToString());
                user.Ad = reader["Ad"].ToString();
                user.Email = reader["Email"].ToString();
                user.Username = reader["Username"].ToString();
                user.IsAdmin = bool.Parse(reader["isAdmin"].ToString());
                user.Password = "******";
            }
            reader.Close();

            return user;
        }
        public static bool Removeİzlediklerim ( int userId, int filmId) // izlediğim filmi listeden çıkarıyorum
        {
            SqlCommand cmd = new SqlCommand("delete from Izlediklerim where UserId = @userıd and FilmId = @filmıd", ConnectionString.connection);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();

            cmd.Parameters.AddWithValue("@userıd", userId);
            cmd.Parameters.AddWithValue("@filmıd", filmId);
            return cmd.ExecuteNonQuery() > 0;
        }
        public static bool Removeİzleyeceklerim(int userId, int filmId)// izleyeceğim filmi listeden çıkarıyom
        {
            SqlCommand cmd = new SqlCommand("delete from Izleyeceklerim where UserId = @userıd and FilmId = @filmıd", ConnectionString.connection);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();

            cmd.Parameters.AddWithValue("@userıd", userId);
            cmd.Parameters.AddWithValue("@filmıd", filmId);
            return cmd.ExecuteNonQuery() > 0;
        }

    }
}
