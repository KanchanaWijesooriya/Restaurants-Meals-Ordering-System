using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_course_work
{
    internal class DailyUpdateDB
    {
        private int id;
        private string name;
        private double totprice;
        private int stock;
        private int count;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Totprice { get => totprice; set => totprice = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Count { get => count; set => count = value; }

        public void insertData()
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "insert into dailysales(id, name, totprice, stock)" + "values(" + id + ",'" + name + "','" + totprice + "'," + stock + ")";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            //MessageBox.Show("Data entered successfully in dudb");
        }

        /*
        public void cheackData(int food_id)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "select * from dailysales where id=" + food_id + "";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            //cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tempstock = reader.GetInt32("stock");
            }
            reader.Close();
            g.Close();
        }
        */

        public void cheackCount(int food_id)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "select count(id) from dailysales where id=" + food_id + "";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            //cmd.ExecuteNonQuery();
            var c = cmd.ExecuteScalar();
            count = Convert.ToInt32(c);
            //int count = (int)cmd.ExecuteScalar();
            //(Int32)cmd.ExecuteScalar();
            //Int32 count = (Int32)cmd.ExecuteScalar();
            g.Close();
            //MessageBox.Show("Data couted successfully in dudb");
        }

        public void editData(int food_id)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "update dailysales set totprice=" + totprice + "," + "stock='" + stock + "' where id=" + food_id + "";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            //MessageBox.Show("Data edited successfully in dudb");
        }

        public void selectAllData(int food_id)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "select * from dailysales where id=" + food_id + "";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            //cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32("id");
                name = reader.GetString("name");
                totprice = reader.GetDouble("totprice");
                stock = reader.GetInt32("stock");
            }
            reader.Close();
            g.Close();
            //MessageBox.Show("Data selected successfully in dudb");
        }
    }
}
