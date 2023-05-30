using Entity;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace DataAccessLayer
{
    public class FilmRepository
    {
        public static List<Film> Get()
        {
            List<Film> Films = new List<Film>();
            SqlCommand cmd = new SqlCommand("select * from Films", ConnectionString.connection);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Film film = new Film();

                film.Id = int.Parse(reader["Id"].ToString());
                film.Ad = reader["Ad"].ToString();
                film.Yonetmen = reader["Yonetmen"].ToString();
                film.Yil = int.Parse(reader["Yıl"].ToString());

                Films.Add(film);
            }
            reader.Close();
            return Films;
        }

        public static int Add(Film film)
        {
            SqlCommand cmd = new SqlCommand("insert into Films (Ad,Yonetmen,Yıl) VALUES (@ad,@yonetmen,@yıl)", ConnectionString.connection);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();

            cmd.Parameters.AddWithValue("@ad", film.Ad);
            cmd.Parameters.AddWithValue("@yonetmen", film.Yonetmen);
            cmd.Parameters.AddWithValue("@yıl", film.Yil);
            return cmd.ExecuteNonQuery();
        }

        public static bool Remove(Film film)
        {
            SqlCommand cmd = new SqlCommand("delete from Film where Id = @ıd", ConnectionString.connection);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();

            cmd.Parameters.AddWithValue("@ıd", film.Id);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static bool Update(Film film)
        {
            SqlCommand cmd = new SqlCommand("update Films set Ad=@ad,Yonetmen=@yonetmen,Yıl=@yıl where Id=@Id", ConnectionString.connection);
            if (cmd.Connection.State != ConnectionState.Open)
                cmd.Connection.Open();

            cmd.Parameters.AddWithValue("@ad", film.Ad);
            cmd.Parameters.AddWithValue("@yonetmen", film.Yonetmen);
            cmd.Parameters.AddWithValue("@yıl", film.Yil);

            return cmd.ExecuteNonQuery() > 0;
        }

        public static List<Izlediklerim> getİzledikler(int userId)// ara tablodaki verileri çekiyoruz izlediğimiz filmler için
        {
            List<Izlediklerim> izlediklerim = new List<Izlediklerim>();
            SqlCommand cmd = new SqlCommand("select * from Izlediklerim where UserId = @ıd", ConnectionString.connection);
            cmd.Parameters.AddWithValue("ıd", userId);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Izlediklerim izle = new Izlediklerim();
                izle.Id = int.Parse(reader["ID"].ToString());
                izle.FilmId = int.Parse(reader["FilmId"].ToString());
                izle.UserId = int.Parse(reader["UserId"].ToString());
                izlediklerim.Add(izle);
            }
            reader.Close();
            return izlediklerim;
        }
        public static List<Izleyeceklerim> ızleyeceklerims(int userId) // ara tablodaki verileri çekiyoruz izleyeceğimiz filmler için
        {
            List<Izleyeceklerim> izleyeceklerim = new List<Izleyeceklerim>();
            SqlCommand cmd = new SqlCommand("select * from Izleyeceklerim where UserId = @ıd", ConnectionString.connection);
            cmd.Parameters.AddWithValue("ıd", userId);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Izleyeceklerim izle = new Izleyeceklerim();
                izle.Id = int.Parse(reader["ID"].ToString());
                izle.FilmId = int.Parse(reader["FilmId"].ToString());
                izle.UserId = int.Parse(reader["UserId"].ToString());
                izleyeceklerim.Add(izle);
            }
            reader.Close();
            return izleyeceklerim;

        }
        public static List<Film> Getizlediklerim(int userId) // izlediğimiz filmeleri seçiyoruz
        {
            List<Film> films = new List<Film>();

            foreach (var item in getİzledikler(userId))
            {
                SqlCommand cmd = new SqlCommand("select * from Films where Id = @ıd", ConnectionString.connection);
                cmd.Parameters.AddWithValue("ıd", item.FilmId);
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Film film = new Film();
                    film.Id = int.Parse(reader["Id"].ToString());
                    film.Ad = reader["Ad"].ToString();
                    film.Yonetmen = reader["Yonetmen"].ToString();
                    film.Yil = int.Parse(reader["Yıl"].ToString());

                    films.Add(film);
                }
                reader.Close();
            }

            return films;
        }
        public static List<Film> getIzleyecekler(int userId) //izleyeceğimiz filmleri seçiyoruz
        {
            List<Film> films = new List<Film>();

            foreach (var item in ızleyeceklerims(userId))
            {
                SqlCommand cmd = new SqlCommand("select * from Films where Id = @ıd", ConnectionString.connection);
                cmd.Parameters.AddWithValue("ıd", item.FilmId);
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Film film = new Film();
                    film.Id = int.Parse(reader["Id"].ToString());
                    film.Ad = reader["Ad"].ToString();
                    film.Yonetmen = reader["Yonetmen"].ToString();
                    film.Yil = int.Parse(reader["Yıl"].ToString());

                    films.Add(film);
                }
                reader.Close();
            }

            return films;
        }

        public static int Addİzlediklerim(int userId,int filmId)// izlediğim filmleri ekliyorum
        {
            
            SqlCommand cmd1 = new SqlCommand("Select * from Izlediklerim where UserId=@user and FilmId = @film", ConnectionString.connection);
            cmd1.Parameters.AddWithValue("user", userId);
            cmd1.Parameters.AddWithValue("film", filmId);
            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return -1;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Izlediklerim (UserId,FilmId) VALUES (@user,@film)", ConnectionString.connection);
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@user", userId);
                cmd.Parameters.AddWithValue("@film", filmId);
                reader.Close();
                return cmd.ExecuteNonQuery();
            }
            
        }
        public static int Addİzleyeceklerim(int userId, int filmId)// izleyeceklerimi tabloya ekliyorum
        {

            SqlCommand cmd1 = new SqlCommand("Select * from Izleyeceklerim where UserId=@user and FilmId = @film", ConnectionString.connection);
            cmd1.Parameters.AddWithValue("user", userId);
            cmd1.Parameters.AddWithValue("film", filmId);
            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            SqlDataReader reader = cmd1.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return -1;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into Izleyeceklerim (UserId,FilmId) VALUES (@user,@film)", ConnectionString.connection);
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();

                cmd.Parameters.AddWithValue("@user", userId);
                cmd.Parameters.AddWithValue("@film", filmId);
                reader.Close();
                return cmd.ExecuteNonQuery();
            }

        }

    }
}
