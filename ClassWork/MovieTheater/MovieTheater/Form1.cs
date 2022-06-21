using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheater
{
    public partial class Form1 : Form
    {
        int loginNumber = -1;
        public bool movieSelected = false;
        public bool theaterSelected = false;
        public string[] movies =
        {
            "Once upon a time in Hollywood",
            "The Nightingale",
            "Blinded by the light",
            "Dumbo",
            "Lion King"
        };
        public string[] theaters =
        {
            "110 E Main St.",
            "5210 S Gilmore St.",
            "42069 N Sixty-Nineth Ave."
        };
        string[] timeSet1 =
        {
            "9:30 AM",
            "11:00 AM",
            "12:00 PM",
            "1:00 PM",
            "4:00 PM",
            "6:00 PM"
        };
        string[] timeSet2 =
        {
            "10:30 AM",
            "12:00 PM",
            "1:30 PM",
            "3:00 PM",
            "5:00 PM",
            "9:00 PM"
        };
        string[] timeSet3 =
        {
            "8:30 AM",
            "10:00 AM",
            "11:30 AM",
            "1:30 PM",
            "2:45 PM",
            "6:00 PM"
        };
        bool ticketSales = false;
        string[] password = System.IO.File.ReadAllLines(@"...\...\\passwords.txt");
        string[] usernames = System.IO.File.ReadAllLines(@"...\...\\usernames.txt");
        int[,,] seatAvalabilatyArray =
        {
            {
                {15, 25, 45, 90, 10, 0},
                {24, 12, 2, 55, 0, 100},
                {74, 14, 81, 92, 19, 2},
            },
            {
                {43, 57, 20, 31, 36, 78},
                {15, 58, 4,  16, 5, 96},
                {44, 56, 76, 80, 82, 37}
            },
            {
                {10, 6, 10, 7, 15, 9},
                {18, 36, 75, 4, 88, 93 },
                {53, 56, 96, 53, 97, 33}
            },
            {
                {23, 91, 15, 76, 32, 65},
                {74, 14, 81, 92, 19, 2},
                {43, 57, 20, 31, 36, 78},
            },
            {
                {15, 25, 45, 90, 10, 0},
                {18, 36, 75, 4, 88, 93 },
                {15, 58, 4,  16, 5, 96},
            }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void MovieList_SelectedIndexChanged(object sender, EventArgs e)
        {
            movieSelected = true;
            ShowTime();
        }
        public void ShowTime()
        {
            if (movieSelected && theaterSelected)
            {
                if (MovieList.SelectedIndex == 0)
                {
                    if (TheaterList.SelectedIndex == 0)
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet1.Length; i++)
                        {
                            TimeList.Items.Add(timeSet1[i]);
                        }
                    }
                    else if (TheaterList.SelectedIndex == 1)
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet2.Length; i++)
                        {
                            TimeList.Items.Add(timeSet2[i]);
                        }
                    }
                    else
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet3.Length; i++)
                        {
                            TimeList.Items.Add(timeSet3[i]);
                        }
                    }
                }
                else if (MovieList.SelectedIndex == 1)
                {
                    if (TheaterList.SelectedIndex == 0)
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet2.Length; i++)
                        {
                            TimeList.Items.Add(timeSet2[i]);
                        }
                    }
                    else if (TheaterList.SelectedIndex == 1)
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet3.Length; i++)
                        {
                            TimeList.Items.Add(timeSet3[i]);
                        }
                    }
                    else
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet1.Length; i++)
                        {
                            TimeList.Items.Add(timeSet1[i]);
                        }
                    }
                }
                else if (MovieList.SelectedIndex == 2)
                {
                    if (TheaterList.SelectedIndex == 0)
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet2.Length; i++)
                        {
                            TimeList.Items.Add(timeSet2[i]);
                        }
                    }
                    else if (TheaterList.SelectedIndex == 1)
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet3.Length; i++)
                        {
                            TimeList.Items.Add(timeSet3[i]);
                        }
                    }
                    else
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet1.Length; i++)
                        {
                            TimeList.Items.Add(timeSet1[i]);
                        }
                    }
                }
                else if (MovieList.SelectedIndex == 3)
                {
                    if (TheaterList.SelectedIndex == 0)
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet1.Length; i++)
                        {
                            TimeList.Items.Add(timeSet1[i]);
                        }
                    }
                    else if (TheaterList.SelectedIndex == 1)
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet2.Length; i++)
                        {
                            TimeList.Items.Add(timeSet2[i]);
                        }
                    }
                    else
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet3.Length; i++)
                        {
                            TimeList.Items.Add(timeSet3[i]);
                        }
                    }
                }
                else if (MovieList.SelectedIndex == 4)
                {
                    if (TheaterList.SelectedIndex == 0)
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet3.Length; i++)
                        {
                            TimeList.Items.Add(timeSet3[i]);
                        }
                    }
                    else if (TheaterList.SelectedIndex == 1)
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet1.Length; i++)
                        {
                            TimeList.Items.Add(timeSet1[i]);
                        }
                    }
                    else
                    {
                        int count = TimeList.Items.Count;
                        for (int i = 0; i < count; i++)
                        {
                            TimeList.Items.RemoveAt(0);
                        }
                        for (int i = 0; i < timeSet2.Length; i++)
                        {
                            TimeList.Items.Add(timeSet2[i]);
                        }
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            int count = MovieList.Items.Count;
            for (int i = 0; i < count; i++)
            {
                MovieList.Items.RemoveAt(0);
            }
            count = TheaterList.Items.Count;
            for (int i = 0; i < count; i++)
            {
                TheaterList.Items.RemoveAt(0);
            }
            for (int i = 0; i < movies.Length; i++)
            {
                MovieList.Items.Add(movies[i]);
            }
            for (int i = 0; i < theaters.Length; i++)
            {
                TheaterList.Items.Add(theaters[i]);
            }
             count = TimeList.Items.Count;
            for (int i = 0; i < count; i++)
            {
                TimeList.Items.RemoveAt(0);
            }
            numericUpDown1.Value = 0;
            ticketSales = false;
            movieTitle.SendToBack();
            movieTitle.Visible = false;
            theatersTitle.SendToBack();
            theatersTitle.Visible = false;
            movieEditBox.SendToBack();
            movieEditBox.Visible = false;
            theatersEditBox.SendToBack();
            theatersEditBox.Visible = false;
            SubmitChanges.SendToBack();
            SubmitChanges.Visible = false;
            extraBackground.SendToBack();
            extraBackground.Visible = false;
            
            usernameBox.SendToBack();
            usernameBox.Visible = false;
            passwordBox.SendToBack();
            passwordBox.Visible = false;
            loginSubmitButton.SendToBack();
            loginSubmitButton.Visible = false;
        }

        private void TheaterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            theaterSelected = true;
            ShowTime();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            extraBackground.BringToFront();
            extraBackground.Visible = true;
            usernameBox.BringToFront();
            usernameBox.Visible = true;
            passwordBox.BringToFront();
            passwordBox.Visible = true;
            loginSubmitButton.BringToFront();
            loginSubmitButton.Visible = true;
        }

        private void TimeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TimeList.SelectedIndex != -1)
            {
                seatAvalibility.Text = seatAvalabilatyArray[MovieList.SelectedIndex, TheaterList.SelectedIndex, TimeList.SelectedIndex] + "/100 are avalible";
                if (numericUpDown1.Value != 0)
                {
                    purchaseTickets.Enabled = true;
                }
                else
                {
                    purchaseTickets.Enabled = false;
                }
            }
            else
            {
                purchaseTickets.Enabled = false;
                seatAvalibility.Text = "";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (TimeList.SelectedIndex != -1 && numericUpDown1.Value > 0)
            {
                purchaseTickets.Enabled = true;
            }
            else
            {
                purchaseTickets.Enabled = false;
            }
        }

        private void purchaseTickets_Click(object sender, EventArgs e)
        {
            if (seatAvalabilatyArray[MovieList.SelectedIndex, TheaterList.SelectedIndex, TimeList.SelectedIndex] - numericUpDown1.Value < 0)
            {
                MessageBox.Show("There is not that many avaliable seats, sorry for any inconvenience.");
            }
            else
            {
                if (MovieList.SelectedIndex < 2)
                {
                    AgeChecker();
                }
                else
                {
                    MessageBox.Show("Thank you for purchasing tickets. Have a great viewing experience");
                    seatAvalabilatyArray[MovieList.SelectedIndex, TheaterList.SelectedIndex, TimeList.SelectedIndex] -= Convert.ToInt32(numericUpDown1.Value);
                    Reset();
                }
            }
        }
        public void AgeChecker()
        {
            extraBackground.BringToFront();
            extraBackground.Visible = true;
            dateTimePicker1.BringToFront();
            dateTimePicker1.Visible = true;
            ageTextBox.BringToFront();
            ageTextBox.Visible = true;
            enterAgeButton.BringToFront();
            enterAgeButton.Visible = true;
        }
        public void AgeCheckerClose()
        {
            extraBackground.SendToBack();
            extraBackground.Visible = false;
            dateTimePicker1.SendToBack();
            dateTimePicker1.Visible = false;
            ageTextBox.SendToBack();
            ageTextBox.Visible = false;
            enterAgeButton.SendToBack();
            enterAgeButton.Visible = false;
        }
        private void enterAgeButton_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            if (today.Year - dateTimePicker1.Value.Year >= 17)
            {
                ticketSales = true;
                AgeCheckerClose();
                if (ticketSales == true)
                {
                    MessageBox.Show("Thank you for purchasing tickets. Have a great viewing experience");
                    seatAvalabilatyArray[MovieList.SelectedIndex, TheaterList.SelectedIndex, TimeList.SelectedIndex] -= Convert.ToInt32(numericUpDown1.Value);
                    Reset();
                }
            }
            else if (today.Year - dateTimePicker1.Value.Year == 16)
            {
                if (today.Month - dateTimePicker1.Value.Month < 0)
                {
                    ticketSales = true;
                    AgeCheckerClose();
                    if (ticketSales == true)
                    {
                        MessageBox.Show("Thank you for purchasing tickets. Have a great viewing experience");
                        seatAvalabilatyArray[MovieList.SelectedIndex, TheaterList.SelectedIndex, TimeList.SelectedIndex] -= Convert.ToInt32(numericUpDown1.Value);
                        Reset();
                    }
                }
            }
            else
            {
                MessageBox.Show("You are too young to see this movie");
                AgeCheckerClose();
                Reset();
            }

        }

        private void extraBackground_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginSubmitButton_Click(object sender, EventArgs e)
        {
            bool login = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (usernameBox.Text == usernames[i] || usernameBox.Text == "Usernames: " + usernames[i])
                {
                    if (passwordBox.Text == password[i] || passwordBox.Text == "Password: " + password[i])
                    {
                        loginNumber = i;
                        login = true;
                    }
                }
            }
            if (login == false)
            {
                MessageBox.Show("Wrong username and/or password");
                Reset();
            }
            else
            {
                loggedin();
            }
        }
        public void loggedin()
        {
            movieTitle.BringToFront();
            movieTitle.Visible = true;
            theatersTitle.BringToFront();
            theatersTitle.Visible = true;
            movieEditBox.BringToFront();
            movieEditBox.Visible = true;
            theatersEditBox.BringToFront();
            theatersEditBox.Visible = true;
            SubmitChanges.BringToFront();
            SubmitChanges.Visible = true;
            ChangePassword.BringToFront();
            ChangePassword.Visible = true;
            
            usernameBox.SendToBack();
            usernameBox.Visible = false;
            passwordBox.SendToBack();
            passwordBox.Visible = false;
            loginSubmitButton.SendToBack();
            loginSubmitButton.Visible = false;

            movieEditBox.Text = "";
            theatersEditBox.Text = "";
            for (int i = 0; i < movies.Length; i++)
            {
                movieEditBox.Text += movies[i] + ";\r\n";
            }
            for (int i = 0; i < theaters.Length; i++)
            {
                theatersEditBox.Text += theaters[i] + ";\r\n";
            }
        }

        private void SubmitChanges_Click(object sender, EventArgs e)
        {
            string[] newMovies = movieEditBox.Text.Split(Convert.ToChar(";"));
            string[] newTheaters = theatersEditBox.Text.Split(Convert.ToChar(";"));
            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = newMovies[i];
            }
            for (int i = 0; i < theaters.Length; i++)
            {
                theaters[i] = newTheaters[i];
            }
            
            Reset();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            extraBackground.BringToFront();
            newPasswordBox.BringToFront();
            newPasswordBox.Visible = true;
            submitPasswordChange.Visible = true;
            submitPasswordChange.BringToFront();
        }

        private void submitPasswordChange_Click(object sender, EventArgs e)
        {
            password[loginNumber] = newPasswordBox.Text;
            MessageBox.Show("boop");
            System.IO.File.WriteAllLines(@"...\...\\passwords.txt", password);
        }
    }
}