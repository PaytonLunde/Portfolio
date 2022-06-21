namespace MovieTheater
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MovieList = new System.Windows.Forms.ListBox();
            this.TheaterList = new System.Windows.Forms.ListBox();
            this.TimeList = new System.Windows.Forms.ListBox();
            this.seatAvalibility = new System.Windows.Forms.TextBox();
            this.extraBackground = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Login = new System.Windows.Forms.Button();
            this.purchaseTickets = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.enterAgeButton = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginSubmitButton = new System.Windows.Forms.Button();
            this.movieEditBox = new System.Windows.Forms.TextBox();
            this.movieTitle = new System.Windows.Forms.TextBox();
            this.theatersTitle = new System.Windows.Forms.TextBox();
            this.theatersEditBox = new System.Windows.Forms.TextBox();
            this.SubmitChanges = new System.Windows.Forms.Button();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.newPasswordBox = new System.Windows.Forms.TextBox();
            this.submitPasswordChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Welcome to the Jungle Theater";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MovieList
            // 
            this.MovieList.FormattingEnabled = true;
            this.MovieList.Location = new System.Drawing.Point(12, 47);
            this.MovieList.Name = "MovieList";
            this.MovieList.Size = new System.Drawing.Size(195, 290);
            this.MovieList.TabIndex = 1;
            this.MovieList.SelectedIndexChanged += new System.EventHandler(this.MovieList_SelectedIndexChanged);
            // 
            // TheaterList
            // 
            this.TheaterList.FormattingEnabled = true;
            this.TheaterList.Location = new System.Drawing.Point(213, 47);
            this.TheaterList.Name = "TheaterList";
            this.TheaterList.Size = new System.Drawing.Size(184, 290);
            this.TheaterList.TabIndex = 2;
            this.TheaterList.SelectedIndexChanged += new System.EventHandler(this.TheaterList_SelectedIndexChanged);
            // 
            // TimeList
            // 
            this.TimeList.FormattingEnabled = true;
            this.TimeList.Location = new System.Drawing.Point(403, 47);
            this.TimeList.Name = "TimeList";
            this.TimeList.Size = new System.Drawing.Size(184, 290);
            this.TimeList.TabIndex = 3;
            this.TimeList.SelectedIndexChanged += new System.EventHandler(this.TimeList_SelectedIndexChanged);
            // 
            // seatAvalibility
            // 
            this.seatAvalibility.Enabled = false;
            this.seatAvalibility.Location = new System.Drawing.Point(593, 47);
            this.seatAvalibility.Multiline = true;
            this.seatAvalibility.Name = "seatAvalibility";
            this.seatAvalibility.Size = new System.Drawing.Size(195, 290);
            this.seatAvalibility.TabIndex = 4;
            // 
            // extraBackground
            // 
            this.extraBackground.Enabled = false;
            this.extraBackground.Location = new System.Drawing.Point(-1, -3);
            this.extraBackground.Multiline = true;
            this.extraBackground.Name = "extraBackground";
            this.extraBackground.Size = new System.Drawing.Size(803, 455);
            this.extraBackground.TabIndex = 5;
            this.extraBackground.Visible = false;
            this.extraBackground.TextChanged += new System.EventHandler(this.extraBackground_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(719, 429);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(83, 23);
            this.Login.TabIndex = 7;
            this.Login.Text = "System Admin";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // purchaseTickets
            // 
            this.purchaseTickets.Enabled = false;
            this.purchaseTickets.Location = new System.Drawing.Point(213, 369);
            this.purchaseTickets.Name = "purchaseTickets";
            this.purchaseTickets.Size = new System.Drawing.Size(374, 49);
            this.purchaseTickets.TabIndex = 8;
            this.purchaseTickets.Text = "Purchase Tickets";
            this.purchaseTickets.UseVisualStyleBackColor = true;
            this.purchaseTickets.Click += new System.EventHandler(this.purchaseTickets_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 398);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(194, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 369);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "How many tickets?";
            // 
            // enterAgeButton
            // 
            this.enterAgeButton.Location = new System.Drawing.Point(288, 176);
            this.enterAgeButton.Name = "enterAgeButton";
            this.enterAgeButton.Size = new System.Drawing.Size(207, 94);
            this.enterAgeButton.TabIndex = 11;
            this.enterAgeButton.Text = "Enter";
            this.enterAgeButton.UseVisualStyleBackColor = true;
            this.enterAgeButton.Visible = false;
            this.enterAgeButton.Click += new System.EventHandler(this.enterAgeButton_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Enabled = false;
            this.ageTextBox.Location = new System.Drawing.Point(314, 43);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(180, 20);
            this.ageTextBox.TabIndex = 12;
            this.ageTextBox.Text = "Put your date of birth below.";
            this.ageTextBox.Visible = false;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(314, 113);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(169, 20);
            this.usernameBox.TabIndex = 13;
            this.usernameBox.Text = "Username: ";
            this.usernameBox.Visible = false;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(314, 139);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(169, 20);
            this.passwordBox.TabIndex = 14;
            this.passwordBox.Text = "Password: ";
            this.passwordBox.Visible = false;
            // 
            // loginSubmitButton
            // 
            this.loginSubmitButton.Location = new System.Drawing.Point(314, 166);
            this.loginSubmitButton.Name = "loginSubmitButton";
            this.loginSubmitButton.Size = new System.Drawing.Size(169, 23);
            this.loginSubmitButton.TabIndex = 15;
            this.loginSubmitButton.Text = "Login In";
            this.loginSubmitButton.UseVisualStyleBackColor = true;
            this.loginSubmitButton.Visible = false;
            this.loginSubmitButton.Click += new System.EventHandler(this.loginSubmitButton_Click);
            // 
            // movieEditBox
            // 
            this.movieEditBox.Location = new System.Drawing.Point(74, 136);
            this.movieEditBox.Multiline = true;
            this.movieEditBox.Name = "movieEditBox";
            this.movieEditBox.Size = new System.Drawing.Size(214, 94);
            this.movieEditBox.TabIndex = 16;
            this.movieEditBox.Visible = false;
            // 
            // movieTitle
            // 
            this.movieTitle.Enabled = false;
            this.movieTitle.Location = new System.Drawing.Point(74, 110);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(214, 20);
            this.movieTitle.TabIndex = 17;
            this.movieTitle.Text = "Edit Movie List (must be only 5 movies)";
            this.movieTitle.Visible = false;
            // 
            // theatersTitle
            // 
            this.theatersTitle.Enabled = false;
            this.theatersTitle.Location = new System.Drawing.Point(403, 110);
            this.theatersTitle.Name = "theatersTitle";
            this.theatersTitle.Size = new System.Drawing.Size(213, 20);
            this.theatersTitle.TabIndex = 18;
            this.theatersTitle.Text = "Edit Theater List (must be only 3 theaters)";
            this.theatersTitle.Visible = false;
            // 
            // theatersEditBox
            // 
            this.theatersEditBox.Location = new System.Drawing.Point(403, 136);
            this.theatersEditBox.Multiline = true;
            this.theatersEditBox.Name = "theatersEditBox";
            this.theatersEditBox.Size = new System.Drawing.Size(213, 94);
            this.theatersEditBox.TabIndex = 19;
            this.theatersEditBox.Visible = false;
            // 
            // SubmitChanges
            // 
            this.SubmitChanges.Location = new System.Drawing.Point(159, 253);
            this.SubmitChanges.Name = "SubmitChanges";
            this.SubmitChanges.Size = new System.Drawing.Size(129, 50);
            this.SubmitChanges.TabIndex = 20;
            this.SubmitChanges.Text = "Submit Changes";
            this.SubmitChanges.UseVisualStyleBackColor = true;
            this.SubmitChanges.Visible = false;
            this.SubmitChanges.Click += new System.EventHandler(this.SubmitChanges_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.Location = new System.Drawing.Point(403, 253);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(145, 45);
            this.ChangePassword.TabIndex = 21;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.UseVisualStyleBackColor = true;
            this.ChangePassword.Visible = false;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Location = new System.Drawing.Point(278, 150);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.Size = new System.Drawing.Size(177, 20);
            this.newPasswordBox.TabIndex = 22;
            this.newPasswordBox.Text = "Change this box to the new pasword";
            this.newPasswordBox.Visible = false;
            // 
            // submitPasswordChange
            // 
            this.submitPasswordChange.Location = new System.Drawing.Point(278, 176);
            this.submitPasswordChange.Name = "submitPasswordChange";
            this.submitPasswordChange.Size = new System.Drawing.Size(177, 48);
            this.submitPasswordChange.TabIndex = 23;
            this.submitPasswordChange.Text = "Submit";
            this.submitPasswordChange.UseVisualStyleBackColor = true;
            this.submitPasswordChange.Visible = false;
            this.submitPasswordChange.Click += new System.EventHandler(this.submitPasswordChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitPasswordChange);
            this.Controls.Add(this.newPasswordBox);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.SubmitChanges);
            this.Controls.Add(this.theatersEditBox);
            this.Controls.Add(this.theatersTitle);
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.movieEditBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.purchaseTickets);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.seatAvalibility);
            this.Controls.Add(this.TimeList);
            this.Controls.Add(this.TheaterList);
            this.Controls.Add(this.MovieList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.enterAgeButton);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginSubmitButton);
            this.Controls.Add(this.extraBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox MovieList;
        private System.Windows.Forms.ListBox TheaterList;
        private System.Windows.Forms.ListBox TimeList;
        private System.Windows.Forms.TextBox seatAvalibility;
        private System.Windows.Forms.TextBox extraBackground;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button purchaseTickets;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button enterAgeButton;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginSubmitButton;
        private System.Windows.Forms.TextBox movieEditBox;
        private System.Windows.Forms.TextBox theatersTitle;
        private System.Windows.Forms.TextBox theatersEditBox;
        private System.Windows.Forms.Button SubmitChanges;
        private System.Windows.Forms.TextBox movieTitle;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.TextBox newPasswordBox;
        private System.Windows.Forms.Button submitPasswordChange;
    }
}

