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
    public partial class Bverages : Form
    {
        OneForAll ofa;
        MidFoodandBuyConfermation mfabc;
        FoodListView flv;
        public Bverages()
        {
            InitializeComponent();
            ofa = new OneForAll();
            mfabc = new MidFoodandBuyConfermation();
            flv = new FoodListView();
        }

        Boolean ice_coke = false;
        Boolean ice_coffee = false;
        Boolean lemonade = false;
        Boolean chocholate_shake = false;
        Boolean boba_tea = false;
        Boolean falooda = false;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FoodItems fi = new FoodItems();
            fi.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FoodItems fi = new FoodItems();
            fi.Show();
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            BuyConfermation bc = new BuyConfermation(); 
            bc.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void displayGrid1()
        {
            String g_string = "server = localhost; user = root; password = ; database = cafedb";
            MySqlConnection g = new MySqlConnection(g_string);

            g.Open();

            String query_name = "select * from listviewdb ";
            MySqlDataAdapter mda = new MySqlDataAdapter(query_name, g);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(mda);
            var ds = new DataSet();
            //ds.Tables.Add();
            mda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            g.Close();
        }

        private void Bverages_Load(object sender, EventArgs e)
        {
            displayGrid1();
            lbltot.Text = mfabc.Total.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            allForOne(7);
            lbltot.Text = mfabc.Total.ToString();
        }

        public void allForOne(int id)
        {

            ofa.cheackData(id);
            if (id == 7)
            {
                mfabc.Ice_coke++;

                if (mfabc.Ice_coke <= ofa.Tempstock)
                {
                    lblIcoke.Text = mfabc.Ice_coke.ToString();

                    double subtot = mfabc.Ice_coke * ofa.Price;

                    mfabc.Total = mfabc.Total + ofa.Price;

                    if (ice_coke == false)
                    {
                        //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Ice_coke;
                        flv.Price = subtot;
                        flv.insertData();
                        displayGrid1();
                        ice_coke = true;
                    }
                    else
                    {
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Ice_coke;
                        flv.Price = subtot;
                        flv.updateData();
                        displayGrid1();
                        //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                    }
                }
                else
                {
                    mfabc.Ice_coke--;
                    MessageBox.Show("Out of stock only " + mfabc.Ice_coke + " items available.. not " + (mfabc.Ice_coke + 1));
                }
            }
            if (id == 8)
            {
                mfabc.Ice_coffee++;

                if (mfabc.Ice_coffee <= ofa.Tempstock)
                {
                    lblIcoffee.Text = mfabc.Ice_coffee.ToString();

                    double subtot = mfabc.Ice_coffee * ofa.Price;

                    mfabc.Total = mfabc.Total + ofa.Price;

                    if (ice_coffee == false)
                    {
                        //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Ice_coffee;
                        flv.Price = subtot;
                        flv.insertData();
                        displayGrid1();
                        ice_coffee = true;
                    }
                    else
                    {
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Ice_coffee;
                        flv.Price = subtot;
                        flv.updateData();
                        displayGrid1();
                        //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                    }
                }
                else
                {
                    mfabc.Ice_coffee--;
                    MessageBox.Show("Out of stock only " + mfabc.Ice_coffee + " items available.. not " + (mfabc.Ice_coffee + 1));
                }
            }
            if (id == 9)
            {
                mfabc.Lemonade++;

                if (mfabc.Lemonade <= ofa.Tempstock)
                {
                    lbllemon.Text = mfabc.Lemonade.ToString();

                    double subtot = mfabc.Lemonade * ofa.Price;

                    mfabc.Total = mfabc.Total + ofa.Price;

                    if (lemonade == false)
                    {
                        //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Lemonade;
                        flv.Price = subtot;
                        flv.insertData();
                        displayGrid1();
                        lemonade = true;
                    }
                    else
                    {
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Lemonade;
                        flv.Price = subtot;
                        flv.updateData();
                        displayGrid1();
                        //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                    }
                }
                else
                {
                    mfabc.Lemonade--;
                    MessageBox.Show("Out of stock only " + mfabc.Lemonade + " items available.. not " + (mfabc.Lemonade + 1));
                }
            }
            if (id == 10)
            {
                mfabc.Chocholate_shake++;

                if (mfabc.Chocholate_shake <= ofa.Tempstock)
                {
                    lblCshake.Text = mfabc.Chocholate_shake.ToString();

                    double subtot = mfabc.Chocholate_shake * ofa.Price;

                    mfabc.Total = mfabc.Total + ofa.Price;
                    if (chocholate_shake == false)
                    {
                        //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Chocholate_shake;
                        flv.Price = subtot;
                        flv.insertData();
                        displayGrid1();
                        chocholate_shake = true;
                    }
                    else
                    {
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Chocholate_shake;
                        flv.Price = subtot;
                        flv.updateData();
                        displayGrid1();
                        //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                    }
                }
                else
                {
                    mfabc.Chocholate_shake--;
                    MessageBox.Show("Out of stock only " + mfabc.Chocholate_shake + " items available.. not " + (mfabc.Chocholate_shake + 1));
                }
            }
            if (id == 11)
            {
                mfabc.Boba_tea++;

                if (mfabc.Boba_tea <= ofa.Tempstock)
                {
                    lblBtea.Text = mfabc.Boba_tea.ToString();

                    double subtot = mfabc.Boba_tea * ofa.Price;

                    mfabc.Total = mfabc.Total + ofa.Price;

                    if (boba_tea == false)
                    {
                        //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Boba_tea;
                        flv.Price = subtot;
                        flv.insertData();
                        displayGrid1();
                        boba_tea = true;
                    }
                    else
                    {
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Boba_tea;
                        flv.Price = subtot;
                        flv.updateData();
                        displayGrid1();
                        //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                    }
                }
                else
                {
                    mfabc.Boba_tea--;
                    MessageBox.Show("Out of stock only " + mfabc.Boba_tea + " items available.. not " + (mfabc.Boba_tea + 1));
                }
            }
            if (id == 12)
            {
                mfabc.Falooda++;

                if (mfabc.Falooda <= ofa.Tempstock)
                {
                    lblfalooda.Text = mfabc.Falooda.ToString();

                    double subtot = mfabc.Falooda * ofa.Price;

                    mfabc.Total = mfabc.Total + ofa.Price;

                    if (falooda == false)
                    {
                        //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Falooda;
                        flv.Price = subtot;
                        flv.insertData();
                        displayGrid1();
                        falooda = true;
                    }
                    else
                    {
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Falooda;
                        flv.Price = subtot;
                        flv.updateData();
                        displayGrid1();
                        //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                    }
                }
                else
                {
                    mfabc.Falooda--;
                    MessageBox.Show("Out of stock only " + mfabc.Falooda + " items available.. not " + (mfabc.Falooda + 1));
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            allForOne(8);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            allForOne(9);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            allForOne(10);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            allForOne(11);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            allForOne(12);
            lbltot.Text = mfabc.Total.ToString();
        }

        public void allSubMinus(int id)
        {
            ofa.cheackData(id);
            if (id == 7)
            {
                if (mfabc.Ice_coke > 0)
                {
                    mfabc.Ice_coke--;
                    lblIcoke.Text = mfabc.Ice_coke.ToString();

                    double subtot = ofa.Price;

                    mfabc.Total = mfabc.Total - subtot;

                }
                if (mfabc.Ice_coke == 0)
                {
                    flv.deleteOneData(ofa.Name);
                    ice_coke = false;
                    displayGrid1();
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Ice_coke;
                    flv.Price = mfabc.Ice_coke * ofa.Price;
                    flv.updateData();
                    displayGrid1();
                }
                lbltot.Text = mfabc.Total.ToString();
            }
            if (id == 8)
            {
                if (mfabc.Ice_coffee > 0)
                {
                    mfabc.Ice_coffee--;
                    lblIcoffee.Text = mfabc.Ice_coffee.ToString();

                    double subtot = ofa.Price;

                    mfabc.Total = mfabc.Total - subtot;

                }
                if (mfabc.Ice_coffee == 0)
                {
                    flv.deleteOneData(ofa.Name);
                    ice_coffee = false;
                    displayGrid1();
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Ice_coffee;
                    flv.Price = mfabc.Ice_coffee * ofa.Price;
                    flv.updateData();
                    displayGrid1();
                }
                lbltot.Text = mfabc.Total.ToString();
            }
            if (id == 9)
            {
                if (mfabc.Lemonade > 0)
                {
                    mfabc.Lemonade--;
                    lbllemon.Text = mfabc.Lemonade.ToString();

                    double subtot = ofa.Price;

                    mfabc.Total = mfabc.Total - subtot;

                }
                if (mfabc.Lemonade == 0)
                {
                    flv.deleteOneData(ofa.Name);
                    lemonade = false;
                    displayGrid1();
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Lemonade;
                    flv.Price = mfabc.Lemonade * ofa.Price;
                    flv.updateData();
                    displayGrid1();
                }
                lbltot.Text = mfabc.Total.ToString();
            }
            if (id == 10)
            {
                if (mfabc.Chocholate_shake > 0)
                {
                    mfabc.Chocholate_shake--;
                    lblCshake.Text = mfabc.Chocholate_shake.ToString();

                    double subtot = ofa.Price;

                    mfabc.Total = mfabc.Total - subtot;

                }
                if (mfabc.Chocholate_shake == 0)
                {
                    flv.deleteOneData(ofa.Name);
                    chocholate_shake = false;
                    displayGrid1();
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Chocholate_shake;
                    flv.Price = mfabc.Chocholate_shake * ofa.Price;
                    flv.updateData();
                    displayGrid1();
                }
                lbltot.Text = mfabc.Total.ToString();


            }
            if (id == 11)
            {
                if (mfabc.Boba_tea > 0)
                {
                    mfabc.Boba_tea--;
                    lblBtea.Text = mfabc.Boba_tea.ToString();

                    double subtot = ofa.Price;

                    mfabc.Total = mfabc.Total - subtot;

                }
                if (mfabc.Boba_tea == 0)
                {
                    flv.deleteOneData(ofa.Name);
                    boba_tea = false;
                    displayGrid1();
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Boba_tea;
                    flv.Price = mfabc.Boba_tea * ofa.Price;
                    flv.updateData();
                    displayGrid1();
                }
                lbltot.Text = mfabc.Total.ToString();
            }
            if (id == 12)
            {
                if (mfabc.Falooda > 0)
                {
                    mfabc.Falooda--;
                    lblfalooda.Text = mfabc.Falooda.ToString();

                    double subtot = ofa.Price;

                    mfabc.Total = mfabc.Total - subtot;

                }
                if (mfabc.Falooda == 0)
                {
                    flv.deleteOneData(ofa.Name);
                    falooda = false;
                    displayGrid1();
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Falooda;
                    flv.Price = mfabc.Falooda * ofa.Price;
                    flv.updateData();
                    displayGrid1();
                }
                lbltot.Text = mfabc.Total.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            allSubMinus(7);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            allSubMinus(8);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            allSubMinus(9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            allSubMinus(10);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            allSubMinus(11);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            allSubMinus(12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            allForOne(7);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            allForOne(8);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            allForOne(9);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            allForOne(10);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            allForOne(11);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            allForOne(12);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void lblIcoffee_Click(object sender, EventArgs e)
        {

        }
    }
}
