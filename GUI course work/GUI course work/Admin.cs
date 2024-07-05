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

namespace GUI_course_work
{
    public partial class Admin : Form
    {
        OneForAll ofa;
        ReportCreater rc;
        public Admin()
        {
            InitializeComponent();
            ofa = new OneForAll();
            rc = new ReportCreater();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm af = new AdminForm();
            af.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateForm uf = new UpdateForm();
            uf.Show(); 
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteData(Convert.ToInt32(txtdelete.Text));
            txtdelete.Clear();
        }

        public void deleteData(int id)
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "delete from stock where id=" + id + "";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            MessageBox.Show("Data deleted successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayGrid1();
            displayGrid2();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (printPreviewDialog1.ShowDialog() == DialogResult.OK)   //Owner
            {
                printDocument1.Print();
            }*/
        }

        public void displayGrid1()
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
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.RowHeadersVisible = false;
            g.Close();
        }

        public void displayGrid2()
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            g.Open();

            String query_name = "select * from dailysales ";
            MySqlDataAdapter mda = new MySqlDataAdapter(query_name, g);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(mda);
            var ds = new DataSet();
            //ds.Tables.Add();
            mda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.RowHeadersVisible = false;
            g.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            displayGrid1();
            displayGrid2();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            deleteData2();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*e.Graphics.DrawString("====== Stocks ======", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(200, 100));
            for (int i = 1; i <= 1; i++)
            {
                rc.calPercentage(i);
                e.Graphics.DrawString("Prcentage sold by " + rc.Name + " is: " + rc.PercentageSold + "%" + rc.StockDaily1 + " " + rc.Stockstock1, new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 150));
            }*/

            //e.Graphics.DrawString("This some random text ", new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 150));

            //e.Graphics.DrawString("Food id " + dataGridViewOne.SelectedRows[0].Cells[0].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 105));
            //e.Graphics.DrawString("Food name " + dataGridViewOne.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 125));
            //e.Graphics.DrawString("Food price " + dataGridViewOne.SelectedRows[0].Cells[2].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 145));
            //e.Graphics.DrawString("Food stock " + dataGridViewOne.SelectedRows[0].Cells[3].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 165));
            //if (dataGridViewOne.SelectedRows.Count > 0)
            //{
            //e.Graphics.DrawString("====== Stocks ======", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(200, 100));
            //e.Graphics.DrawString("Food name " + dataGridViewOne.SelectedRows[0].Cells[1].Value.ToString(), new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, 125));
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)   //Owner
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("====== Stocks ======", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(200, 100));
            int space = 150;
            for (int i = 1; i <= 12; i++)
            {
                //int space = 150;
                rc.calPercentage(i);
                e.Graphics.DrawString("Percentage sold by " + rc.Name + " is: " + rc.PercentageSold + "%", new Font("Abeezee", 14, FontStyle.Regular), Brushes.Black, new Point(120, space));
                space = space + 30;
            }
        }

        private void printPreviewDialog1_Load_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            deleteData();
        }

        public void deleteData()
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "truncate table stock";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            //MessageBox.Show("Stock database all data deleted successfully");
        }

        public void deleteData2()
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            String query_name = "truncate table dailysales";

            MySqlCommand cmd = new MySqlCommand(query_name, g);

            g.Open();
            cmd.ExecuteNonQuery();
            g.Close();
            //MessageBox.Show("Dailysales database all data deleted successfully");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
