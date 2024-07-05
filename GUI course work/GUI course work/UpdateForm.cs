using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI_course_work
{
    public partial class UpdateForm : Form
    {
        OneForAll ofa;
        public UpdateForm()
        {
            InitializeComponent();
            ofa = new OneForAll();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            editData(Convert.ToInt32(txtid.Text), txtname.Text, Convert.ToDouble(txtprice.Text), Convert.ToInt32(txtstock.Text));
            txtid.Clear(); txtname.Clear(); txtprice.Clear(); txtstock.Clear();

        }

        public void editData(int id, String name, double price, int stock)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "update stock set name='" + name + "'," + "price=" + price + "," + "stock=" + stock + " where id=" + id + "";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            //MessageBox.Show("Data edited successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ofa.cheackData(Convert.ToInt32(txtid.Text));
            txtid.Text = Convert.ToString(ofa.Id);
            txtname.Text = ofa.Name;
            txtprice.Text = Convert.ToString(ofa.Price);
            txtstock.Text = Convert.ToString(ofa.Stock);
        }

        /*public void cheackData(int food_id)
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
                txtid = reader.GetInt32("id");
                txtname = reader.GetString("name");
                txtprice = reader.GetDouble("price");
                txtstock = reader.GetInt32("stock");
            }
            reader.Close();
            g.Close();
            MessageBox.Show("Data in One for all cheack successfully");
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }
    }
}
