using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace MvcMovie.Models
{
    public class MovieStoreContext
    {
        public string ConnectionString { get; set; }    
    
        public MovieStoreContext(string connectionString)    
        {    
            this.ConnectionString = connectionString;    
        }    
    
        private MySqlConnection GetConnection()    
        {    
            return new MySqlConnection(ConnectionString);    
        }     
        
        public List<Movie> GetMovies()
        {
            List<Movie> list = new List<Movie>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from phim", conn);  
    
                using (var reader = cmd.ExecuteReader()){  
                    while (reader.Read())  {  
                    list.Add(new Movie() {  
                        MaPhim = reader["MaPhim"].ToString(),  
                        TenPhim = reader["TenPhim"].ToString(),  
                    });  
                    }  
                }  
            }
            return list;
        }
    }
}