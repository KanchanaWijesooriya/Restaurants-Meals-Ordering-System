using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI_course_work
{
    internal class security
    {
        private String username;
        private String password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public void searchData(int id)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "select * from security where id=" + id + "";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            //cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Username = reader.GetString("user");
                Password = reader.GetString("password");
            }
            reader.Close();
            g.Close();
        }
    }
}
