using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI_course_work
{
    public partial class AdminForm : Form
    {
        OneForAll ofa;
        public AdminForm()
        {
            InitializeComponent();
            ofa= new OneForAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ofa.Id = Convert.ToInt32(txtid.Text);
            ofa.Name = txtname.Text;
            ofa.Price = Convert.ToDouble(txtprice.Text);
            ofa.Stock = Convert.ToInt32(txtstock.Text);
            ofa.insertData();
            txtid.Clear(); txtname.Clear(); txtprice.Clear(); txtstock.Clear();
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
            g.Close();
        }*/

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //displayGrid();
        }

        private void dataGridViewOne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(printPreviewDialog1.ShowDialog() == DialogResult.OK)   //Owner
            //{
                //printDocument1.Print();
            //}
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawString("====== Stocks ======", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(200, 100));
            //e.Graphics.DrawString("Food id " + dataGridViewOne.SelectedRows[0].Cells[0].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 105));
            //e.Graphics.DrawString("Food name " + dataGridViewOne.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 125));
            //e.Graphics.DrawString("Food price " + dataGridViewOne.SelectedRows[0].Cells[2].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 145));
            //e.Graphics.DrawString("Food stock " + dataGridViewOne.SelectedRows[0].Cells[3].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 165));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            adm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            insertData(Convert.ToInt32(txtid.Text), txtname.Text, Convert.ToDouble(txtprice.Text), Convert.ToInt32(txtstock.Text));
            txtid.Clear();
            txtname.Clear(); txtprice.Clear();  
            txtstock.Clear();
        }

        public void insertData(int id, String name, double price, int stock)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "insert into stock(id, name, price, stock)" + "values(" + id + ",'" + name + "'," + price + "," + stock + ")";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            //MessageBox.Show("Data entered successfully");
        }
    }
}
