namespace MathQuizGame
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
            this.components = new System.ComponentModel.Container();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timeLeftTextBox = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusSign = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.plusEqualsSign = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.diference = new System.Windows.Forms.NumericUpDown();
            this.minusEqualSign = new System.Windows.Forms.Label();
            this.MinusRightLabel = new System.Windows.Forms.Label();
            this.minusSign = new System.Windows.Forms.Label();
            this.MinusLeftLabel = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.NumericUpDown();
            this.multiplyEqualSign = new System.Windows.Forms.Label();
            this.multiplyRightLabel = new System.Windows.Forms.Label();
            this.multiplySign = new System.Windows.Forms.Label();
            this.multiplyLeftLabel = new System.Windows.Forms.Label();
            this.quotion = new System.Windows.Forms.NumericUpDown();
            this.DivisionEqualsSign = new System.Windows.Forms.Label();
            this.DivisionRightLabel = new System.Windows.Forms.Label();
            this.DivisionSign = new System.Windows.Forms.Label();
            this.divisionLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotion)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(513, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(200, 52);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeLeftTextBox
            // 
            this.timeLeftTextBox.AutoSize = true;
            this.timeLeftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftTextBox.Location = new System.Drawing.Point(405, 23);
            this.timeLeftTextBox.Name = "timeLeftTextBox";
            this.timeLeftTextBox.Size = new System.Drawing.Size(102, 26);
            this.timeLeftTextBox.TabIndex = 1;
            this.timeLeftTextBox.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(54, 118);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            // 
            // plusSign
            // 
            this.plusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSign.Location = new System.Drawing.Point(172, 118);
            this.plusSign.Name = "plusSign";
            this.plusSign.Size = new System.Drawing.Size(70, 26);
            this.plusSign.TabIndex = 3;
            this.plusSign.Text = "+";
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(285, 118);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(70, 26);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            // 
            // plusEqualsSign
            // 
            this.plusEqualsSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusEqualsSign.Location = new System.Drawing.Point(381, 118);
            this.plusEqualsSign.Name = "plusEqualsSign";
            this.plusEqualsSign.Size = new System.Drawing.Size(70, 26);
            this.plusEqualsSign.TabIndex = 5;
            this.plusEqualsSign.Text = "=";
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(457, 118);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(61, 32);
            this.sum.TabIndex = 2;
            this.sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // diference
            // 
            this.diference.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diference.Location = new System.Drawing.Point(457, 156);
            this.diference.Name = "diference";
            this.diference.Size = new System.Drawing.Size(61, 32);
            this.diference.TabIndex = 3;
            this.diference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minusEqualSign
            // 
            this.minusEqualSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusEqualSign.Location = new System.Drawing.Point(381, 156);
            this.minusEqualSign.Name = "minusEqualSign";
            this.minusEqualSign.Size = new System.Drawing.Size(70, 26);
            this.minusEqualSign.TabIndex = 10;
            this.minusEqualSign.Text = "=";
            // 
            // MinusRightLabel
            // 
            this.MinusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusRightLabel.Location = new System.Drawing.Point(285, 156);
            this.MinusRightLabel.Name = "MinusRightLabel";
            this.MinusRightLabel.Size = new System.Drawing.Size(70, 26);
            this.MinusRightLabel.TabIndex = 9;
            this.MinusRightLabel.Text = "?";
            // 
            // minusSign
            // 
            this.minusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusSign.Location = new System.Drawing.Point(172, 156);
            this.minusSign.Name = "minusSign";
            this.minusSign.Size = new System.Drawing.Size(70, 26);
            this.minusSign.TabIndex = 8;
            this.minusSign.Text = "-";
            // 
            // MinusLeftLabel
            // 
            this.MinusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusLeftLabel.Location = new System.Drawing.Point(54, 156);
            this.MinusLeftLabel.Name = "MinusLeftLabel";
            this.MinusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.MinusLeftLabel.TabIndex = 7;
            this.MinusLeftLabel.Text = "?";
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.Location = new System.Drawing.Point(457, 194);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(61, 32);
            this.Product.TabIndex = 4;
            this.Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // multiplyEqualSign
            // 
            this.multiplyEqualSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyEqualSign.Location = new System.Drawing.Point(381, 194);
            this.multiplyEqualSign.Name = "multiplyEqualSign";
            this.multiplyEqualSign.Size = new System.Drawing.Size(70, 26);
            this.multiplyEqualSign.TabIndex = 15;
            this.multiplyEqualSign.Text = "=";
            // 
            // multiplyRightLabel
            // 
            this.multiplyRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyRightLabel.Location = new System.Drawing.Point(285, 194);
            this.multiplyRightLabel.Name = "multiplyRightLabel";
            this.multiplyRightLabel.Size = new System.Drawing.Size(70, 26);
            this.multiplyRightLabel.TabIndex = 14;
            this.multiplyRightLabel.Text = "?";
            // 
            // multiplySign
            // 
            this.multiplySign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplySign.Location = new System.Drawing.Point(172, 194);
            this.multiplySign.Name = "multiplySign";
            this.multiplySign.Size = new System.Drawing.Size(70, 26);
            this.multiplySign.TabIndex = 13;
            this.multiplySign.Text = "*";
            // 
            // multiplyLeftLabel
            // 
            this.multiplyLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyLeftLabel.Location = new System.Drawing.Point(54, 194);
            this.multiplyLeftLabel.Name = "multiplyLeftLabel";
            this.multiplyLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.multiplyLeftLabel.TabIndex = 12;
            this.multiplyLeftLabel.Text = "?";
            // 
            // quotion
            // 
            this.quotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotion.Location = new System.Drawing.Point(457, 232);
            this.quotion.Name = "quotion";
            this.quotion.Size = new System.Drawing.Size(61, 32);
            this.quotion.TabIndex = 5;
            this.quotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DivisionEqualsSign
            // 
            this.DivisionEqualsSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionEqualsSign.Location = new System.Drawing.Point(381, 232);
            this.DivisionEqualsSign.Name = "DivisionEqualsSign";
            this.DivisionEqualsSign.Size = new System.Drawing.Size(70, 26);
            this.DivisionEqualsSign.TabIndex = 20;
            this.DivisionEqualsSign.Text = "=";
            // 
            // DivisionRightLabel
            // 
            this.DivisionRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionRightLabel.Location = new System.Drawing.Point(285, 232);
            this.DivisionRightLabel.Name = "DivisionRightLabel";
            this.DivisionRightLabel.Size = new System.Drawing.Size(70, 26);
            this.DivisionRightLabel.TabIndex = 19;
            this.DivisionRightLabel.Text = "?";
            // 
            // DivisionSign
            // 
            this.DivisionSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionSign.Location = new System.Drawing.Point(172, 232);
            this.DivisionSign.Name = "DivisionSign";
            this.DivisionSign.Size = new System.Drawing.Size(70, 26);
            this.DivisionSign.TabIndex = 18;
            this.DivisionSign.Text = "/";
            // 
            // divisionLeftLabel
            // 
            this.divisionLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionLeftLabel.Location = new System.Drawing.Point(54, 232);
            this.divisionLeftLabel.Name = "divisionLeftLabel";
            this.divisionLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.divisionLeftLabel.TabIndex = 17;
            this.divisionLeftLabel.Text = "?";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(135, 285);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(271, 46);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 361);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotion);
            this.Controls.Add(this.DivisionEqualsSign);
            this.Controls.Add(this.DivisionRightLabel);
            this.Controls.Add(this.DivisionSign);
            this.Controls.Add(this.divisionLeftLabel);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.multiplyEqualSign);
            this.Controls.Add(this.multiplyRightLabel);
            this.Controls.Add(this.multiplySign);
            this.Controls.Add(this.multiplyLeftLabel);
            this.Controls.Add(this.diference);
            this.Controls.Add(this.minusEqualSign);
            this.Controls.Add(this.MinusRightLabel);
            this.Controls.Add(this.minusSign);
            this.Controls.Add(this.MinusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.plusEqualsSign);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusSign);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLeftTextBox);
            this.Controls.Add(this.TimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label timeLeftTextBox;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusSign;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label plusEqualsSign;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown diference;
        private System.Windows.Forms.Label minusEqualSign;
        private System.Windows.Forms.Label MinusRightLabel;
        private System.Windows.Forms.Label minusSign;
        private System.Windows.Forms.Label MinusLeftLabel;
        private System.Windows.Forms.NumericUpDown Product;
        private System.Windows.Forms.Label multiplyEqualSign;
        private System.Windows.Forms.Label multiplyRightLabel;
        private System.Windows.Forms.Label multiplySign;
        private System.Windows.Forms.Label multiplyLeftLabel;
        private System.Windows.Forms.NumericUpDown quotion;
        private System.Windows.Forms.Label DivisionEqualsSign;
        private System.Windows.Forms.Label DivisionRightLabel;
        private System.Windows.Forms.Label DivisionSign;
        private System.Windows.Forms.Label divisionLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

