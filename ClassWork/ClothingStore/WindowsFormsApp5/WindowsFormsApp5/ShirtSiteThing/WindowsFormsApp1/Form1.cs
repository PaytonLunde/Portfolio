using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string type = "shirt";
        string color = "white";

        private void Form1_Load(object sender, EventArgs e)
        {
            GreenBtn.Visible = true;
            RedBtn.Visible = true;
            BlueBtn.Visible = true;
            WhiteBtn.Visible = true;
            YellowBtn.Visible = true;
            
            
            this.ImageBox.AllowDrop = true;
            this.ImageBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.ImageBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            this.logoSpot.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.logoSpot.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);

        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] droppedfiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in droppedfiles)
            {
                logoSpot.BackgroundImage = Image.FromFile(file);
                logoSpot.Visible = true;
            }

        }
        private void ShirtBtn_Click(object sender, EventArgs e)
        {
            type = "shirt";
            pictureShow();
        }
        private void TankTopBtn_Click(object sender, EventArgs e)
        {
            type = "tanktop";
            pictureShow();

        }

        private void HoodieBtn_Click(object sender, EventArgs e)
        {
            type = "hoodie";
            pictureShow();
        }


        private void RedBtn_Click(object sender, EventArgs e)
        {
            color = "red";
            pictureShow();
        }

        private void GreenBtn_Click(object sender, EventArgs e)
        {
            color = "green";
            pictureShow();
        }

        private void BlueBtn_Click(object sender, EventArgs e)
        {
            color = "blue";
            pictureShow();
        }

        private void YellowBtn_Click(object sender, EventArgs e)
        {
            color = "yellow";
            pictureShow();
        }

        private void WhiteBtn_Click(object sender, EventArgs e)
        {
            color = "white";
            pictureShow();
        }
        public void pictureShow()
        {
            switch (type)
            {
                case "shirt":
                    switch (color)
                    {
                        case "white":
                            this.ImageBox.BackgroundImage = Image.FromFile(@"...\...\\WhiteShirt.jfif");
                            break;
                        case "red":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\RedShirt.jpg");
                            break;
                        case "blue":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\BlueShirt.jpg");
                            break;
                        case "green":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\GreenShirt.jpg");
                            break;
                        case "yellow":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\YellowShirt.jpg");
                            break;
                    }
                    break;
                case "tanktop":
                    switch (color)
                    {
                        case "white":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\Tanktop.jfif");
                            break;
                        case "red":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\Redtanktop.jfif");
                            break;
                        case "blue":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\Bluetanktop.jfif");
                            break;
                        case "green":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\Greentanktop.jfif");
                            break;
                        case "yellow":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\Yellowtanktop.jfif");
                            break;
                    }
                    break;
                case "hoodie":
                    switch (color)
                    {
                        case "white":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\Hoodie.jfif");
                            break;
                        case "red":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\RedHoodie.jpg");
                            break;
                        case "blue":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\BlueHoodie.jpg");
                            break;
                        case "green":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\GreenHoodie.jpg");
                            break;
                        case "yellow":
                            this.ImageBox.BackgroundImage= Image.FromFile(@"...\...\\YellowHoodie.jpg");
                            break;
                    }
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double price = 0;
            switch (type)
            {
                case "shirt":
                    price += 15;
                    break;
                case "tanktop":
                    price += 10;
                    break;
                case "hoodie":
                    price += 20;
                    break;
            }
        }
    }
}
