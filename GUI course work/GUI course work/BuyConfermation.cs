using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GUI_course_work
{
    public partial class BuyConfermation : Form
    {
        OneForAll ofa;
        DailyUpdateDB dudb;
        MidFoodandBuyConfermation mfabc;
        FoodListView flv;
        public BuyConfermation()
        {
            InitializeComponent();
            ofa = new OneForAll();
            dudb = new DailyUpdateDB();
            mfabc = new MidFoodandBuyConfermation();
            flv= new FoodListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Data entered successfully" + mfabc.Pizza);
            if (mfabc.Chicken_pizza > 0)
            {
                ofa.cheackData(1);
                ofa.Stock = ofa.Stock - mfabc.Chicken_pizza;
                //MessageBox.Show("Data entered successfully" + ofa.Id);
                ofa.editData();
                ofa.cheackData(1);

                //cheack the boolean condition
                dudb.cheackCount(1);
                //MessageBox.Show("The count is" + dudb.Count);
                if (dudb.Count > 0)
                {
                    //MessageBox.Show("This is count rute");
                    dudb.selectAllData(1);
                    dudb.Totprice = dudb.Totprice + (ofa.Price * mfabc.Chicken_pizza);
                    dudb.Stock = dudb.Stock + mfabc.Chicken_pizza;
                    dudb.editData(1);
                }
                else
                {
                    //MessageBox.Show("This is instert rute");
                    dudb.Id = ofa.Id;
                    dudb.Name = ofa.Name;
                    dudb.Totprice = ofa.Price * mfabc.Chicken_pizza;
                    dudb.Stock = mfabc.Chicken_pizza;
                    dudb.insertData();
                }
                
            }

            if (mfabc.Cheese_burger > 0)
            {
                ofa.cheackData(2);
                ofa.Stock = ofa.Stock - mfabc.Cheese_burger;
                //MessageBox.Show("Data entered successfully" + ofa.Id);
                ofa.editData();
                ofa.cheackData(2);

                //cheack the boolean condition
                dudb.cheackCount(2);
                //MessageBox.Show("The count is" + dudb.Count);
                if (dudb.Count > 0)
                {
                    //MessageBox.Show("This is count rute");
                    dudb.selectAllData(1);
                    dudb.Totprice = dudb.Totprice + (ofa.Price * mfabc.Cheese_burger);
                    dudb.Stock = dudb.Stock + mfabc.Cheese_burger;
                    dudb.editData(2);
                }
                else
                {
                    //MessageBox.Show("This is instert rute");
                    dudb.Id = ofa.Id;
                    dudb.Name = ofa.Name;
                    dudb.Totprice = ofa.Price * mfabc.Cheese_burger;
                    dudb.Stock = mfabc.Cheese_burger;
                    dudb.insertData();
                }

            }

            if (mfabc.Chicken_nuggets > 0)
            {
                ofa.cheackData(3);
                ofa.Stock = ofa.Stock - mfabc.Chicken_nuggets;
                //MessageBox.Show("Data entered successfully" + ofa.Id);
                ofa.editData();
                ofa.cheackData(3);

                //cheack the boolean condition
                dudb.cheackCount(3);
                //MessageBox.Show("The count is" + dudb.Count);
                if (dudb.Count > 0)
                {
                    //MessageBox.Show("This is count rute");
                    dudb.selectAllData(1);
                    dudb.Totprice = dudb.Totprice + (ofa.Price * mfabc.Chicken_nuggets);
                    dudb.Stock = dudb.Stock + mfabc.Chicken_nuggets;
                    dudb.editData(3);
                }
                else
                {
                    //MessageBox.Show("This is instert rute");
                    dudb.Id = ofa.Id;
                    dudb.Name = ofa.Name;
                    dudb.Totprice = ofa.Price * mfabc.Chicken_nuggets;
                    dudb.Stock = mfabc.Chicken_nuggets;
                    dudb.insertData();
                }

            }

            if (mfabc.Panfried_noodles > 0)
            {
                ofa.cheackData(4);
                ofa.Stock = ofa.Stock - mfabc.Panfried_noodles;
                //MessageBox.Show("Data entered successfully" + ofa.Id);
                ofa.editData();
                ofa.cheackData(4);

                //cheack the boolean condition
                dudb.cheackCount(4);
                //MessageBox.Show("The count is" + dudb.Count);
                if (dudb.Count > 0)
                {
                    //MessageBox.Show("This is count rute");
                    dudb.selectAllData(4);
                    dudb.Totprice = dudb.Totprice + (ofa.Price * mfabc.Panfried_noodles);
                    dudb.Stock = dudb.Stock + mfabc.Panfried_noodles;
                    dudb.editData(4);
                }
                else
                {
                    //MessageBox.Show("This is instert rute");
                    dudb.Id = ofa.Id;
                    dudb.Name = ofa.Name;
                    dudb.Totprice = ofa.Price * mfabc.Panfried_noodles;
                    dudb.Stock = mfabc.Panfried_noodles;
                    dudb.insertData();
                }

            }

            if (mfabc.French_fries > 0)
            {
                ofa.cheackData(1);
                ofa.Stock = ofa.Stock - mfabc.French_fries;
                //MessageBox.Show("Data entered successfully" + ofa.Id);
                ofa.editData();
                ofa.cheackData(5);

                //cheack the boolean condition
                dudb.cheackCount(5);
                //MessageBox.Show("The count is" + dudb.Count);
                if (dudb.Count > 0)
                {
                    //MessageBox.Show("This is count rute");
                    dudb.selectAllData(5);
                    dudb.Totprice = dudb.Totprice + (ofa.Price * mfabc.French_fries);
                    dudb.Stock = dudb.Stock + mfabc.French_fries;
                    dudb.editData(5);
                }
                else
                {
                    //MessageBox.Show("This is instert rute");
                    dudb.Id = ofa.Id;
                    dudb.Name = ofa.Name;
                    dudb.Totprice = ofa.Price * mfabc.French_fries;
                    dudb.Stock = mfabc.French_fries;
                    dudb.insertData();
                }

            }

            if (mfabc.Chicken_Shawarma > 0)
            {
                ofa.cheackData(6);
                ofa.Stock = ofa.Stock - mfabc.Chicken_Shawarma;
                //MessageBox.Show("Data entered successfully" + ofa.Id);
                ofa.editData();
                ofa.cheackData(6);

                //cheack the boolean condition
                dudb.cheackCount(6);
                //MessageBox.Show("The count is" + dudb.Count);
                if (dudb.Count > 0)
                {
                    //MessageBox.Show("This is count rute");
                    dudb.selectAllData(6);
                    dudb.Totprice = dudb.Totprice + (ofa.Price * mfabc.Chicken_Shawarma);
                    dudb.Stock = dudb.Stock + mfabc.Chicken_Shawarma;
                    dudb.editData(6);
                }
                else
                {
                    //MessageBox.Show("This is instert rute");
                    dudb.Id = ofa.Id;
                    dudb.Name = ofa.Name;
                    dudb.Totprice = ofa.Price * mfabc.Chicken_Shawarma;
                    dudb.Stock = mfabc.Chicken_Shawarma;
                    dudb.insertData();
                }

            }

            if (mfabc.Ice_coke > 0)
            {
                ofa.cheackData(7);
                ofa.Stock = ofa.Stock - mfabc.Ice_coke;
                //MessageBox.Show("Data entered successfully" + ofa.Id);
                ofa.editData();
                ofa.cheackData(7);

                //cheack the boolean condition
                dudb.cheackCount(7);
                //MessageBox.Show("The count is" + dudb.Count);
                if (dudb.Count > 0)
                {
                    //MessageBox.Show("This is count rute");
                    dudb.selectAllData(7);
                    dudb.Totprice = dudb.Totprice + (ofa.Price * mfabc.Ice_coke);
                    dudb.Stock = dudb.Stock + mfabc.Ice_coke;
                    dudb.editData(7);
                }
                else
                {
                    //MessageBox.Show("This is instert rute");
                    dudb.Id = ofa.Id;
                    dudb.Name = ofa.Name;
                    dudb.Totprice = ofa.Price * mfabc.Ice_coke;
                    dudb.Stock = mfabc.Ice_coke;
                    dudb.insertData();
                }

            }

            if (mfabc.Ice_coffee > 0)
            {
                ofa.cheackData(8);
                ofa.Stock = ofa.Stock - mfabc.Ice_coffee;
                //MessageBox.Show("Data entered successfully" + ofa.Id);
                ofa.editData();
                ofa.cheackData(8);

                //cheack the boolean condition
                dudb.cheackCount(8);
                //MessageBox.Show("The count is" + dudb.Count);
                if (dudb.Count > 0)
                {
                    //MessageBox.Show("This is count rute");
                    dudb.selectAllData(8);
                    dudb.Totprice = dudb.Totprice + (ofa.Price * mfabc.Ice_coffee);
                    dudb.Stock = dudb.Stock + mfabc.Ice_coffee;
                    dudb.editData(8);
                }
                else
                {
                   //MessageBox.Show("This is instert rute");
                    dudb.Id = ofa.Id;
                    dudb.Name = ofa.Name;
                    dudb.Totprice = ofa.Price * mfabc.Ice_coffee;
                    dudb.Stock = mfabc.Ice_coffee;
                    dudb.insertData();
                }

            }

            if (mfabc.Lemonade > 0)
            {
                ofa.cheackData(9);
                ofa.Stock = ofa.Stock - mfabc.Lemonade;
                //MessageBox.Show("Data entered successfully" + ofa.Id);
                ofa.editData();
                ofa.cheackData(9);

                //cheack the boolean condition
                dudb.cheackCount(9);
                //MessageBox.Show("The count is" + dudb.Count);
                if (dudb.Count > 0)
                {
                    MessageBox.Show("This is count rute");
                    dudb.selectAllData(9);
                    dudb.Totprice = dudb.Totprice + (ofa.Price * mfabc.Lemonade);
                    dudb.Stock = dudb.Stock + mfabc.Lemonade;
                    dudb.editData(9);
                }
                else
                {
                    //MessageBox.Show("This is instert rute");
                    dudb.Id = ofa.Id;
                    dudb.Name = ofa.Name;
                    dudb.Totprice = ofa.Price * mfabc.Lemonade;
                    dudb.Stock = mfabc.Lemonade;
                    dudb.insertData();
                }

            }

            if (mfabc.Chocholate_shake > 0)
            {
                ofa.cheackData(10);
                ofa.Stock = ofa.Stock - mfabc.Chocholate_shake;
                //MessageBox.Show("Data entered successfully" + ofa.Id);
                ofa.editData();
                ofa.cheackData(10);

                //cheack the boolean condition
                dudb.cheackCount(10);
                //MessageBox.Show("The count is" + dudb.Count);
                if (dudb.Count > 0)
                {
                    //MessageBox.Show("This is count rute");
                    dudb.selectAllData(1);
                    dudb.Totprice = dudb.Totprice + (ofa.Price * mfabc.Chocholate_shake);
                    dudb.Stock = dudb.Stock + mfabc.Chocholate_shake;
                    dudb.editData(10);
                }
                else
                {
                    //MessageBox.Show("This is instert rute");
                    dudb.Id = ofa.Id;
                    dudb.Name = ofa.Name;
                    dudb.Totprice = ofa.Price * mfabc.Chocholate_shake;
                    dudb.Stock = mfabc.Chocholate_shake;
                    dudb.insertData();
                }

            }

            if (mfabc.Boba_tea > 0)
            {
                ofa.cheackData(11);
                ofa.Stock = ofa.Stock - mfabc.Boba_tea;
                //MessageBox.Show("Data entered successfully" + ofa.Id);
                ofa.editData();
                ofa.cheackData(11);

                //cheack the boolean condition
                dudb.cheackCount(11);
                //MessageBox.Show("The count is" + dudb.Count);
                if (dudb.Count > 0)
                {
                    //MessageBox.Show("This is count rute");
                    dudb.selectAllData(11);
                    dudb.Totprice = dudb.Totprice + (ofa.Price * mfabc.Boba_tea);
                    dudb.Stock = dudb.Stock + mfabc.Boba_tea;
                    dudb.editData(11);
                }
                else
                {
                    //MessageBox.Show("This is instert rute");
                    dudb.Id = ofa.Id;
                    dudb.Name = ofa.Name;
                    dudb.Totprice = ofa.Price * mfabc.Boba_tea;
                    dudb.Stock = mfabc.Boba_tea;
                    dudb.insertData();
                }

            }

            if (mfabc.Falooda > 0)
            {
                ofa.cheackData(12);
                ofa.Stock = ofa.Stock - mfabc.Falooda;
                //MessageBox.Show("Data entered successfully" + ofa.Id);
                ofa.editData();
                ofa.cheackData(12);

                //cheack the boolean condition
                dudb.cheackCount(12);
                //MessageBox.Show("The count is" + dudb.Count);
                if (dudb.Count > 0)
                {
                    //MessageBox.Show("This is count rute");
                    dudb.selectAllData(12);
                    dudb.Totprice = dudb.Totprice + (ofa.Price * mfabc.Falooda);
                    dudb.Stock = dudb.Stock + mfabc.Falooda;
                    dudb.editData(12);
                }
                else
                {
                    //MessageBox.Show("This is instert rute");
                    dudb.Id = ofa.Id;
                    dudb.Name = ofa.Name;
                    dudb.Totprice = ofa.Price * mfabc.Falooda;
                    dudb.Stock = mfabc.Falooda;
                    dudb.insertData();
                }

            }



            SelectMethod sm = new SelectMethod();
            BuyConfermation bc = new BuyConfermation();
            sm.Show();
            this.Hide();
            bc.Hide();
            flv.deleteData();
            mfabc.Total = 0.0;

            /*if (mfabc.Coke > 0)
            {
                ofa.cheackData(2);
                ofa.Stock = ofa.Stock - mfabc.Coke;
                ofa.editData();
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for doing business with us");
            SelectMethod sm = new SelectMethod();
            BuyConfermation bc = new BuyConfermation();
            sm.Show();
            this.Hide();
            bc.Hide();
            flv.deleteData();
            mfabc.Total = 0.0;
        }
    }
}
