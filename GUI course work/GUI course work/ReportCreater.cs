using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_course_work
{
    internal class ReportCreater
    {
        private int Stockstock;
        private int StockDaily;
        private String name;
        private double percentageSold;

        public int Stockstock1 { get => Stockstock; set => Stockstock = value; }
        public int StockDaily1 { get => StockDaily; set => StockDaily = value; }
        public string Name { get => name; set => name = value; }
        public double PercentageSold { get => percentageSold; set => percentageSold = value; }

        public void calPercentage(int val)
        {
            getamtDaily(val);
            getamtStock(val);
            percentageSold = (StockDaily * 100) / (StockDaily + Stockstock);

        }

        public void getamtStock(int food_id)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "select stock, name from stock where id=" + food_id + "";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            //cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Stockstock = reader.GetInt32("stock");
                name = reader.GetString("name");
            }
            reader.Close();
            g.Close();
        }

        public void getamtDaily(int food_id)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "select stock from dailysales where id=" + food_id + "";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            //cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StockDaily = reader.GetInt32("stock");
            }
            reader.Close();
            g.Close();
        }
    }
}
