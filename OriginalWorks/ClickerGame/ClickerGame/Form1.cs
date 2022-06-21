using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        // Starting Stats
        
        public const double multiplire = 1.04;

        public static double boozePerClick = 1;
        public static double booze = 0;

        public static double toiletCost = 250;
        public static double toiletCount = 0;
        public static double toiletBPS = 1;

        public static double bathtubCost = 500;
        public static double bathtubCount = 0;
        public static double bathtubBPS = 5;

        public static double carCost = 1000;
        public static double carCount = 0;
        public static double carBPS = 10;

        public static double kegCost = 5000;
        public static double kegCount = 0;
        public static double kegBPS = 25;

        public static double barCost = 20000;
        public static double barCount = 0;
        public static double barBPS = 75;

        public static double sevenCost = 35000;
        public static double sevenCount = 0;
        public static double sevenBPS = 125;

        public static double plantCost = 75000;
        public static double plantCount = 0;
        public static double plantBPS = 300;

        public static double slavCost = 125000;
        public static double slavCount = 0;
        public static double slavBPS = 500;

        public static double factoryCost = 350000;
        public static double factoryCount = 0;
        public static double factoryBPS = 1000;

        public static double portalCost = 1000000;
        public static double portalCount = 0;
        public static double portalBPS = 3000;

        public static double clickUpgradeCost = 25000;

        public static double buttonColorCost = 10;

        public static double backgroundColorCost = 10;

        public static double BPSIncreaseCost = 25000;
        public static double BPSIncreaseMod = 1;

        public static int[] achievementNumber = new int[]
        {
            10, 25, 100, 500, 1000
        };

        static public bool[,] achievementBool = new bool[,]
        {
            {false, false, false, false, false},
            {false, false, false, false, false},
            {false, false, false, false, false},
            {false, false, false, false, false},
            {false, false, false, false, false},
            {false, false, false, false, false},
            {false, false, false, false, false},
            {false, false, false, false, false},
            {false, false, false, false, false},
            {false, false, false, false, false}
        };
        public Form1()
        {
            InitializeComponent();
            DrawText();
        }

        private void DrawText()
        {
            PrisonToilet.Text = "Prison Toilet \n cost: " + toiletCost + "\n produces " + toiletBPS + "/sec\n you have " + toiletCount;
            bathtubMoonshine.Text = "Bathtub Moonshine \n cost: " + bathtubCost + "\n produces " + bathtubBPS + "/sec\n you have " + bathtubCount;
            carRadiater.Text = "Car Radiater \n cost: " + carCost + "\n produces " + carBPS + "/sec\n you have " + carCount;
            keg.Text = "Keg \n cost: " + kegCost + "\n produces " + kegBPS + "/sec\n you have " + kegCount;
            bar.Text = "Bar \n cost: " + barCost + "\n produces " + barBPS + "/sec\n you have " + barCount;
            sevenEleven.Text = "Seven Eleven \n cost: " + sevenCost + "\n produces " + sevenBPS + "/sec\n you have " + sevenCount;
            plantation.Text = "Plantaion \n cost: " + plantCost + "\n produces " + plantBPS + "/sec\n you have " + plantCount;
            slavArmy.Text = "Slav Army \n cost: " + slavCost + "\n produces " + slavBPS + "/sec\n you have " + slavCount;
            factory.Text = "Factory \n cost: " + factoryCost + "\n produces " + factoryBPS + "/sec\n you have " + factoryCount;
            timePortal.Text = "Time Portal \n cost: " + portalCost + "\n produces " + portalBPS + "/sec\n you have " + portalCount;
            clickUpgrade.Text = "Click Upgrade \n cost: " + clickUpgradeCost + "\n You get: " + boozePerClick + " per click";
            buttonColorChange.Text = "Change Button Colors \n Cost: " + buttonColorCost;
            backgroundColorChange.Text = "Change Background Coror \n Cost: " + backgroundColorCost;
            bpsIncreese.Text = "Increase booze/sec \n Cost: " + BPSIncreaseCost + " Current mod: " + BPSIncreaseMod;
            createBooze.Text = "Create booze";
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Create.Enabled = false;
            Create.Enabled = true;
            booze = booze + boozePerClick;
        }

        private void PrisonToilet_Click(object sender, EventArgs e)
        {
            if (booze >= toiletCost)
            {
                booze = booze - toiletCost;
                toiletCount++;
                toiletCost = Math.Ceiling(toiletCost * multiplire);
            }
            DrawText();
        }

        private void bathtubMoonshine_Click(object sender, EventArgs e)
        {
            if (booze >= bathtubCost)
            {
                booze = booze - bathtubCost;
                bathtubCount++;
                bathtubCost = Math.Ceiling(bathtubCost * multiplire);
            }
            DrawText();
        }

        private void carRadiater_Click(object sender, EventArgs e)
        {
            if (booze >= carCost)
            {
                booze = booze - carCost;
                carCount++;
                carCost = Math.Ceiling(carCost * multiplire);
            }
            DrawText();
        }

        private void keg_Click(object sender, EventArgs e)
        {
            if (booze >= kegCost)
            {
                booze = booze - kegCost;
                kegCount++;
                kegCost = Math.Ceiling(kegCost * multiplire);
            }
            DrawText();
        }

        private void bar_Click(object sender, EventArgs e)
        {
            if (booze >= barCost)
            {
                booze = booze - barCost;
                barCount++;
                barCost = Math.Ceiling(barCost * multiplire);
            }
            DrawText();
        }

        private void sevenEleven_Click(object sender, EventArgs e)
        {
            if (booze >= sevenCost)
            {
                booze = booze - sevenCost;
                sevenCount++;
                sevenCost = Math.Ceiling(sevenCost * multiplire);
            }
            DrawText();
        }

        private void plantation_Click(object sender, EventArgs e)
        {
            if (booze >= plantCost)
            {
                booze = booze - plantCost;
                plantCount++;
                plantCost = Math.Ceiling(plantCost * multiplire);
            }
            DrawText();
        }

        private void slavArmy_Click(object sender, EventArgs e)
        {
            if (booze >= slavCost)
            {
                booze = booze - slavCost;
                slavCount++;
                slavCost = Math.Ceiling(slavCost * multiplire);
            }
            DrawText();
        }

        private void factory_Click(object sender, EventArgs e)
        {
            if (booze >= factoryCost)
            {
                booze = booze - factoryCost;
                factoryCount++;
                factoryCost = Math.Ceiling(factoryCost * multiplire);
            }
            DrawText();
        }

        private void timePortal_Click(object sender, EventArgs e)
        {
            if (booze >= portalCost)
            {
                booze = booze - portalCost;
                portalCount++;
                portalCost = Math.Ceiling(portalCost * multiplire);
            }
            DrawText();
        }

        private void boozePerSecond_Tick(object sender, EventArgs e)
        {
            double boozePerSecond = (Math.Floor(1000 * (((toiletBPS * toiletCount) + (bathtubBPS * bathtubCount) + (carBPS * carCount) + (kegBPS * kegCount) + (barBPS * barCount) + (sevenBPS * sevenCount) + (plantBPS * plantCount) + (slavBPS * slavCount) + (factoryBPS * factoryCount) + (portalBPS * portalCount)) * BPSIncreaseMod) / 4)) / 1000;
            booze = booze + boozePerSecond;
            booze = (Math.Floor(1000 * booze)) / 1000;
            boozeCount.Text = "booze: " + booze;
            
            if (booze >= toiletCost)
            {
                PrisonToilet.Enabled = true;
            }
            else
            {
                PrisonToilet.Enabled = false;
            }
            if (booze >= bathtubCost)
            {
                bathtubMoonshine.Enabled = true;
            }
            else
            {
                bathtubMoonshine.Enabled = false;
            }
            if (booze >= carCost)
            {
                carRadiater.Enabled = true;
            }
            else
            {
                carRadiater.Enabled = false;
            }
            if (booze >= kegCost)
            {
                keg.Enabled = true;
            }
            else
            {
                keg.Enabled = false;
            }
            if (booze >= barCost)
            {
                bar.Enabled = true;
            }
            else
            {
                bar.Enabled = false;
            }
            if (booze >= sevenCost)
            {
                sevenEleven.Enabled = true;
            }
            else
            {
                sevenEleven.Enabled = false;
            }
            if (booze >= plantCost)
            {
                plantation.Enabled = true;
            }
            else
            {
                plantation.Enabled = false;
            }
            if (booze >= slavCost)
            {
                slavArmy.Enabled = true;
            }
            else
            {
                slavArmy.Enabled = false;
            }
            if (booze >= factoryCost)
            {
                factory.Enabled = true;
            }
            else
            {
                factory.Enabled = false;
            }
            if (booze >= portalCost)
            {
                timePortal.Enabled = true;
            }
            else
            {
                timePortal.Enabled = false;
            }
            if (booze >= buttonColorCost)
            {
                buttonColorChange.Enabled = true;
            }
            else
            {
                buttonColorChange.Enabled = false;
            }
            if (booze >= backgroundColorCost)
            {
                backgroundColorChange.Enabled = true;
            }
            else
            {
                backgroundColorChange.Enabled = false;
            }
            if (booze >= BPSIncreaseCost)
            {
                bpsIncreese.Enabled = true;
            }
            else
            {
                bpsIncreese.Enabled = false;
            }
            if (booze >= clickUpgradeCost)
            {
                clickUpgrade.Enabled = true;
            }
            else
            {
                clickUpgrade.Enabled = false;
            }
        }

        private void Achievment_Click(object sender, EventArgs e)
        {
            Achievment.Enabled = false;
            Achievment.Enabled = true;
            achievementBox.Text = "Toilet 1: " + achievementBool[0,0];
            achievementBox.Text += " Toilet 2: " + achievementBool[0, 1];
            achievementBox.Text += " Toilet 3: " + achievementBool[0, 2];
            achievementBox.Text += " Toilet 4: " + achievementBool[0, 3];
            achievementBox.Text += " Toilet 5: " + achievementBool[0, 4];

            achievementBox.Text += System.Environment.NewLine + "Bathtub 1: " + achievementBool[1, 0];
            achievementBox.Text += " Bathtub 2: " + achievementBool[1, 1];
            achievementBox.Text += " Bathtub 3: " + achievementBool[1, 2];
            achievementBox.Text += " Bathtub 4: " + achievementBool[1, 3];
            achievementBox.Text += " Bathtub 5: " + achievementBool[1, 4];

            achievementBox.Text += System.Environment.NewLine + "Car 1: " + achievementBool[2, 0];
            achievementBox.Text += " Car 2: " + achievementBool[2, 1];
            achievementBox.Text += " Car 3: " + achievementBool[2, 2];
            achievementBox.Text += " Car 4: " + achievementBool[2, 3];
            achievementBox.Text += " Car 5: " + achievementBool[2, 4];

            achievementBox.Text += System.Environment.NewLine + "Keg 1: " + achievementBool[3, 0];
            achievementBox.Text += " Keg 2: " + achievementBool[3, 1];
            achievementBox.Text += " Keg 3: " + achievementBool[3, 2];
            achievementBox.Text += " Keg 4: " + achievementBool[3, 3];
            achievementBox.Text += " Keg 5: " + achievementBool[3, 4];

            achievementBox.Text += System.Environment.NewLine + "Bar 1: " + achievementBool[4, 0];
            achievementBox.Text += " Bar 2: " + achievementBool[4, 1];
            achievementBox.Text += " Bar 3: " + achievementBool[4, 2];
            achievementBox.Text += " Bar 4: " + achievementBool[4, 3];
            achievementBox.Text += " Bar 5: " + achievementBool[4, 4];

            achievementBox.Text += System.Environment.NewLine + "Seven Eleven 1: " + achievementBool[5, 0];
            achievementBox.Text += " Seven Eleven 2: " + achievementBool[5, 1];
            achievementBox.Text += " Seven Eleven 3: " + achievementBool[5, 2];
            achievementBox.Text += " Seven Eleven 4: " + achievementBool[5, 3];
            achievementBox.Text += " Seven Eleven 5: " + achievementBool[5, 4];

            achievementBox.Text += System.Environment.NewLine + "Plantation 1: " + achievementBool[6, 0];
            achievementBox.Text += " Plantation 2: " + achievementBool[6, 1];
            achievementBox.Text += " Plantation 3: " + achievementBool[6, 2];
            achievementBox.Text += " Plantation 4: " + achievementBool[6, 3];
            achievementBox.Text += " Plantation 5: " + achievementBool[6, 4];

            achievementBox.Text += System.Environment.NewLine + "Slav Army 1: " + achievementBool[7, 0];
            achievementBox.Text += " Slav Army 2: " + achievementBool[7, 1];
            achievementBox.Text += " Slav Army 3: " + achievementBool[7, 2];
            achievementBox.Text += " Slav Army 4: " + achievementBool[7, 3];
            achievementBox.Text += " Slav Army 5: " + achievementBool[7, 4];

            achievementBox.Text += System.Environment.NewLine + "Factory 1: " + achievementBool[8, 0];
            achievementBox.Text += " Factory 2: " + achievementBool[8, 1];
            achievementBox.Text += " Factory 3: " + achievementBool[8, 2];
            achievementBox.Text += " Factory 4: " + achievementBool[8, 3];
            achievementBox.Text += " Factory 5: " + achievementBool[8, 4];

            achievementBox.Text += System.Environment.NewLine + "Time Portal 1: " + achievementBool[9, 0];
            achievementBox.Text += " Time Portal 2: " + achievementBool[9, 1];
            achievementBox.Text += " Time Portal 3: " + achievementBool[9, 2];
            achievementBox.Text += " Time Portal 4: " + achievementBool[9, 3];
            achievementBox.Text += " Time Portal 5: " + achievementBool[9, 4];
            if (achievementBox.Visible == false)
            {
                achievementBox.Visible = true;
                achievementBox.BringToFront();
                Achievment.BringToFront();
            }
            else
            {
                achievementBox.Visible = false;
                achievementBox.SendToBack();
            }
            distract.Focus();
            
        }

        private void clickUpgrade_Click(object sender, EventArgs e)
        {
            if (booze > clickUpgradeCost)
            {
                booze = booze - clickUpgradeCost;
                boozePerClick = boozePerClick * 2;
                clickUpgradeCost = clickUpgradeCost * 2;
                DrawText();
            }
        }

        private void buttonColorChange_Click(object sender, EventArgs e)
        {
            buttonColorChange.Enabled = false;
            buttonColorChange.Enabled = true;
            Random rnd = new Random();
            int rando = rnd.Next(10);
            if (rando == 0)
            {
                Create.BackColor = System.Drawing.Color.Red;
                carRadiater.BackColor = System.Drawing.Color.Red;
                bathtubMoonshine.BackColor = System.Drawing.Color.Red;
                keg.BackColor = System.Drawing.Color.Red;
                plantation.BackColor = System.Drawing.Color.Red;
                slavArmy.BackColor = System.Drawing.Color.Red;
                timePortal.BackColor = System.Drawing.Color.Red;
                backgroundColorChange.BackColor = System.Drawing.Color.Red;
                clickUpgrade.BackColor = System.Drawing.Color.Red;
                buttonColorChange.BackColor = System.Drawing.Color.Red;
                bpsIncreese.BackColor = System.Drawing.Color.Red;
                Achievment.BackColor = System.Drawing.Color.Red;
                factory.BackColor = System.Drawing.Color.Red;
                sevenEleven.BackColor = System.Drawing.Color.Red;
                PrisonToilet.BackColor = System.Drawing.Color.Red;
                bar.BackColor = System.Drawing.Color.Red;
            }
            else if (rando == 1)
            {
                Create.BackColor = System.Drawing.Color.Blue;
                carRadiater.BackColor = System.Drawing.Color.Blue;
                bathtubMoonshine.BackColor = System.Drawing.Color.Blue;
                keg.BackColor = System.Drawing.Color.Blue;
                plantation.BackColor = System.Drawing.Color.Blue;
                slavArmy.BackColor = System.Drawing.Color.Blue;
                timePortal.BackColor = System.Drawing.Color.Blue;
                backgroundColorChange.BackColor = System.Drawing.Color.Blue;
                clickUpgrade.BackColor = System.Drawing.Color.Blue;
                buttonColorChange.BackColor = System.Drawing.Color.Blue;
                bpsIncreese.BackColor = System.Drawing.Color.Blue;
                Achievment.BackColor = System.Drawing.Color.Blue;
                factory.BackColor = System.Drawing.Color.Blue;
                sevenEleven.BackColor = System.Drawing.Color.Blue;
                PrisonToilet.BackColor = System.Drawing.Color.Blue;
                bar.BackColor = System.Drawing.Color.Blue;
            }
            else if (rando == 2)
            {
                Create.BackColor = System.Drawing.Color.Yellow;
                carRadiater.BackColor = System.Drawing.Color.Yellow;
                bathtubMoonshine.BackColor = System.Drawing.Color.Yellow;
                keg.BackColor = System.Drawing.Color.Yellow;
                plantation.BackColor = System.Drawing.Color.Yellow;
                slavArmy.BackColor = System.Drawing.Color.Yellow;
                timePortal.BackColor = System.Drawing.Color.Yellow;
                backgroundColorChange.BackColor = System.Drawing.Color.Yellow;
                clickUpgrade.BackColor = System.Drawing.Color.Yellow;
                buttonColorChange.BackColor = System.Drawing.Color.Yellow;
                bpsIncreese.BackColor = System.Drawing.Color.Yellow;
                Achievment.BackColor = System.Drawing.Color.Yellow;
                factory.BackColor = System.Drawing.Color.Yellow;
                sevenEleven.BackColor = System.Drawing.Color.Yellow;
                PrisonToilet.BackColor = System.Drawing.Color.Yellow;
                bar.BackColor = System.Drawing.Color.Yellow;
            }
            else if (rando == 3)
            {
                Create.BackColor = System.Drawing.Color.Green;
                carRadiater.BackColor = System.Drawing.Color.Green;
                bathtubMoonshine.BackColor = System.Drawing.Color.Green;
                keg.BackColor = System.Drawing.Color.Green;
                plantation.BackColor = System.Drawing.Color.Green;
                slavArmy.BackColor = System.Drawing.Color.Green;
                timePortal.BackColor = System.Drawing.Color.Green;
                backgroundColorChange.BackColor = System.Drawing.Color.Green;
                clickUpgrade.BackColor = System.Drawing.Color.Green;
                buttonColorChange.BackColor = System.Drawing.Color.Green;
                bpsIncreese.BackColor = System.Drawing.Color.Green;
                Achievment.BackColor = System.Drawing.Color.Green;
                factory.BackColor = System.Drawing.Color.Green;
                sevenEleven.BackColor = System.Drawing.Color.Green;
                PrisonToilet.BackColor = System.Drawing.Color.Green;
                bar.BackColor = System.Drawing.Color.Green;
            }
            else if (rando == 4)
            {
                Create.BackColor = System.Drawing.Color.White;
                carRadiater.BackColor = System.Drawing.Color.White;
                bathtubMoonshine.BackColor = System.Drawing.Color.White;
                keg.BackColor = System.Drawing.Color.White;
                plantation.BackColor = System.Drawing.Color.White;
                slavArmy.BackColor = System.Drawing.Color.White;
                timePortal.BackColor = System.Drawing.Color.White;
                backgroundColorChange.BackColor = System.Drawing.Color.White;
                clickUpgrade.BackColor = System.Drawing.Color.White;
                buttonColorChange.BackColor = System.Drawing.Color.White;
                bpsIncreese.BackColor = System.Drawing.Color.White;
                Achievment.BackColor = System.Drawing.Color.White;
                factory.BackColor = System.Drawing.Color.White;
                sevenEleven.BackColor = System.Drawing.Color.White;
                PrisonToilet.BackColor = System.Drawing.Color.White;
                bar.BackColor = System.Drawing.Color.White;
            }
            else if (rando == 5)
            {
                Create.BackColor = System.Drawing.Color.Cyan;
                carRadiater.BackColor = System.Drawing.Color.Cyan;
                bathtubMoonshine.BackColor = System.Drawing.Color.Cyan;
                keg.BackColor = System.Drawing.Color.Cyan;
                plantation.BackColor = System.Drawing.Color.Cyan;
                slavArmy.BackColor = System.Drawing.Color.Cyan;
                timePortal.BackColor = System.Drawing.Color.Cyan;
                backgroundColorChange.BackColor = System.Drawing.Color.Cyan;
                clickUpgrade.BackColor = System.Drawing.Color.Cyan;
                buttonColorChange.BackColor = System.Drawing.Color.Cyan;
                bpsIncreese.BackColor = System.Drawing.Color.Cyan;
                Achievment.BackColor = System.Drawing.Color.Cyan;
                factory.BackColor = System.Drawing.Color.Cyan;
                sevenEleven.BackColor = System.Drawing.Color.Cyan;
                PrisonToilet.BackColor = System.Drawing.Color.Cyan;
                bar.BackColor = System.Drawing.Color.Cyan;
            }
            else if (rando == 6)
            {
                Create.BackColor = System.Drawing.Color.Indigo;
                carRadiater.BackColor = System.Drawing.Color.Indigo;
                bathtubMoonshine.BackColor = System.Drawing.Color.Indigo;
                keg.BackColor = System.Drawing.Color.Indigo;
                plantation.BackColor = System.Drawing.Color.Indigo;
                slavArmy.BackColor = System.Drawing.Color.Indigo;
                timePortal.BackColor = System.Drawing.Color.Indigo;
                backgroundColorChange.BackColor = System.Drawing.Color.Indigo;
                clickUpgrade.BackColor = System.Drawing.Color.Indigo;
                buttonColorChange.BackColor = System.Drawing.Color.Indigo;
                bpsIncreese.BackColor = System.Drawing.Color.Indigo;
                Achievment.BackColor = System.Drawing.Color.Indigo;
                factory.BackColor = System.Drawing.Color.Indigo;
                sevenEleven.BackColor = System.Drawing.Color.Indigo;
                PrisonToilet.BackColor = System.Drawing.Color.Indigo;
                bar.BackColor = System.Drawing.Color.Indigo;
            }
            else if (rando == 7)
            {
                Create.BackColor = System.Drawing.Color.Crimson;
                carRadiater.BackColor = System.Drawing.Color.Crimson;
                bathtubMoonshine.BackColor = System.Drawing.Color.Crimson;
                keg.BackColor = System.Drawing.Color.Crimson;
                plantation.BackColor = System.Drawing.Color.Crimson;
                slavArmy.BackColor = System.Drawing.Color.Crimson;
                timePortal.BackColor = System.Drawing.Color.Crimson;
                backgroundColorChange.BackColor = System.Drawing.Color.Crimson;
                clickUpgrade.BackColor = System.Drawing.Color.Crimson;
                buttonColorChange.BackColor = System.Drawing.Color.Crimson;
                bpsIncreese.BackColor = System.Drawing.Color.Crimson;
                Achievment.BackColor = System.Drawing.Color.Crimson;
                factory.BackColor = System.Drawing.Color.Crimson;
                sevenEleven.BackColor = System.Drawing.Color.Crimson;
                PrisonToilet.BackColor = System.Drawing.Color.Crimson;
                bar.BackColor = System.Drawing.Color.Crimson;
            }
            else if (rando == 8)
            {
                Create.BackColor = System.Drawing.Color.Gold;
                carRadiater.BackColor = System.Drawing.Color.Gold;
                bathtubMoonshine.BackColor = System.Drawing.Color.Gold;
                keg.BackColor = System.Drawing.Color.Gold;
                plantation.BackColor = System.Drawing.Color.Gold;
                slavArmy.BackColor = System.Drawing.Color.Gold;
                timePortal.BackColor = System.Drawing.Color.Gold;
                backgroundColorChange.BackColor = System.Drawing.Color.Gold;
                clickUpgrade.BackColor = System.Drawing.Color.Gold;
                buttonColorChange.BackColor = System.Drawing.Color.Gold;
                bpsIncreese.BackColor = System.Drawing.Color.Gold;
                Achievment.BackColor = System.Drawing.Color.Gold;
                factory.BackColor = System.Drawing.Color.Gold;
                sevenEleven.BackColor = System.Drawing.Color.Gold;
                PrisonToilet.BackColor = System.Drawing.Color.Gold;
                bar.BackColor = System.Drawing.Color.Gold;
            }
            else if (rando == 9)
            {
                Create.BackColor = System.Drawing.Color.Orange;
                carRadiater.BackColor = System.Drawing.Color.Orange;
                bathtubMoonshine.BackColor = System.Drawing.Color.Orange;
                keg.BackColor = System.Drawing.Color.Orange;
                plantation.BackColor = System.Drawing.Color.Orange;
                slavArmy.BackColor = System.Drawing.Color.Orange;
                timePortal.BackColor = System.Drawing.Color.Orange;
                backgroundColorChange.BackColor = System.Drawing.Color.Orange;
                clickUpgrade.BackColor = System.Drawing.Color.Orange;
                buttonColorChange.BackColor = System.Drawing.Color.Orange;
                bpsIncreese.BackColor = System.Drawing.Color.Orange;
                Achievment.BackColor = System.Drawing.Color.Orange;
                factory.BackColor = System.Drawing.Color.Orange;
                sevenEleven.BackColor = System.Drawing.Color.Orange;
                PrisonToilet.BackColor = System.Drawing.Color.Orange;
                bar.BackColor = System.Drawing.Color.Orange;
            }
            distract.Focus();
        }

        private void backgroundColorChange_Click(object sender, EventArgs e)
        {
            backgroundColorChange.Enabled = false;
            backgroundColorChange.Enabled = true;
            Random rnd = new Random();
            int rando = rnd.Next(10);
            if (rando == 0)
            {
                backgroundColor.BackColor = System.Drawing.Color.Red;
            }
            else if (rando == 1)
            {
                backgroundColor.BackColor = System.Drawing.Color.Blue;
            }
            else if (rando == 2)
            {
                backgroundColor.BackColor = System.Drawing.Color.Yellow;
            }
            else if (rando == 3)
            {
                backgroundColor.BackColor = System.Drawing.Color.Green;
            }
            else if (rando == 4)
            {
                backgroundColor.BackColor = System.Drawing.Color.White;
            }
            else if (rando == 5)
            {
                backgroundColor.BackColor = System.Drawing.Color.Cyan;
            }
            else if (rando == 6)
            {
                backgroundColor.BackColor = System.Drawing.Color.Indigo;
            }
            else if (rando == 7)
            {
                backgroundColor.BackColor = System.Drawing.Color.Crimson;
            }
            else if (rando == 8)
            {
                backgroundColor.BackColor = System.Drawing.Color.Gold;
            }
            else if (rando == 9)
            {
                backgroundColor.BackColor = System.Drawing.Color.Orange;
            }
            distract.Focus();
        }

        private void bpsIncreese_Click(object sender, EventArgs e)
        {
            if (booze >= BPSIncreaseCost)
            {
                booze = booze - BPSIncreaseCost;
                BPSIncreaseCost = BPSIncreaseCost * BPSIncreaseCost;
                BPSIncreaseMod = BPSIncreaseMod * 1.5;
                DrawText();
            }
        }
        
        private void achievementTimer_Tick(object sender, EventArgs e)
        {
            if (toiletCount >= achievementNumber[0])
            {
                if (achievementBool[0, 0] == false)
                {
                    toiletBPS = toiletBPS * 1.1;
                    achievementBool[0, 0] = true;
                }
                else
                {
                    if (toiletCount >= achievementNumber[1])
                    {
                        if (achievementBool[0, 1] == false)
                        {
                            toiletBPS = toiletBPS * 1.1;
                            achievementBool[0, 1] = true;
                        }
                        else
                        {
                            if (toiletCount >= achievementNumber[2])
                            {
                                if (achievementBool[0, 2] == false)
                                {
                                    toiletBPS = toiletBPS * 1.1;
                                    achievementBool[0, 2] = true;
                                }
                                else
                                {
                                    if (toiletCount >= achievementNumber[3])
                                    {
                                        if (achievementBool[0, 3] == false)
                                        {
                                            toiletBPS = toiletBPS * 1.1;
                                            achievementBool[0, 3] = true;
                                        }
                                        else
                                        {
                                            if (toiletCount >= achievementNumber[4])
                                            {
                                                if (achievementBool[0, 4] == false)
                                                {
                                                    toiletBPS = toiletBPS * 1.1;
                                                    achievementBool[0, 4] = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (bathtubCount >= achievementNumber[0])
            {
                if (achievementBool[1, 0] == false)
                {
                    bathtubBPS = bathtubBPS * 1.1;
                    achievementBool[1, 0] = true;
                }
                else
                {
                    if (bathtubCount >= achievementNumber[1])
                    {
                        if (achievementBool[1, 1] == false)
                        {
                            bathtubBPS = bathtubBPS * 1.1;
                            achievementBool[1, 1] = true;
                        }
                        else
                        {
                            if (bathtubCount >= achievementNumber[2])
                            {
                                if (achievementBool[1, 2] == false)
                                {
                                    bathtubBPS = bathtubBPS * 1.1;
                                    achievementBool[1, 2] = true;
                                }
                                else
                                {
                                    if (bathtubCount >= achievementNumber[3])
                                    {
                                        if (achievementBool[1, 3] == false)
                                        {
                                            bathtubBPS = bathtubBPS * 1.1;
                                            achievementBool[1, 3] = true;
                                        }
                                        else
                                        {
                                            if (bathtubCount >= achievementNumber[4])
                                            {
                                                if (achievementBool[1, 4] == false)
                                                {
                                                    bathtubBPS = bathtubBPS * 1.1;
                                                    achievementBool[1, 4] = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (carCount >= achievementNumber[0])
            {
                if (achievementBool[2, 0] == false)
                {
                    carBPS = carBPS * 1.1;
                    achievementBool[2, 0] = true;
                }
                else
                {
                    if (carCount >= achievementNumber[1])
                    {
                        if (achievementBool[2, 1] == false)
                        {
                            carBPS = carBPS * 1.1;
                            achievementBool[2, 1] = true;
                        }
                        else
                        {
                            if (carCount >= achievementNumber[2])
                            {
                                if (achievementBool[2, 2] == false)
                                {
                                    carBPS = carBPS * 1.1;
                                    achievementBool[2, 2] = true;
                                }
                                else
                                {
                                    if (carCount >= achievementNumber[3])
                                    {
                                        if (achievementBool[2, 3] == false)
                                        {
                                            carBPS = carBPS * 1.1;
                                            achievementBool[2, 3] = true;
                                        }
                                        else
                                        {
                                            if (carCount >= achievementNumber[4])
                                            {
                                                if (achievementBool[2, 4] == false)
                                                {
                                                    carBPS = carBPS * 1.1;
                                                    achievementBool[2, 4] = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (kegCount >= achievementNumber[0])
            {
                if (achievementBool[3, 0] == false)
                {
                    kegBPS = kegBPS * 1.1;
                    achievementBool[3, 0] = true;
                }
                else
                {
                    if (kegCount >= achievementNumber[1])
                    {
                        if (achievementBool[3, 1] == false)
                        {
                            kegBPS = kegBPS * 1.1;
                            achievementBool[3, 1] = true;
                        }
                        else
                        {
                            if (kegCount >= achievementNumber[2])
                            {
                                if (achievementBool[3, 2] == false)
                                {
                                    kegBPS = kegBPS * 1.1;
                                    achievementBool[3, 2] = true;
                                }
                                else
                                {
                                    if (kegCount >= achievementNumber[3])
                                    {
                                        if (achievementBool[3, 3] == false)
                                        {
                                            kegBPS = kegBPS * 1.1;
                                            achievementBool[3, 3] = true;
                                        }
                                        else
                                        {
                                            if (kegCount >= achievementNumber[4])
                                            {
                                                if (achievementBool[3, 4] == false)
                                                {
                                                    kegBPS = kegBPS * 1.1;
                                                    achievementBool[3, 4] = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (barCount >= achievementNumber[0])
            {
                if (achievementBool[4, 0] == false)
                {
                    barBPS = barBPS * 1.1;
                    achievementBool[4, 0] = true;
                }
                else
                {
                    if (barCount >= achievementNumber[1])
                    {
                        if (achievementBool[4, 1] == false)
                        {
                            barBPS = barBPS * 1.1;
                            achievementBool[4, 1] = true;
                        }
                        else
                        {
                            if (barCount >= achievementNumber[2])
                            {
                                if (achievementBool[4, 2] == false)
                                {
                                    barBPS = barBPS * 1.1;
                                    achievementBool[4, 2] = true;
                                }
                                else
                                {
                                    if (barCount >= achievementNumber[3])
                                    {
                                        if (achievementBool[4, 3] == false)
                                        {
                                            barBPS = barBPS * 1.1;
                                            achievementBool[4, 3] = true;
                                        }
                                        else
                                        {
                                            if (barCount >= achievementNumber[4])
                                            {
                                                if (achievementBool[4, 4] == false)
                                                {
                                                    barBPS = barBPS * 1.1;
                                                    achievementBool[4, 4] = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (sevenCount >= achievementNumber[0])
            {
                if (achievementBool[5, 0] == false)
                {
                    sevenBPS = sevenBPS * 1.1;
                    achievementBool[5, 0] = true;
                }
                else
                {
                    if (sevenCount >= achievementNumber[1])
                    {
                        if (achievementBool[5, 1] == false)
                        {
                            sevenBPS = sevenBPS * 1.1;
                            achievementBool[5, 1] = true;
                        }
                        else
                        {
                            if (sevenCount >= achievementNumber[2])
                            {
                                if (achievementBool[5, 2] == false)
                                {
                                    sevenBPS = sevenBPS * 1.1;
                                    achievementBool[5, 2] = true;
                                }
                                else
                                {
                                    if (sevenCount >= achievementNumber[3])
                                    {
                                        if (achievementBool[5, 3] == false)
                                        {
                                            sevenBPS = sevenBPS * 1.1;
                                            achievementBool[5, 3] = true;
                                        }
                                        else
                                        {
                                            if (sevenCount >= achievementNumber[4])
                                            {
                                                if (achievementBool[5, 4] == false)
                                                {
                                                    sevenBPS = sevenBPS * 1.1;
                                                    achievementBool[5, 4] = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (plantCount >= achievementNumber[0])
            {
                if (achievementBool[6, 0] == false)
                {
                    plantBPS = plantBPS * 1.1;
                    achievementBool[6, 0] = true;
                }
                else
                {
                    if (plantCount >= achievementNumber[1])
                    {
                        if (achievementBool[6, 1] == false)
                        {
                            plantBPS = plantBPS * 1.1;
                            achievementBool[6, 1] = true;
                        }
                        else
                        {
                            if (plantCount >= achievementNumber[2])
                            {
                                if (achievementBool[6, 2] == false)
                                {
                                    plantBPS = plantBPS * 1.1;
                                    achievementBool[6, 2] = true;
                                }
                                else
                                {
                                    if (plantCount >= achievementNumber[3])
                                    {
                                        if (achievementBool[6, 3] == false)
                                        {
                                            plantBPS = plantBPS * 1.1;
                                            achievementBool[6, 3] = true;
                                        }
                                        else
                                        {
                                            if (plantCount >= achievementNumber[4])
                                            {
                                                if (achievementBool[6, 4] == false)
                                                {
                                                    plantBPS = plantBPS * 1.1;
                                                    achievementBool[6, 4] = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (slavCount >= achievementNumber[0])
            {
                if (achievementBool[7, 0] == false)
                {
                    slavBPS = slavBPS * 1.1;
                    achievementBool[7, 0] = true;
                }
                else
                {
                    if (slavCount >= achievementNumber[1])
                    {
                        if (achievementBool[7, 1] == false)
                        {
                            slavBPS = slavBPS * 1.1;
                            achievementBool[7, 1] = true;
                        }
                        else
                        {
                            if (slavCount >= achievementNumber[2])
                            {
                                if (achievementBool[7, 2] == false)
                                {
                                    slavBPS = slavBPS * 1.1;
                                    achievementBool[7, 2] = true;
                                }
                                else
                                {
                                    if (slavCount >= achievementNumber[3])
                                    {
                                        if (achievementBool[7, 3] == false)
                                        {
                                            slavBPS = slavBPS * 1.1;
                                            achievementBool[7, 3] = true;
                                        }
                                        else
                                        {
                                            if (slavCount >= achievementNumber[4])
                                            {
                                                if (achievementBool[7, 4] == false)
                                                {
                                                    slavBPS = slavBPS * 1.1;
                                                    achievementBool[7, 4] = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (factoryCount >= achievementNumber[0])
            {
                if (achievementBool[8, 0] == false)
                {
                    factoryBPS = factoryBPS * 1.1;
                    achievementBool[8, 0] = true;
                }
                else
                {
                    if (factoryCount >= achievementNumber[1])
                    {
                        if (achievementBool[8, 1] == false)
                        {
                            factoryBPS = factoryBPS * 1.1;
                            achievementBool[8, 1] = true;
                        }
                        else
                        {
                            if (factoryCount >= achievementNumber[2])
                            {
                                if (achievementBool[8, 2] == false)
                                {
                                    factoryBPS = factoryBPS * 1.1;
                                    achievementBool[8, 2] = true;
                                }
                                else
                                {
                                    if (factoryCount >= achievementNumber[3])
                                    {
                                        if (achievementBool[8, 3] == false)
                                        {
                                            factoryBPS = factoryBPS * 1.1;
                                            achievementBool[8, 3] = true;
                                        }
                                        else
                                        {
                                            if (factoryCount >= achievementNumber[4])
                                            {
                                                if (achievementBool[8, 4] == false)
                                                {
                                                    factoryBPS = factoryBPS * 1.1;
                                                    achievementBool[8, 4] = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (portalCount >= achievementNumber[0])
            {
                if (achievementBool[9, 0] == false)
                {
                    portalBPS = portalBPS * 1.1;
                    achievementBool[9, 0] = true;
                }
                else
                {
                    if (portalCount >= achievementNumber[1])
                    {
                        if (achievementBool[9, 1] == false)
                        {
                            portalBPS = portalBPS * 1.1;
                            achievementBool[9, 1] = true;
                        }
                        else
                        {
                            if (portalCount >= achievementNumber[2])
                            {
                                if (achievementBool[9, 2] == false)
                                {
                                    portalBPS = portalBPS * 1.1;
                                    achievementBool[9, 2] = true;
                                }
                                else
                                {
                                    if (portalCount >= achievementNumber[3])
                                    {
                                        if (achievementBool[9, 3] == false)
                                        {
                                            portalBPS = portalBPS * 1.1;
                                            achievementBool[9, 3] = true;
                                        }
                                        else
                                        {
                                            if (portalCount >= achievementNumber[4])
                                            {
                                                if (achievementBool[9, 4] == false)
                                                {
                                                    portalBPS = portalBPS * 1.1;
                                                    achievementBool[9, 4] = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void music_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rando = rnd.Next(6);
            if (rando == 0)
            {
                SoundPlayer sp = new SoundPlayer("Rasputin.wav");
                sp.Play();
                music.Interval = 265000;
            }
            else if (rando == 1)
            {
                SoundPlayer sp = new SoundPlayer("NotGonnaTakeIt.wav");
                sp.Play();
                music.Interval = 217000;
            }
            else if (rando == 2)
            {
                SoundPlayer sp = new SoundPlayer("WeDidntStartTheFire.wav");
                sp.Play();
                music.Interval = 245000;
            }
            else if (rando == 3)
            {
                SoundPlayer sp = new SoundPlayer("HealMyBallz.wav");
                sp.Play();
                music.Interval = 198000;
            }
            else if (rando == 4)
            {
                SoundPlayer sp = new SoundPlayer("IWriteSins.wav");
                sp.Play();
                music.Interval = 185000;
            }
            else if (rando == 5)
            {
                SoundPlayer sp = new SoundPlayer("RapGod.wav");
                sp.Play();
                music.Interval = 369000;
            }
            else
            {
                SoundPlayer sp = new SoundPlayer("Rasputin.wav");
                sp.Play();
                music.Interval = 265000;
            }
            
            distract.Focus();
            
        }

        private void createBooze_Click(object sender, EventArgs e)
        {
            booze += boozePerClick;
            distract.Focus();
        }
    }
}
