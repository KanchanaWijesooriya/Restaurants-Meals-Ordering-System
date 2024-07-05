using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_course_work
{
    internal class MidFoodandBuyConfermation
    {


        //real deal
        private static int chicken_pizza;
        private static int cheese_burger;
        private static int chicken_nuggets;
        private static int panfried_noodles;
        private static int french_fries;
        private static int chicken_Shawarma;
        private static int ice_coke;
        private static int ice_coffee;
        private static int lemonade;
        private static int chocholate_shake;
        private static int boba_tea;
        private static int falooda;
        private static double total;

        public int Chicken_pizza { get => chicken_pizza; set => chicken_pizza = value; }
        public int Cheese_burger { get => cheese_burger; set => cheese_burger = value; }
        public int Chicken_nuggets { get => chicken_nuggets; set => chicken_nuggets = value; }
        public int Panfried_noodles { get => panfried_noodles; set => panfried_noodles = value; }
        public int French_fries { get => french_fries; set => french_fries = value; }
        public int Chicken_Shawarma { get => chicken_Shawarma; set => chicken_Shawarma = value; }
        public int Ice_coke { get => ice_coke; set => ice_coke = value; }
        public int Ice_coffee { get => ice_coffee; set => ice_coffee = value; }
        public int Lemonade { get => lemonade; set => lemonade = value; }
        public int Chocholate_shake { get => chocholate_shake; set => chocholate_shake = value; }
        public int Boba_tea { get => boba_tea; set => boba_tea = value; }
        public int Falooda { get => falooda; set => falooda = value; }
        public double Total { get => total; set => total = value; }




        /*public MidFoodandBuyConfermation()
        {
            this.pizza = 0;
            this.coke = 0;
        }*/


        /*public void allForOne(int id)
        {
            ofa.cheackData(1);
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
            }
        }*/
    }
}
