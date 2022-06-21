using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupWindowsApp
{
    public partial class Form1 : Form
    {
        public class product//makes up a single product
        {
            public string type, size, color;
            public double price;
        }
        public Form1()
        {
            InitializeComponent();
        }
        string type = "", size = "", color = "";
        bool typeSelected = false, colorSelected = false, sizeSelected = false, itemSelected = false;
        double price, balance = 0, total = 0, priceRemoved;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pantsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeSelected = true;
        }
        private void pantsColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorSelected = true;
        }
        private void pantsSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            sizeSelected = true;
        }
        //Selecting product
        private void btnNext_Click(object sender, EventArgs e)
        {
            //string imageLocation = @"...\...\\Pants\";
            type = Convert.ToString(pantsType.SelectedItem);
            color = Convert.ToString(pantsColor.SelectedItem);
            size = Convert.ToString(pantsSize.SelectedItem);

            if (typeSelected && colorSelected && sizeSelected)
            {
                //imageLocation += color + @"\" + color.ToLower() + type + ".jpg";
                //productImage.ImageLocation = imageLocation;
                productDescriptor.Text = size + " " + color.ToLower() + " " + type.ToLower();
                switch (type)
                {
                    case "Jeans":
                        price = 30.00;
                        break;
                    case "Khakis":
                        price = 35.00;
                        break;
                    case "Shorts":
                        price = 20.00;
                        break;
                    case "Sweatpants":
                        price = 25.00;
                        break;
                }
                productPrice.Text = "$" + Convert.ToString(price);
                productOffer.Visible = true;
            }
            else
            {
                MessageBox.Show("Please answer all three fields.");
                productOffer.Visible = false;
            }
        }

        //Displays product
        private void btnAddKart_Click(object sender, EventArgs e)
        {
            product inKart = new product();
            inKart.type = type;
            inKart.size = size;
            inKart.color = color;
            inKart.price = price;
            if (productsInKart.Items.Count < 5)
            {
                productsInKart.Items.Add(inKart.size + " " + inKart.color.ToLower() + 
                    " " + inKart.type.ToLower() + " - $" + price);
                total += inKart.price;
                totalPrice.Text = "$" + Convert.ToString(total);
                MessageBox.Show("Added to kart.");
                productOffer.Visible = false;
            }
            else
            {
                MessageBox.Show("Too many items in kart.");
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            productOffer.Visible = false;
        }

        //Adding funds
        private void addFunds_Click(object sender, EventArgs e)
        {
            FundsBox.Visible = true;
            fundsAdded.Text = "0.00";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            balance += Convert.ToDouble(fundsAdded.Text);
            funds.Text = "$" + Convert.ToString(balance);
            MessageBox.Show("Added to your balance.");
            FundsBox.Visible = false;
        }
        private void btnFundsBack_Click(object sender, EventArgs e)
        {
            FundsBox.Visible = false;
        }

        //Kart menu
        private void btnKart_Click(object sender, EventArgs e)
        {
            kartMenu.Visible = true;
            btnRemove.Visible = true;
            btnPurchase.Visible = false;
        }
        
        private void productsInKart_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemSelected = true;
            int pricePosition = Convert.ToString(productsInKart.Text).IndexOf('$');
            priceRemoved = Convert.ToInt32(productsInKart.Text.Substring(pricePosition + 1));
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (itemSelected)
            {
                productsInKart.Items.RemoveAt(productsInKart.SelectedIndex);
                total -= priceRemoved;
                totalPrice.Text = "$" + Convert.ToString(total);
                itemSelected = false;
            }
            else
            {
                MessageBox.Show("First selected an item to remove");
            }
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            kartMenu.Visible = true;
            btnRemove.Visible = false;
            btnPurchase.Visible = true;
        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if(total <= balance)
            {
                MessageBox.Show("Thank you! Please shop again.");
                balance -= total;
            }
            else
            {
                MessageBox.Show("Insufficient funds.");
            }
        }
        private void btnKartBack_Click(object sender, EventArgs e)
        {
            itemSelected = false;
            kartMenu.Visible = false;
        }

        private void backToStoreSelect_Click(object sender, EventArgs e)//save this for later
        {

        }

        //double-clicked these on accident lmao
        private void funds_TextChanged(object sender, EventArgs e)
        {

        }


        private void fundsAdded_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
