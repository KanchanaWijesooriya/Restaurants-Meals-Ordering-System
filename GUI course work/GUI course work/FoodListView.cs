using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace GUI_course_work
{
    internal class FoodListView
    {

        private String item;
        private int qty;
        private double price;

        public string Item { get => item; set => item = value; }
        public int Qty { get => qty; set => qty = value; }
        public double Price { get => price; set => price = value; }


        public void insertData()
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "insert into listviewdb(Item, Qty, Price)" + "values('" + item + "'," + qty + "," + price + ")";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            //MessageBox.Show("Data entered successfully");
        }

        public void updateData()
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "update listviewdb set Qty=" + qty + "," + "Price=" + price + " where Item='" + item + "'";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            //MessageBox.Show("Data edited successfully");
        }

        public void deleteData()
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "truncate table listviewdb";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            //MessageBox.Show("Data deleted successfully");
        }

        public void deleteOneData(String item)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "delete from listviewdb WHERE Item='"+item+"'";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            //MessageBox.Show("Data deleted successfully");
        }
        /*
                public void searchData(int find_Search)
                {
                    String g_string = "server = localhost; user = root; password = ; database = cafedb";
                    MySqlConnection g = new MySqlConnection(g_string);

                    String query_name = "select * from listviewdb where Emp_Id=" + find_Search + "";

                    MySqlCommand cmd = new MySqlCommand(query_name, g);

                    g.Open();
                    //cmd.ExecuteNonQuery();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        employee_id = reader.GetInt32("Emp_Id");
                        employee_name = reader.GetString("Emp_Name");
                        email = reader.GetString("Email");
                        telphone = reader.GetInt32("TP");
                    }
                    reader.Close();
                    g.Close();
                }*/
    }
}
