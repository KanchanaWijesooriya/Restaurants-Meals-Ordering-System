using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Data;

namespace GUI_course_work
{
    internal class OneForAll
    {
        private int id;
        private string name;
        private double price;
        private int stock;
        private int tempstock;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Tempstock { get => tempstock; set => tempstock = value; }

        public void insertData()
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "insert into stock(id, name, price, stock)" + "values(" + id + ",'" + name + "','" + price + "'," + stock + ")";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            //MessageBox.Show("Data entered successfully");
        }

        /*  public void editData()
          {
              String g_string = "server = localhost; user = root; password = ; database = Tesla";
              MySqlConnection g = new MySqlConnection(g_string);

              String query_name = "update Employee set Emp_Name='" + employee_name + "'," + "Email='" + email + "'," + "TP=" + telphone + " where Emp_Id=" + employee_id + "";

              MySqlCommand cmd = new MySqlCommand(query_name, g);

              g.Open();
              cmd.ExecuteNonQuery();
              g.Close();
              MessageBox.Show("Data edited successfully");
          }*/

        public void editData()
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "update stock set stock=" + stock + " where id=" + id + "";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            //MessageBox.Show("Data edited successfully in ofa");
        }


        /*public void cheackData(int food_id)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "select stock from stock where id=" + food_id + "";

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
        }*/

        public void cheackData(int food_id)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "select * from stock where id=" + food_id + "";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            //cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32("id");
                name = reader.GetString("name");
                price = reader.GetDouble("price");
                stock = reader.GetInt32("stock");
                tempstock = reader.GetInt32("stock");
            }
            reader.Close();
            g.Close();
            //MessageBox.Show("Data in One for all cheack successfully");
        }


        /*public void displayGrid()
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            g.Open();

            String query_name = "select * from stock ";
            MySqlDataAdapter mda = new MySqlDataAdapter(query_name, g);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(mda);
            var ds = new DataSet();
            //ds.Tables.Add();
            mda.Fill(ds);
            dataGridViewOne.DataSource = ds.Tables[0];
            g.Close() ;
        }*/
    }
}
