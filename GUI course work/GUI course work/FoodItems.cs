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
    public partial class FoodItems : Form
    {
        OneForAll ofa;
        MidFoodandBuyConfermation mfabc;
        FoodListView flv;
        public FoodItems()
        {
            InitializeComponent();
            ofa = new OneForAll();
            mfabc = new MidFoodandBuyConfermation();
            flv = new FoodListView();
        }

        //Adding data to the List View-----------------------------------------------------------------
        /*private void addToListView(String n, String q, String p)
        {
            String[] row = { n, q, p };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        //Editing data in the list view---------------------------------------------------------------------
        private void updateItemsListView(String q, String p)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[1].Text = q;
                listView1.SelectedItems[0].SubItems[2].Text = p;
            }
            //listView1.SelectedItems[0].SubItems[1].Text = q;
            //listView1.SelectedItems[0].SubItems[2].Text = p;
        }*/

        //Getting the total of all items
        //double fultot = 0;
        //private void totalUpdate(double tot)
        //{
            //double fultot = 0;
            //fultot = fultot + tot;
            //lbltot.Text = fultot.ToString();
       // }
        //This is the first food item ----------------------------------------------------------------------------------------------------------------------------------------------------
        //int pizza = 0;
        //int Spizza = 0;

        //Getting the boolean value of all products incase a product is already added to the List view--------------------------------------------------------------------
        Boolean chicken_pizza = false;
        Boolean cheese_burger = false;
        Boolean chicken_nuggets = false;
        Boolean panfried_noodles = false;
        Boolean french_fries = false;
        Boolean chicken_Shawarma = false;
        /*Boolean ice_coke = false;
        Boolean ice_coffee = false;
        Boolean lemonade = false;
        Boolean chocholate_shake = false;
        Boolean boba_tea = false;
        Boolean falooda = false;*/
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*ofa.cheackData(123);
            pizza++;

            if(pizza <= ofa.Tempstock)
            {
                Spizza++;
            }

            lblstock1.Text = Spizza.ToString();

            ListViewItem item= new ListViewItem("pizza");
            item.SubItems.Add("500");
            listView1.Items.Add(item);


            if (pizza > ofa.Tempstock)
            {
                MessageBox.Show("Out of stock only "+ Spizza + " items available.. not "+ pizza);
            }*/

            /*ofa.cheackData(1);
            mfabc.Pizza++;

            if (mfabc.Pizza <= ofa.Tempstock)
            {
                lblCpizza.Text = mfabc.Pizza.ToString();

                double subtot = mfabc.Pizza * ofa.Price;

                totalUpdate(subtot);

                if (pizza == false)
                {
                    //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Pizza;
                    flv.Price = subtot;
                    flv.insertData();
                    displayGrid1();
                    pizza = true;
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Pizza;
                    flv.Price = subtot;
                    flv.updateData();
                    displayGrid1();
                    //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                }
            }
            else
            {
                mfabc.Pizza--;
                MessageBox.Show("Out of stock only " + mfabc.Pizza + " items available.. not " + (mfabc.Pizza + 1));
            }*/
            allForOne(1);
            lbltot.Text = mfabc.Total.ToString();

        }

        
        //Making the incrimented value to zero----------------------------------------------------------------------------------------------------------
        private void FoodItems_Load(object sender, EventArgs e)
        {
            displayGrid1();
            lbltot.Text = mfabc.Total.ToString();

            //real deal
            /*mfabc.Chicken_pizza = 0;
            mfabc.Cheese_burger = 0;
            mfabc.Chicken_nuggets = 0;
            mfabc.Panfried_noodles = 0;
            mfabc.French_fries = 0;
            mfabc.Chicken_Shawarma = 0;
            mfabc.Ice_coke = 0;
            mfabc.Ice_coffee = 0;
            mfabc.Lemonade = 0;
            mfabc.Chocholate_shake = 0;
            mfabc.Boba_tea = 0;
            mfabc.Falooda = 0;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }


        //this is the second food item--------------------------------------------------------------------------------------------------------------------------------------------------------
        //int coke = 0;
        //int Scoke = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*ofa.cheackData(2);
            coke++;

            if (coke <= ofa.Tempstock)
            {
                Scoke++;
            }

            lblstock1.Text = Scoke.ToString();

            ListViewItem item = new ListViewItem("coke");
            item.SubItems.Add("100");
            listView1.Items.Add(item);


            if (coke > ofa.Tempstock)
            {
                MessageBox.Show("Out of stock only " + Scoke + " items available.. not " + coke);
            }*/

            /*ofa.cheackData(2);
            mfabc.Coke++;
            if (mfabc.Coke <= ofa.Tempstock)
            {
                lblstock1.Text = mfabc.Coke.ToString();

                double subtot = mfabc.Coke * ofa.Price;

                totalUpdate(subtot);

                if (coke == false)
                {
                    //addToListView("Coke", mfabc.Coke.ToString(), subtot.ToString());
                    //pizza= true;
                }
                else
                {
                    //updateItemsListView(mfabc.Coke.ToString(), subtot.ToString());
                }
            }
            else
            {
                mfabc.Coke--;
                MessageBox.Show("Out of stock only " + mfabc.Coke + " items available.. not " + (mfabc.Coke + 1));
            }*/
            allForOne(2);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            BuyConfermation bc = new BuyConfermation();
            bc.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bverages bvg = new Bverages();
            bvg.Show();
            this.Hide();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //displayGrid1();
        }

        public void allForOne(int id)
        {
            ofa.cheackData(id);
            //mfabc.Pizza++;
            //change id ------------------------------------------------------------------------------------------------------------------------------------------
            if(id == 1)
            {
                mfabc.Chicken_pizza++;

                if (mfabc.Chicken_pizza <= ofa.Tempstock)
                {
                    lblCpizza.Text = mfabc.Chicken_pizza.ToString();

                    double subtot = mfabc.Chicken_pizza * ofa.Price;

                    mfabc.Total = mfabc.Total + ofa.Price;

                    if (chicken_pizza == false)
                    {
                        //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Chicken_pizza;
                        flv.Price = subtot;
                        flv.insertData();
                        displayGrid1();
                        chicken_pizza = true;
                    }
                    else
                    {
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Chicken_pizza;
                        flv.Price = subtot;
                        flv.updateData();
                        displayGrid1();
                        //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                    }
                }
                else
                {
                    mfabc.Chicken_pizza--;
                    MessageBox.Show("Out of stock only " + mfabc.Chicken_pizza + " items available.. not " + (mfabc.Chicken_pizza + 1));
                }
            }
            if (id == 2)
            {
                mfabc.Cheese_burger++;

                if (mfabc.Cheese_burger <= ofa.Tempstock)
                {
                    lblCburger.Text = mfabc.Cheese_burger.ToString();

                    double subtot = mfabc.Cheese_burger * ofa.Price;

                    mfabc.Total = mfabc.Total + ofa.Price;

                    if (cheese_burger == false)
                    {
                        //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Cheese_burger;
                        flv.Price = subtot;
                        flv.insertData();
                        displayGrid1();
                        cheese_burger = true;
                    }
                    else
                    {
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Cheese_burger;
                        flv.Price = subtot;
                        flv.updateData();
                        displayGrid1();
                        //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                    }
                }
                else
                {
                    mfabc.Cheese_burger--;
                    MessageBox.Show("Out of stock only " + mfabc.Cheese_burger + " items available.. not " + (mfabc.Cheese_burger + 1));
                }
            }
            if (id == 3)
            {
                mfabc.Chicken_nuggets++;

                if (mfabc.Chicken_nuggets <= ofa.Tempstock)
                {
                    lblCnuggets.Text = mfabc.Chicken_nuggets.ToString();

                    double subtot = mfabc.Chicken_nuggets * ofa.Price;

                    mfabc.Total = mfabc.Total + ofa.Price;

                    if (chicken_nuggets == false)
                    {
                        //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Chicken_nuggets;
                        flv.Price = subtot;
                        flv.insertData();
                        displayGrid1();
                        chicken_nuggets = true;
                    }
                    else
                    {
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Chicken_nuggets;
                        flv.Price = subtot;
                        flv.updateData();
                        displayGrid1();
                        //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                    }
                }
                else
                {
                    mfabc.Chicken_nuggets--;
                    MessageBox.Show("Out of stock only " + mfabc.Chicken_nuggets + " items available.. not " + (mfabc.Chicken_nuggets + 1));
                }
            }
            if (id == 4)
            {
                mfabc.Panfried_noodles++;

                if (mfabc.Panfried_noodles <= ofa.Tempstock)
                {
                    lblpfnoodles.Text = mfabc.Panfried_noodles.ToString();

                    double subtot = mfabc.Panfried_noodles * ofa.Price;

                    mfabc.Total = mfabc.Total + ofa.Price;

                    if (panfried_noodles == false)
                    {
                        //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Panfried_noodles;
                        flv.Price = subtot;
                        flv.insertData();
                        displayGrid1();
                        chicken_pizza = true;
                    }
                    else
                    {
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Panfried_noodles;
                        flv.Price = subtot;
                        flv.updateData();
                        displayGrid1();
                        //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                    }
                }
                else
                {
                    mfabc.Panfried_noodles--;
                    MessageBox.Show("Out of stock only " + mfabc.Panfried_noodles + " items available.. not " + (mfabc.Panfried_noodles + 1));
                }
            }
            if (id == 5)
            {
                mfabc.French_fries++;

                if (mfabc.French_fries <= ofa.Tempstock)
                {
                    lblpffries.Text = mfabc.French_fries.ToString();

                    double subtot = mfabc.French_fries * ofa.Price;

                    mfabc.Total = mfabc.Total + ofa.Price;

                    if (french_fries == false)
                    {
                        //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.French_fries;
                        flv.Price = subtot;
                        flv.insertData();
                        displayGrid1();
                        french_fries = true;
                    }
                    else
                    {
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.French_fries;
                        flv.Price = subtot;
                        flv.updateData();
                        displayGrid1();
                        //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                    }
                }
                else
                {
                    mfabc.French_fries--;
                    MessageBox.Show("Out of stock only " + mfabc.French_fries + " items available.. not " + (mfabc.French_fries + 1));
                }
            }
            if (id == 6)
            {
                mfabc.Chicken_Shawarma++;

                if (mfabc.Chicken_Shawarma <= ofa.Tempstock)
                {
                    lblCshawarma.Text = mfabc.Chicken_Shawarma.ToString();

                    double subtot = mfabc.Chicken_Shawarma * ofa.Price;

                    mfabc.Total = mfabc.Total + ofa.Price;

                    if (chicken_Shawarma == false)
                    {
                        //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Chicken_Shawarma;
                        flv.Price = subtot;
                        flv.insertData();
                        displayGrid1();
                        chicken_Shawarma = true;
                    }
                    else
                    {
                        flv.Item = ofa.Name;
                        flv.Qty = mfabc.Chicken_Shawarma;
                        flv.Price = subtot;
                        flv.updateData();
                        displayGrid1();
                        //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                    }
                }
                else
                {
                    mfabc.Chicken_Shawarma--;
                    MessageBox.Show("Out of stock only " + mfabc.Chicken_Shawarma + " items available.. not " + (mfabc.Chicken_Shawarma + 1));
                }
            }
            
            /*if (id == 7)
            {
                mfabc.Ice_coke++;

                if (mfabc.Ice_coke <= ofa.Tempstock)
                {
                    lblCpizza.Text = mfabc.Ice_coke.ToString();

                    double subtot = mfabc.Ice_coke * ofa.Price;

                    totalUpdate(subtot);

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
                    lblCpizza.Text = mfabc.Ice_coffee.ToString();

                    double subtot = mfabc.Ice_coffee * ofa.Price;

                    totalUpdate(subtot);

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
                    lblCpizza.Text = mfabc.Lemonade.ToString();

                    double subtot = mfabc.Lemonade * ofa.Price;

                    totalUpdate(subtot);

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
                    lblCpizza.Text = mfabc.Chocholate_shake.ToString();

                    double subtot = mfabc.Chocholate_shake * ofa.Price;

                    totalUpdate(subtot);

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
                    lblCpizza.Text = mfabc.Boba_tea.ToString();

                    double subtot = mfabc.Boba_tea * ofa.Price;

                    totalUpdate(subtot);

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
                    lblCpizza.Text = mfabc.Falooda.ToString();

                    double subtot = mfabc.Falooda * ofa.Price;

                    totalUpdate(subtot);

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
            }*/

           /* if (mfabc.Pizza <= ofa.Tempstock)
            {
                lblCpizza.Text = mfabc.Pizza.ToString();

                double subtot = mfabc.Pizza * ofa.Price;

                totalUpdate(subtot);

                if (pizza == false)
                {
                    //addToListView("Pizza", mfabc.Pizza.ToString(), subtot.ToString());
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Pizza;
                    flv.Price = subtot;
                    flv.insertData();
                    displayGrid1();
                    pizza = true;
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Pizza;
                    flv.Price = subtot;
                    flv.updateData();
                    displayGrid1();
                    //updateItemsListView(mfabc.Pizza.ToString(), subtot.ToString());
                }
            }
            else
            {
                mfabc.Pizza--;
                MessageBox.Show("Out of stock only " + mfabc.Pizza + " items available.. not " + (mfabc.Pizza + 1));
            }*/
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            allForOne(3);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            allForOne(4);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            allForOne(5);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            allForOne(6);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*ofa.cheackData(1);
            if (mfabc.Chicken_pizza > 0)
            {
                mfabc.Chicken_pizza--;
                lblCpizza.Text = mfabc.Chicken_pizza.ToString();

                double subtot = ofa.Price;

                mfabc.Total = mfabc.Total - subtot;

            }
            if(mfabc.Chicken_pizza == 0)
            {
                flv.deleteOneData(ofa.Name);
                chicken_pizza = false;
                displayGrid1();
            }
            else
            {
                flv.Item = ofa.Name;
                flv.Qty = mfabc.Chicken_pizza;
                flv.Price = mfabc.Chicken_pizza * ofa.Price;
                flv.updateData();
                displayGrid1();
            }
            lbltot.Text = mfabc.Total.ToString();*/
            allSubMinus(1);
        }


        public void allSubMinus(int id)
        {
            ofa.cheackData(id);
            if (id == 1)
            {
                if (mfabc.Chicken_pizza > 0)
                {
                    mfabc.Chicken_pizza--;
                    lblCpizza.Text = mfabc.Chicken_pizza.ToString();

                    double subtot = ofa.Price;

                    mfabc.Total = mfabc.Total - subtot;

                }
                if (mfabc.Chicken_pizza == 0)
                {
                    flv.deleteOneData(ofa.Name);
                    chicken_pizza = false;
                    displayGrid1();
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Chicken_pizza;
                    flv.Price = mfabc.Chicken_pizza * ofa.Price;
                    flv.updateData();
                    displayGrid1();
                }
                lbltot.Text = mfabc.Total.ToString();
            }
            if (id == 2)
            {
                if (mfabc.Cheese_burger > 0)
                {
                    mfabc.Cheese_burger--;
                    lblCburger.Text = mfabc.Cheese_burger.ToString();

                    double subtot = ofa.Price;

                    mfabc.Total = mfabc.Total - subtot;

                }
                if (mfabc.Cheese_burger == 0)
                {
                    flv.deleteOneData(ofa.Name);
                    cheese_burger = false;
                    displayGrid1();
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Cheese_burger;
                    flv.Price = mfabc.Cheese_burger * ofa.Price;
                    flv.updateData();
                    displayGrid1();
                }
                lbltot.Text = mfabc.Total.ToString();
            }
            if (id == 3)
            {
                if (mfabc.Chicken_nuggets > 0)
                {
                    mfabc.Chicken_nuggets--;
                    lblCnuggets.Text = mfabc.Chicken_nuggets.ToString();

                    double subtot = ofa.Price;

                    mfabc.Total = mfabc.Total - subtot;

                }
                if (mfabc.Chicken_nuggets == 0)
                {
                    flv.deleteOneData(ofa.Name);
                    chicken_nuggets = false;
                    displayGrid1();
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Chicken_nuggets;
                    flv.Price = mfabc.Chicken_nuggets * ofa.Price;
                    flv.updateData();
                    displayGrid1();
                }
                lbltot.Text = mfabc.Total.ToString();
            }
            if (id == 4)
            {
                if (mfabc.Panfried_noodles > 0)
                {
                    mfabc.Panfried_noodles--;
                    lblpfnoodles.Text = mfabc.Panfried_noodles.ToString();

                    double subtot = ofa.Price;

                    mfabc.Total = mfabc.Total - subtot;

                }
                if (mfabc.Panfried_noodles == 0)
                {
                    flv.deleteOneData(ofa.Name);
                    panfried_noodles = false;
                    displayGrid1();
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Panfried_noodles;
                    flv.Price = mfabc.Panfried_noodles * ofa.Price;
                    flv.updateData();
                    displayGrid1();
                }
                lbltot.Text = mfabc.Total.ToString();
            
             
            }
            if (id == 5)
            {
                if (mfabc.French_fries > 0)
                {
                    mfabc.Chicken_pizza--;
                    lblpffries.Text = mfabc.French_fries.ToString();

                    double subtot = ofa.Price;

                    mfabc.Total = mfabc.Total - subtot;

                }
                if (mfabc.French_fries == 0)
                {
                    flv.deleteOneData(ofa.Name);
                    french_fries = false;
                    displayGrid1();
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.French_fries;
                    flv.Price = mfabc.French_fries * ofa.Price;
                    flv.updateData();
                    displayGrid1();
                }
                lbltot.Text = mfabc.Total.ToString();
            }
            if (id == 6)
            {
                if (mfabc.Chicken_Shawarma > 0)
                {
                    mfabc.Chicken_Shawarma--;
                    lblCshawarma.Text = mfabc.Chicken_Shawarma.ToString();

                    double subtot = ofa.Price;

                    mfabc.Total = mfabc.Total - subtot;

                }
                if (mfabc.Chicken_Shawarma == 0)
                {
                    flv.deleteOneData(ofa.Name);
                    chicken_Shawarma = false;
                    displayGrid1();
                }
                else
                {
                    flv.Item = ofa.Name;
                    flv.Qty = mfabc.Chicken_Shawarma;
                    flv.Price = mfabc.Chicken_Shawarma * ofa.Price;
                    flv.updateData();
                    displayGrid1();
                }
                lbltot.Text = mfabc.Total.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            allSubMinus(2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            allSubMinus(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            allSubMinus(4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            allSubMinus(5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            allSubMinus(6);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            allForOne(1);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            allForOne(2);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            allForOne(3);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            allForOne(4);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            allForOne(5);
            lbltot.Text = mfabc.Total.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            allForOne(6);
            lbltot.Text = mfabc.Total.ToString();
        }
    }
}
